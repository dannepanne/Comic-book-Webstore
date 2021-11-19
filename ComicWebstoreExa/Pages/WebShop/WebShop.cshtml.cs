using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataSource.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComicWebstoreExa.Pages.WebShop
{
    public class WebShopModel : PageModel
    {
        [BindProperty]
        public int CustomerID { get; set; }
        public Cart.Cart NewCart { get; set; }

        public CustomerDTO thisCustomer { get; set; }

        [BindProperty]
        public int ProductID { get; set; }
        public ILoggedIn _login { get; }
        public IDataAccess _dataAccess { get; }


        public WebShopModel(IDataAccess dataAccess, ILoggedIn login)
        {
            _login = login;
            _dataAccess = dataAccess;
            Products = _dataAccess.GetAllProducts().ToList();
            Customers = _dataAccess.GetListCust();
        }


        public List<ProductDTO> Products { get; set; }
        public List<CustomerDTO> Customers { get; set; }

        
        
       


        public void OnGet(int id)
        {

            if (id != 0)
            {
                thisCustomer = _dataAccess.CustGetById(id, Customers);
                _login.setCust(thisCustomer);
                
                CustomerID = id;
            }

            thisCustomer = _login.giveCust();
            CustomerID = thisCustomer.CustomerID;
            
        }

        public void OnPostPutInCart()
        {
            thisCustomer = _login.giveCust();
            ProductDTO result = _dataAccess.ProdGetById(ProductID, Products); 
            
            thisCustomer.ProductsInCart.Add(result);


        }

        //public IActionResult GoToCart()
        //{
           

        //        //Cart.Cart newCart = new Cart.Cart() { CustCartID = CustomerID }; skapa denna i webshoppen 
        //        return RedirectToPage("/Cart/Cart", "Cart", new { CustomerID });
           
        //}


    }
}
