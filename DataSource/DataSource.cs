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
        public IEnumerable<ProductDTO> GetAllProducts() //returnerar IEnumerable<ProductDTO> som är deserialized från ProductsJson.json
        {
            //var path = Path.GetDirectoryName("ProductsJson.json");
            var pathp = @"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\ProductsJson.json";
            var jsonp = File.ReadAllText(pathp);
            var addProducts = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(jsonp);
            return addProducts;

        }

        public IEnumerable<CustomerDTO> GetAllCustomers() //returnerar IEnumerable<CustomerDTO> som är deserialized från CustomersJson.json
        {
            //var path = Path.GetDirectoryName("CustomerJson.json");
            var path = @"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\CustomersJson.json";
            var json = File.ReadAllText(path);
            var addCustomers = JsonConvert.DeserializeObject<IEnumerable<CustomerDTO>>(json);
            return addCustomers;
        }

        public string CustomersDataProvider() //Returnerar CustomersJson.json path
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\CustomersJson.json");

            return jsonRepsonse;
        }
        public string ProductsDataProvider() //returnerar ProductsJson.json path
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\ProductsJson.json");

            return jsonRepsonse;
        }
    }
}
