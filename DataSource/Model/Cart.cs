using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Model
{
    public class Cart
    {
        public List<ProductDTO> ProductsInCart { get; set; }
        public Guid CartID { get; set; }
        public int CustCartID { get; set; }
        public bool isPaid { get; set; }

        public int CartSum()
        {
            int sum = 0;
            foreach (var item in ProductsInCart)
            {
                sum += item.ProductPrice;
            }
            return sum;

        }
    }
}
