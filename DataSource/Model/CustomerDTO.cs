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
        [JsonPropertyName("id")]
        public int CustomerID { get; set; }

        List<Reciept> Reciepts { get; set; }
    }
}
