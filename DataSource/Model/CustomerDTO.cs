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
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }
        [JsonPropertyName("CustomerID")]
        public int CustomerID { get; set; }

        [JsonPropertyName("Password")]
        public string Password { get; set; }

        [JsonPropertyName("Reciepts")]
        public List<Reciept> Reciepts { get; set; }

        [JsonPropertyName("cCard")]
        public CreditCard cCard { get; set; }

        
        //public List<ProductDTO> ProductsInCart = new List<ProductDTO>();

        [JsonPropertyName("customerCart")]
        public Cart customerCart { get; set; }

        public string FullName()
        {
            string fullname = FirstName + " " + LastName;
            return fullname;
        }

    }
}
