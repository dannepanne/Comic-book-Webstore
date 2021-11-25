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
        public IEnumerable<ProductDTO> GetAllProducts()
        {
            //var path = Path.GetDirectoryName("ProductsJson.json");
            var pathp = @"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\ProductsJson.json";
            var jsonp = File.ReadAllText(pathp);
            var addProducts = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(jsonp);
            return addProducts;

        }

        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            //var path = Path.GetDirectoryName("CustomerJson.json");
            var path = @"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\CustomersJson.json";
            var json = File.ReadAllText(path);
            var addCustomers = JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(json);
            return addCustomers;
        }

        public string CustomersDataProvider()
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\CustomersJson.json");

            return jsonRepsonse;
        }
        public string ProductsDataProvider()
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\ProductsJson.json");

            return jsonRepsonse;
        }
    }
}
