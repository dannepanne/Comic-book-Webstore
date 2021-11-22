using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataSource.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComicWebstoreExa.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public int ID { get; set; }

        public IDataAccess _dataAccess { get; private set; }
        public ILoggedIn _login { get; }

        public LoginModel(IDataAccess dataAccess, ILoggedIn loggdIn)
        {
            _dataAccess = dataAccess;
            _login = loggdIn;
        }


        public List<CustomerDTO> Customers = new List<CustomerDTO>();

        public void OnGet()
        {
            Customers = _dataAccess.GetListCust();
        }

        public IActionResult OnPostLogin()
        {
            if (ModelState.IsValid)
            {

                //thisCustomer = _dataAccess.CustGetById(id, Customers);
                _login.setCust(_dataAccess.CustGetById(ID));
                //Cart.Cart newCart = new Cart.Cart() { CustCartID = CustomerID }; skapa denna i webshoppen 
                return RedirectToPage("/WebShop/WebShop", "WebShop"/*, new {ID}*/);
            }

            return Page();
        }
       
    }
}
