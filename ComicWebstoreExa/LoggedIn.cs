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
        //public List<ProductDTO> currentCart { get; set; }
        
        public bool IsLoggedIn()
        {
            return IsLogIn;
        }

        public void setCust(CustomerDTO cust)
        {
            currentCustomer = cust;
            IsLogIn = true;
            
        }
        public void setCart(int cartid)
        {
            currentCustomer.customerCart = new Cart() { CartID = cartid, CustCartID = currentCustomer.CustomerID, isPaid = false, ProductsInCart = new List<ProductDTO>() };
        }
        public void setCCard(string name, int number)
        {
            currentCustomer.cCard = new CreditCard() { CardName = name, CardNumber = number };
        }
        public CustomerDTO giveCust()
        {
            return currentCustomer;
        }
        public List<ProductDTO> giveCart()
        {

            return currentCustomer.customerCart.ProductsInCart;
        }
        public int GetCartID()
        {
            return currentCustomer.customerCart.CartID;
        }
        //public void SetCartID(int cart)
        //{
        //    cartID = cart;
        //}
        public void RemoveItemAt(int itemID)
        {

            int index = currentCustomer.customerCart.ProductsInCart.FindIndex(p => p.ProductID == itemID);
            currentCustomer.customerCart.ProductsInCart.RemoveAt(index);

        }
        public void resetCart()
        {
            currentCustomer.customerCart.ProductsInCart.Clear();
        }


    }
}
