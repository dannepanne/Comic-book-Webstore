using DataSource;
using DataSource.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class DataAccess : IDataAccess
    {

        public List<ProductDTO> Products = new List<ProductDTO>();
        public List<CustomerDTO> Customers = new List<CustomerDTO>();

        public IDataSource _dataSource { get; private set; }

        public DataAccess(IDataSource dataSource) //DI för DataSource för åtkomst till JSON 
        {
            _dataSource = dataSource;
        }

        public List<ProductDTO> GetListProd() //returnerar en List<ProductDTO> / lista på produkter
        {
            List<ProductDTO> prodlist = _dataSource.GetAllProducts().ToList(); ;
            return prodlist;
        }

        public void AccessProducts() //onödig, ej implementerad
        {
            Products = (List<ProductDTO>)_dataSource.GetAllProducts();

        }

        public List<CustomerDTO> GetListCust() // returnerar en List<CustomerDTO> / lista på kunder
        {
            List<CustomerDTO> custlist = _dataSource.GetAllCustomers().ToList(); ;
            return custlist;
        }


        public void AccessCustomers() //onödig, ej implementerad
        {
            Customers = (List<CustomerDTO>)_dataSource.GetAllCustomers();
        }

        public CustomerDTO CustGetById(int idwhere) // tar in en customer id int och returnerar en CustomerDTO / kund som har samma id som den int som skickats med metoden
        {
            
            List<CustomerDTO> CustomerList = GetListCust();
            foreach (var item in CustomerList)
            {
                if (item.CustomerID == idwhere)
                {
                    return item;
                }
            }
            return null;
        }
        public ProductDTO ProdGetById(int idwhere) // tar in en product id int och returnerar en ProductDTO / kund som har samma id som den int som skickats med metoden
        {
            
            List<ProductDTO> ProductList = GetListProd();
            foreach (ProductDTO item in ProductList)
            {
                if (item.ProductID == idwhere)
                {
                    return item;
                }
            }
            return null;

        }

        public IEnumerable<ProductDTO> GetAllProducts() //deserialiserar JSON från DataSource och returnerar en IEnumerable<ProductDTO>
        {
            var jsonResponse = _dataSource.ProductsDataProvider();
            IEnumerable<ProductDTO> products = JsonConvert.DeserializeObject<IEnumerable<ProductDTO>>(jsonResponse);

            return products;
        }

        public int CalculateShipping(List<ProductDTO> prodlist) //Enkel metod för att räkna ut shipping beroende på typ av produkt, returnerar en int
        {
            int result = 0;
            foreach (var item in prodlist)
            {
                if (item.ProductType == "Physical")
                {
                    result += 49;
                }
            }
            return result;
        }


        public IEnumerable<ProductDTO> SortListProName() //returnerar en sorterad IEnumerable<ProductDTO> sorterad per produktnamn
        {

            return GetAllProducts().OrderBy(p => p.ProductName);


        }


        public IEnumerable<ProductDTO> SortListProPrice() //returnerar en sorterad IEnumerable<ProductDTO> sorterad per produktpris
        {

            return GetAllProducts().OrderBy(p => p.ProductPrice);

        }



        public IEnumerable<ProductDTO> SearchBarName(string search) //returnerar en  IEnumerable<ProductDTO> med ProductDTO:s som innehåller search string i product name
        {
            if (string.IsNullOrEmpty(search))
            {
                return GetAllProducts();
            }
            else
            {
                return GetAllProducts().Where(p => p.ProductName.ToLower().Contains(search.ToLower()));
            }
        }


        public void CustomerListSerialize(List<CustomerDTO> custlist)
        {

            var path = @"C:\Users\danne\source\repos\ComicWebstoreExa\DataSource\JSONData\CustomersJson.json";
            var serializedUsers = JsonConvert.SerializeObject(custlist, Formatting.Indented);
            File.WriteAllText(path, serializedUsers);

        }


        public int CreateCartID(CustomerDTO cust) //skapar en Cart, ger den ett cartid som räknas på kund id samt antalet kvitton
        {
            int cartid = cust.CustomerID + 1;

            if ( cust.Reciepts.Count != 0)
            {
                foreach (var item in cust.Reciepts)
                {
                    cartid = +1;
                }
            }


            return cartid;
        }



        public CreditCard CreateCreditCard(CustomerDTO cust) //enkel metod som skapar ett CreditCard med nummer och namn på kortet
        {
            CreditCard cCard = new CreditCard { CardNumber = cust.CustomerID + cust.CustomerID + cust.CustomerID, CardName = cust.FullName() };
            return cCard;
        }




        public void UpdateCustomerList(CustomerDTO cust) //tar in en CustomerDTO och uppdaterar List<CustomerDTO>. cust ersätter den CustomerDTO i listan med samma id. Skriver sedan den uppdaterade listan till CustomerJSON.json
        {
            Customers = GetListCust().ToList();

            foreach (var item in Customers.ToList())
            {
                if (cust.CustomerID == item.CustomerID)
                {
                    var IndexOfUser = Customers.IndexOf(item);
                    Customers[IndexOfUser] = cust;

                }
            }
            CustomerListSerialize(Customers);

            
        }


        public Reciept ReturnReciept(CustomerDTO cust, int id, List<ProductDTO> list, int total, CreditCard card) //skapar ett kvitto baserat på produktlista, customer id, creditcart, summa samt ger kvittot en ispaid = true status. returnerar kvittot
        {

            Reciept reciept = new Reciept() { RecieptCartID = id, RecieptProducts = list.ToList(), RecieptSum = cust.customerCart.CartSum(), isPaid = true, ccard = card };
            return reciept;

        }

    }
}