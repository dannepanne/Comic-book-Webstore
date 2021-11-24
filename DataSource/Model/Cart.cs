using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataSource.Model
{
    public class Cart
    {
        [JsonPropertyName("ProductsInCart")]
        public List<ProductDTO> ProductsInCart { get; set; }
        [JsonPropertyName("CartID")]
        public int CartID { get; set; }
        [JsonPropertyName("CustCartID")]
        public int CustCartID { get; set; }
        [JsonPropertyName("isPaid")]
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
