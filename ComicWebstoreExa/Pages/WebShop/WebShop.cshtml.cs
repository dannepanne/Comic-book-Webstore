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

        public int ProductID { get; set; }

        public IDataAccess _dataAccess { get; private set; }

        public WebShopModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }



        public List<ProductDTO> Products = new List<ProductDTO>();
        public List<CustomerDTO> Customers = new List<CustomerDTO>();



        public void OnGet(int id, Cart.Cart newcart)
        {
            Customers = _dataAccess.GetListCust();
            CustomerDTO result = (CustomerDTO)Customers.Where(s => s.CustomerID == id);
            thisCustomer = result;
            NewCart = newcart;
            CustomerID = id;
            Products = _dataAccess.GetAllProducts().ToList();
        }

        public IActionResult PutInCart()
        {
            if (ModelState.IsValid)
            {
                ProductDTO result = (ProductDTO)Products.Where(s => s.ProductID == ProductID);
                thisCustomer.ProductsInCart.Add(result);

                return Page();
            }
            return Page();
        }


    }
}
