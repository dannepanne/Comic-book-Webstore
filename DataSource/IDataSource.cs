using System.Collections;

namespace DataSource
{
    public interface IDataSource
    {

        public IEnumerable GetAllProducts();

        public IEnumerable GetAllCustomers();

    }
}