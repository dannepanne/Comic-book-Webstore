using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataSource.Model
{
    public class CustomerDTO
    {
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }
        [JsonPropertyName("customerid")]
        public int CustomerID { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        List<Reciept> Reciepts { get; set; }

        CreditCard cCard = new CreditCard() { };

        public List<ProductDTO> ProductsInCart { get; set; }

        public List<Guid> CartList { get; set; }

    }
}
