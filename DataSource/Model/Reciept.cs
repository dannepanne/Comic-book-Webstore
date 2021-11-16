using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Model
{
    class Reciept
    {
        public int RecieptCartID { get; set; }
        public List<ProductDTO> RecieptProducts { get; set; }
        public int RecieptSum { get; set; }
    }
}
