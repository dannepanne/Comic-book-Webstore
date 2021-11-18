using DataSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicWebstoreExa.Pages.Cart
{
    public class Cart
    {
        public List<ProductDTO> ProductsInCart { get; set; }
        public Guid CartID { get; set; }
        public int CustCartID { get; set; }
        public bool isPaid { get; set; }
    }
}
