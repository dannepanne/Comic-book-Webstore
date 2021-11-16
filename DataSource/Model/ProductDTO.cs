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
        [JsonPropertyName("prodname")]
        public string ProductName { get; set; }

        [JsonPropertyName("prodprice")]
        public int ProductPrice { get; set; }

        [JsonPropertyName("prodimage")]
        public string ProductImage { get; set; }

        [JsonPropertyName("prodid")]
        public int ProductID { get; set; }

        [JsonPropertyName("proddesc")]
        public string ProductDescription { get; set; }

    }
    public class DigitalProduct : ProductDTO
    {

    }
    public class PhysicalProduct : ProductDTO
    {

    }
}
