using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataSource.Model
{
    public class Reciept
    {
        [JsonPropertyName("RecieptCartId")]
        public int RecieptCartID { get; set; }
        [JsonPropertyName("RecieptProducts")]
        public List<ProductDTO> RecieptProducts { get; set; }
        [JsonPropertyName("RecieptSum")]
        public int RecieptSum { get; set; }
        [JsonPropertyName("isPaid")]
        public bool isPaid { get; set; }
        [JsonPropertyName("ccard")]
        public CreditCard ccard { get; set; }

    }
}
