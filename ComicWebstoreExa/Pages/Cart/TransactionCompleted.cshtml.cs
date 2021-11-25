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
    public class TransactionCompletedModel : PageModel
    {
        public TransactionCompletedModel(IDataAccess dataAccess, ILoggedIn loggedIn)
        {
            _dataAccess = dataAccess;
            _loggedin = loggedIn;
        }
        public Reciept newReciept { get; set; }
        public CustomerDTO thisCust { get; set; }
        public IDataAccess _dataAccess { get; }
        public ILoggedIn _loggedin { get; }

        public int ProductsTotal()
        {
            int total = 0;
            foreach (var item in thisCust.customerCart.ProductsInCart)
            {
                total += item.ProductPrice;
            }
            return total;
        }

        public void OnGet()
        {
            if (_loggedin.IsLoggedIn() == true)
            {
                thisCust = _loggedin.giveCust();
                newReciept = _dataAccess.ReturnReciept(thisCust, _loggedin.GetCartID(), thisCust.customerCart.ProductsInCart, ProductsTotal() + _dataAccess.CalculateShipping(thisCust.customerCart.ProductsInCart), thisCust.cCard);
                if (thisCust.Reciepts == null)
                {
                    thisCust.Reciepts = new List<Reciept>();
                    thisCust.Reciepts.Add(newReciept);
                }
                else
                {
                    newReciept.RecieptCartID += 1;
                    thisCust.Reciepts.Add(newReciept);
                }

                _loggedin.resetCart();
                _dataAccess.UpdateCustomerList(_loggedin.giveCust());
                _dataAccess.CustomerListSerialize(_dataAccess.GetListCust());
            }
            else
            {
               RedirectToPage("/Error", "Error");
            }
            
        }

        
    }
}
