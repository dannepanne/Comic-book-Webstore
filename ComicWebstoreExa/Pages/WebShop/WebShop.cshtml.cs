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
        [BindProperty]
        public string sortTerm { get; set; }
        [BindProperty]
        public string searchItem { get; set; }
        public CustomerDTO thisCustomer { get; set; }

        [BindProperty]
        public int ProductID { get; set; }
        public ILoggedIn _login { get; }
        public IDataAccess _dataAccess { get; }


        public WebShopModel(IDataAccess dataAccess, ILoggedIn login)
        {
            _login = login;
            _dataAccess = dataAccess;
            SetCustomer();
            LoadProducts();
        }


        public List<ProductDTO> ProductList = new();
        



        public void SearchName(string searchItem)
        {

            ProductList = _dataAccess.SearchBarName(searchItem).ToList();

        }

        public List<ProductDTO> LoadProducts()
        {

            return _dataAccess.GetAllProducts().ToList();
        }

        public void OnPostSubmit(string sortTerm)
        {
            ProductList = _dataAccess.SortListProd(sortTerm).ToList();
        }



        public CustomerDTO SetCustomer()
        {
            return thisCustomer = _login.giveCust();
        }


        public void OnGet()
        {
          
            ProductList = _dataAccess.GetListProd();

            thisCustomer = _login.giveCust();
            CustomerID = thisCustomer.CustomerID;
            if (thisCustomer.cCard == null)
            {
                _dataAccess.CreateCreditCard(thisCustomer);
            }
            
        }

        public void OnPostPutInCart()
        {
            ProductList = _dataAccess.GetListProd();
            thisCustomer = SetCustomer();
            ProductDTO result = _dataAccess.ProdGetById(ProductID);

            thisCustomer.ProductsInCart.Add(result);


        }




    }
}
