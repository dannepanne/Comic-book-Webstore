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
        public CustomerDTO thisCust { get; set; }
        public IDataAccess _dataAccess { get; }
        public ILoggedIn _loggedin { get; }

        public int ProductsTotal()
        {
            int total = 0;
            foreach (var item in thisCust.ProductsInCart)
            {
                total += item.ProductPrice;
            }
            return total;
        }
        //thisCust.ProductsInCart.Clear();
        public void OnGet()
        {
            thisCust = _loggedin.giveCust();
            //index of cart OnGet!
            _dataAccess.CreateReciept(thisCust, _loggedin.GetCartID(), thisCust.ProductsInCart, ProductsTotal() + _dataAccess.CalculateShipping(thisCust.ProductsInCart));
            
            //thisCust.Reciepts.Add(reciept);
            //_dataAccess.UpdateCustomerList(_loggedin.giveCust());
            //_dataAccess.CustomerListSerialize(_dataAccess.GetListCust());
        }

        
    }
}
/////////////////////////FEL KVITTONUMMER GES