using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource.Model
{
    class Order
    {
        List<ProductDTO> orderProductList = new List<ProductDTO>();
        public int UserID { get; set; }
        public Reciept reciept { get; set; }
        public bool IsPaid { get; set; }
    }
}
