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
    public class LoginModel : PageModel
    {
        public IDataAccess _dataAccess { get; private set; }

        public LoginModel(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        

        public List<CustomerDTO> Customers = new List<CustomerDTO>();

        public void OnGet()
        {
            Customers = _dataAccess.GetListCust();
        }
    }
}
