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

        [JsonPropertyName("reciepts")]
        public List<Reciept> Reciepts { get; set; }

        [JsonPropertyName("creditcard")]
        public CreditCard cCard { get; set; }

        
        //public List<ProductDTO> ProductsInCart = new List<ProductDTO>();

        [JsonPropertyName("cart")]
        public Cart customerCart { get; set; }

        public string FullName()
        {
            string fullname = FirstName + " " + LastName;
            return fullname;
        }

    }
}
