using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using DataSource.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComicWebstoreExa.Pages
{
    public class WebShopModel : PageModel
    {

        

        public IDataAccess _dataAccess { get; private set; }

        public WebShopModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


        
        public List<ProductDTO> Products = new List<ProductDTO>();

        public void OnGet()
        {
            
            Products = _dataAccess.GetAllProducts().ToList() ;
        }
    }
}
