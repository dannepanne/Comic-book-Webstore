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

        //public int cartID { get; set; }
        public CartModel(IDataAccess _dataaccess, ILoggedIn _loggedin)
        {
            DataAccess = _dataaccess;
            LoggedIn = _loggedin;
        }



        [BindProperty]
        public int itemID { get; set; }
        public CustomerDTO CurrentCustomer { get; set; }

        public IDataAccess DataAccess { get; }

        public ILoggedIn LoggedIn { get; }

        public void OnGet()
        {
            if (LoggedIn.IsLoggedIn() == true) //om det finns en inloggad kund s� h�mtas denna och sparas i CurrentCustomer
            {
                CurrentCustomer = LoggedIn.giveCust();
            
            
                if (CurrentCustomer.cCard == null)
                {
                    DataAccess.CreateCreditCard(CurrentCustomer); //har CurrentCustomer inget CreditCard s� skapas ett h�r
                }
                
            }
            
        }
        public int ProductsTotal() //r�knar ut totalsumman f�r varor i Cart
        {
            CurrentCustomer = LoggedIn.giveCust();
            int total = 0;
            foreach (var item in CurrentCustomer.customerCart.ProductsInCart)
            {
                total += item.ProductPrice;
            }

            return total;
        }


        public int ShippingTotal() // r�knar ut frakt p� CurrentCustomer Cart
        {
            CurrentCustomer = LoggedIn.giveCust();
            int shiptot = DataAccess.CalculateShipping(CurrentCustomer.customerCart.ProductsInCart);
            return shiptot;
        }
        public void OnPostRemoveItem() //tar bort en vara ur CurrentCustomer Cart
        {
            LoggedIn.RemoveItemAt(itemID);
            CurrentCustomer = LoggedIn.giveCust();
           
        }
    }
}
