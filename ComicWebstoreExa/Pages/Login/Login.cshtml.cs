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

        public LoginModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
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

                
                //Cart.Cart newCart = new Cart.Cart() { CustCartID = CustomerID }; skapa denna i webshoppen 
                return RedirectToPage("/WebShop/WebShop", "WebShop", new { ID });
            }

            return Page();
        }
       
    }
}
