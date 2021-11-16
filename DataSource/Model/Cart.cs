using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Model
{
    class Cart
    {
        public List<ProductDTO> ProductsInCart { get; set; }
        public int CartID { get; set; }
    }
}
