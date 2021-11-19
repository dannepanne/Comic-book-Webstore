using DataSource.Model;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccess
    {
        public CustomerDTO CustGetById(int idwhere, List<CustomerDTO> customerList);
        public ProductDTO ProdGetById(int idwhere, List<ProductDTO> ProductList);
        public void AccessCustomers();
        public void AccessProducts();
        public List<CustomerDTO> GetListCust();
        public List<ProductDTO> GetListProd();
        public IEnumerable<ProductDTO> GetAllProducts();
        
        


    }
}