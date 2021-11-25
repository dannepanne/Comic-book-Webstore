using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataSource.Model
{
    public class ProductDTO
    {
        
        [JsonPropertyName("productname")]
        public string ProductName { get; set; }

        [JsonPropertyName("productprice")]
        public int ProductPrice { get; set; }

        [JsonPropertyName("productimage")]
        public string ProductImage { get; set; }

        [JsonPropertyName("productid")]
        public int ProductID { get; set; }

        [JsonPropertyName("productdescription")]
        public string ProductDescription { get; set; }

        [JsonPropertyName("producttype")]
        public string ProductType { get; set; }

        public int Weight { get; set; }

    }
    public class ProductDigitalDTO : ProductDTO
    {

        new public int Weight = 0;
    }
    public class ProductPhysicalDTO : ProductDTO
    {

    }
  
}
