using DataSource.Model;
using System.Collections.Generic;

namespace ComicWebstoreExa
{
    public interface ILoggedIn
    {
        public void setCust(CustomerDTO cust);
        public void setCart(List<ProductDTO> cart);
        public List<ProductDTO> giveCart();
        public CustomerDTO giveCust();
        public int GetCartID();

        public void SetCartID(int cart);
        public bool IsLoggedIn();



    }
}