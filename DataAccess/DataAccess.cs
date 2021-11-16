using DataSource;
using DataSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AccessProducts()
        {
            Products = (List<ProductDTO>)_dataSource.GetAllProducts();

        }

        public void AccessCustomers()
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

    }
}