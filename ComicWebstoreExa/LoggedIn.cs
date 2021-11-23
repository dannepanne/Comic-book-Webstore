using DataSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicWebstoreExa
{
    public class LoggedIn : ILoggedIn
    {
        public bool IsLogIn = false;
        public CustomerDTO currentCustomer { get; set; }
        public List<ProductDTO> currentCart { get; set; }
        public int cartID { get; set; }
        public bool IsLoggedIn()
        {
            return IsLogIn;
        }

        public void setCust(CustomerDTO cust)
        {
            currentCustomer = cust;
            IsLogIn = true;
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
        public int GetCartID()
        {
            return cartID;
        }
        public void SetCartID(int cart)
        {
            cartID = cart;
        }
        
    }

   
}
