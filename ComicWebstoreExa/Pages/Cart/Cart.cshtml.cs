using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataSource.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComicWebstoreExa.Pages.Cart
{
    public class CartModel : PageModel
    {
        
    
        public CartModel(IDataAccess _dataaccess, ILoggedIn _loggedin)
        {
            DataAccess = _dataaccess;
            LoggedIn = _loggedin;
        }
        public int ProductsTotal()
        {
            int total = 0;
            foreach (var item in CurrentCustomer.ProductsInCart)
            {
                total += item.ProductPrice; 
            }
            return total;
        }

       

        public CustomerDTO CurrentCustomer { get; set; }

        public IDataAccess DataAccess { get; }

        public ILoggedIn LoggedIn { get; }

        public void OnGet(/*List<ProductDTO> thisCartList*/)
        {
            CurrentCustomer = LoggedIn.giveCust();
            //if (CurrentCustomer.ProductsInCart.Count > 0)
            //{
            //    foreach (var item in CurrentCustomer.ProductsInCart)
            //    {
            //        CurrentCart.ProductsInCart.Add(item);
            //        CurrentCart.CustCartID = CurrentCustomer.CustomerID;
            //        CurrentCustomer.CartList.Add(CurrentCart.CartID);
            //    }
            //}
            Cart newcart = DataAccess.
            
        }
    }
}
