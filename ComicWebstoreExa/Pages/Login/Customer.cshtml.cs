using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataSource.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ComicWebstoreExa.Pages.Login
{
    public class CustomerModel : PageModel //h�mtar kund. Fronend delen visar tidigare orders/kvitton samt kundinfo
    {
        public CustomerDTO thisCustomer { get; set; }
        public ILoggedIn _login { get; private set; }
        public CustomerModel(ILoggedIn loggdIn)
        {
            _login = loggdIn;
        }
        public void OnGet()
        {
        thisCustomer = _login.giveCust();
        }

        
    }
}
