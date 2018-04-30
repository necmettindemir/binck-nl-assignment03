using MvcRestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRestServer.DataRepository
{
    public class Repository
    {

        public static List<Customer> CustomerList;

        static Repository()
        {
            CustomerList = new List<Customer>();

            CustomerList.Add(new Customer { id = 1, FirstName = "Frodo", LastName = "Baggins" });
            CustomerList.Add(new Customer { id = 2, FirstName = "Bilbo", LastName = "Baggins" });

        }


        public static List<Customer> GetCustomerList()
        {
            return CustomerList;
        }


    }
}