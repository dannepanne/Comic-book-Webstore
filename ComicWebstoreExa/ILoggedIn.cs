using DataSource.Model;
using System.Collections.Generic;

namespace ComicWebstoreExa
{
    public interface ILoggedIn
    {
        public void setCust(CustomerDTO cust);
        public List<ProductDTO> giveCart();
        public CustomerDTO giveCust();
        public int GetCartID();
        public void setCart(int cartid);
        //public void SetCartID(int cart);
        public bool IsLoggedIn();
        public void resetCart();
        public void setCCard(string name, int number);
        public void RemoveItemAt(int itemID);

    }
}