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
    }
}