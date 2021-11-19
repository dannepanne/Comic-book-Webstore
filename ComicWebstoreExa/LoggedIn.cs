using DataSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicWebstoreExa
{
    public class LoggedIn : ILoggedIn
    {
        public CustomerDTO currentCustomer { get; set; }
        public List<ProductDTO> currentCart { get; set; }

        public void setCust(CustomerDTO cust)
        {
            currentCustomer = cust;
        }
        public void setCart(List<ProductDTO> cart)
        {
            currentCart = cart;
        }
        public CustomerDTO giveCust()
        {
            return currentCustomer;
        }
        public List<ProductDTO> giveCart()
        {
            return currentCart;
        }
    }

   
}
