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

        public int cartID { get; set; }
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
        public int ShippingTotal()
        {
            int shiptot = DataAccess.CalculateShipping(CurrentCustomer.ProductsInCart);
            return shiptot;
        }
       

        public CustomerDTO CurrentCustomer { get; set; }

        public IDataAccess DataAccess { get; }

        public ILoggedIn LoggedIn { get; }

        public void OnGet(/*List<ProductDTO> thisCartList*/)
        {
            CurrentCustomer = LoggedIn.giveCust();
            cartID = DataAccess.CreateCart(CurrentCustomer, CurrentCustomer.ProductsInCart);
            LoggedIn.SetCartID(cartID);
            DataAccess.UpdateCustomerList(LoggedIn.giveCust());


            //DataAccess.CustomerListSerialize(DataAccess.GetListCust());
            //if (CurrentCustomer.ProductsInCart.Count > 0)
            //{
            //    foreach (var item in CurrentCustomer.ProductsInCart)
            //    {
            //        CurrentCustomer.ProductsInCart.Add(item);
            //        CurrentCart.CustCartID = CurrentCustomer.CustomerID;
            //        CurrentCustomer.CartList.Add(CurrentCart.CartID);
            //    }
            //}
            
            
        }
    }
}
