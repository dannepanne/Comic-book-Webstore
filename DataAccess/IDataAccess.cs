using DataSource.Model;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccess
    {
        public CustomerDTO CustGetById(int idwhere);
        public ProductDTO ProdGetById(int idwhere);
        public void AccessCustomers();
        public void AccessProducts();
        public List<CustomerDTO> GetListCust();
        public List<ProductDTO> GetListProd();
        public IEnumerable<ProductDTO> GetAllProducts();
        public IEnumerable<ProductDTO> SortListProName();
        public IEnumerable<ProductDTO> SortListProPrice();

        public IEnumerable<ProductDTO> SearchBarName(string search);
        //public Reciept CreateReciept(CustomerDTO cust, Cart cart, CreditCard card);
        public CreditCard CreateCreditCard(CustomerDTO cust);
        public void UpdateCustomerList(CustomerDTO cust);
        public int CreateCartID(CustomerDTO cust);
        public void CustomerListSerialize(List<CustomerDTO> custlist);
        public int CalculateShipping(List<ProductDTO> prodlist);
        //public void CreateReciept(CustomerDTO cust, int id, List<ProductDTO> list, int total);
        public Reciept ReturnReciept(CustomerDTO cust, int id, List<ProductDTO> list, int total, CreditCard card);

    }
}