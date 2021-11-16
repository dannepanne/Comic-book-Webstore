using DataSource.Model;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    public class DataSource : IDataSource
    {
        public IEnumerable GetAllProducts()
        {
            var path = @"C:\Users\danne\source\repos\ExaWebStore.UI\ExaWebStore.DataSource\JsonData\ProductJson.json";
            var json = File.ReadAllText(path);
            var addProducts = JsonConvert.DeserializeObject<List<ProductDTO>>(json);
            return addProducts;

        }

        public IEnumerable GetAllCustomers()
        {
            var path = @"C:\Users\danne\source\repos\ExaWebStore.UI\ExaWebStore.DataSource\JsonData\CustomerJson.json";
            var json = File.ReadAllText(path);
            var addCustomers = JsonConvert.DeserializeObject<List<CustomerDTO>>(json);
            return addCustomers;
        }
    }
}
