using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataSource.Model
{
    public class CreditCard
    {
        [JsonPropertyName("cardnumber")]
        public int CardNumber { get; set; }
        [JsonPropertyName("cardname")]
        public string CardName { get; set; }
    }
}
