using DataSource.Model;
using System.Collections.Generic;

namespace ComicWebstoreExa
{
    public interface ILoggedIn //interface för LoggedIn
    {
        public void setCust(CustomerDTO cust);
        public List<ProductDTO> giveCart();
        public CustomerDTO giveCust();
        public int GetCartID();
        public void setCart(int cartid);

        public bool IsLoggedIn();
        public void resetCart();
        public void setCCard(string name, int number);
        public void RemoveItemAt(int itemID);

    }
}