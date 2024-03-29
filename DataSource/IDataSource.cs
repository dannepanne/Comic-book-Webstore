﻿using DataSource.Model;
using System.Collections;
using System.Collections.Generic;

namespace DataSource
{
    public interface IDataSource //interface för DataSource
    {

        public IEnumerable<ProductDTO> GetAllProducts();

        public IEnumerable<CustomerDTO> GetAllCustomers();

        public string CustomersDataProvider();
        public string ProductsDataProvider();

    }
}