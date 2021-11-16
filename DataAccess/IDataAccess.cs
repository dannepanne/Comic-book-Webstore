using DataSource.Model;

namespace DataAccess
{
    public interface IDataAccess
    {
        public CustomerDTO CustGetById(int idwhere);
        public ProductDTO ProdGetById(int idwhere);
        public void AccessCustomers();
        public void AccessProducts();
    }
}