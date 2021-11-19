using DataSource;
using DataSource.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DataAccess : IDataAccess
    {
        
        public List<ProductDTO> Products = new List<ProductDTO>();
        public List<CustomerDTO> Customers = new List<CustomerDTO>();
       
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

        public CustomerDTO CustGetById(int idwhere, List<CustomerDTO> CustomerList)
        {
            //int index = 0;
            //CustomerDTO result =  t in Customers where t.CustomerID = idwhere;//
            //var result = (CustomerDTO)Customers.Where(s => s.CustomerID == idwhere);
            //CustomerDTO result = Customers.FirstOrDefault(o => o.CustomerID == idwhere);
            //return result;
            //return ((CustomerDTO)(from i in Customers where i.CustomerID == idwhere select i));
            //for (int i = 0; i < Customers.Count; i++)
            //{
            //    if (Customers[i].CustomerID == idwhere)
            //    {
            //        index = i;
            //    }
            //}
            //return Customers[index];
            //return result;
            foreach (var item in CustomerList)
            {
                if (item.CustomerID == idwhere)
                {
                    return item;
                }
            }
            return null;
        }
        public ProductDTO ProdGetById(int idwhere, List<ProductDTO> ProductList)
        {
            //ProductDTO result = (ProductDTO)Products.Where(s => s.ProductID == idwhere);
            foreach (var item in ProductList)
            {
                if (item.ProductID == idwhere)
                {
                    return item;
                }
            }
            return null;

        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var jsonResponse = _dataSource.ProductsDataProvider();
            IEnumerable<ProductDTO> products = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(jsonResponse);
            
            return products;
        }

        public int CalculateShipping(List<ProductDTO> prodlist)
        {
            int result = 0;
            foreach (var item in prodlist)
            {
                if (item.ProductType == "physical")
                {
                    result += 49;
                }
            }
            return result;
        }



    }
}