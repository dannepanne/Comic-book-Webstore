using DataSource;
using DataSource.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DataAccess : IDataAccess
    {

        List<ProductDTO> Products = new List<ProductDTO>();

        List<CustomerDTO> Customers = new List<CustomerDTO>();

        public IDataSource _dataSource { get; private set; }

        public DataAccess(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public List<ProductDTO> GetListProd()
        {
            List<ProductDTO> prodlist = _dataSource.GetAllProducts().ToList(); ;
            return prodlist;
        }

        public void AccessProducts() //onödig??
        {
            Products = (List<ProductDTO>)_dataSource.GetAllProducts();

        }

        public List<CustomerDTO> GetListCust()
        {
            List<CustomerDTO> custlist = _dataSource.GetAllCustomers().ToList(); ;
            return custlist;
        }


        public void AccessCustomers() //onödig?
        {
            Customers = (List<CustomerDTO>)_dataSource.GetAllCustomers();
        }

        public CustomerDTO CustGetById(int idwhere)
        {
            CustomerDTO result = (CustomerDTO)Customers.Where(s => s.CustomerID == idwhere);

            return result;
        }
        public ProductDTO ProdGetById(int idwhere)
        {
            ProductDTO result = (ProductDTO)Products.Where(s => s.ProductID == idwhere);

            return result;

        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var jsonResponse = _dataSource.ProductsDataProvider();
            IEnumerable<ProductDTO> products = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(jsonResponse);
            
            return products;
        }

        

    }
}