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
        int productsTotal = 0;
    
        public CartModel(IDataAccess _dataaccess)
        {
            DataAccess = _dataaccess;
        }
        public int ProductsTotal(Cart cart)
        {
            int total = 0;
            foreach (var item in cart.ProductsInCart)
            {
                total += item.ProductPrice; 
            }
            return total;
        }

        
        public Cart CurrentCart { get; set; }

        public CustomerDTO CurrentCustomer { get; set; }

        public IDataAccess DataAccess { get; }

        public void OnGet(CustomerDTO thisCustomer)
        {
            CurrentCustomer = thisCustomer;
            foreach (var item in thisCustomer.ProductsInCart)
            {
                CurrentCart.ProductsInCart.Add(item);
                CurrentCart.CustCartID = CurrentCustomer.CustomerID;
                CurrentCustomer.CartList.Add(CurrentCart.CartID);
            }
        }
    }
}
