using DataSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicWebstoreExa
{
    public class LoggedIn : ILoggedIn //klass för att spara inloggad Customer för lätt åtkomst på alla sidor
    {
        public bool IsLogIn = false; //bool är false innan customer är inloggad
        public CustomerDTO currentCustomer { get; set; } //vid inloggning sparas den inloggade customern här
        
        
        public bool IsLoggedIn() //returnerar om customer är inloggad eller ej
        {
            return IsLogIn;
        }

        public void setCust(CustomerDTO cust) //initierar currentCustomer med den customer som loggar in och sätter IsLogIn till true
        {
            currentCustomer = cust;
            IsLogIn = true;
            
        }
        public void setCart(int cartid) //ger inloggad kund en Cart
        {
            currentCustomer.customerCart = new Cart() { CartID = cartid, CustCartID = currentCustomer.CustomerID, isPaid = false, ProductsInCart = new List<ProductDTO>() };
        }
        public void setCCard(string name, int number) //ger inloggad kund ett CreditCard
        {
            currentCustomer.cCard = new CreditCard() { CardName = name, CardNumber = number };
        }
        public CustomerDTO giveCust() //returnerar currentCustomer
        {
            return currentCustomer;
        }
        public List<ProductDTO> giveCart() //används ej
        {

            return currentCustomer.customerCart.ProductsInCart;
        }
        public int GetCartID() //returnerar id på currentCustomer Cart
        {
            return currentCustomer.customerCart.CartID;
        }
        
        public void RemoveItemAt(int itemID) //tar in ett int och tar bort en vara ur List<ProductDTO> i Cart som har samma product id som det itemID som skickats in i metoden 
        {

            int index = currentCustomer.customerCart.ProductsInCart.FindIndex(p => p.ProductID == itemID);
            currentCustomer.customerCart.ProductsInCart.RemoveAt(index);

        }
        public void resetCart() //nollställer  List<ProductDTO> i currentCustomer Cart
        {
            currentCustomer.customerCart.ProductsInCart.Clear();
        }


    }
}
