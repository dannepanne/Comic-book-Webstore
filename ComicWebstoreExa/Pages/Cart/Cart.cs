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
        public int CartID { get; set; }
    }
}
