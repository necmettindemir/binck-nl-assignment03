using MvcRestServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcRestServer.Controllers
{
    public class CustomerController : ApiController
    {

        // GET api/Customer
        public IEnumerable<Customer> Get()
        {                        
            return DataRepository.Repository.CustomerList;
        }

        // GET api/Customer/5
        public Customer Get(int id)
        {            
            return DataRepository.Repository.CustomerList.Where(x => x.id == id).FirstOrDefault();
        }

        // POST api/Customer
        public void Post(Customer cust)
        {
            DataRepository.Repository.CustomerList.Add(cust);
        }

        // PUT api/Customer/5
        public void Put(int id, Customer cust)
        {
            Customer custCurrent = DataRepository.Repository.CustomerList.Where(x => x.id == id).FirstOrDefault();
            custCurrent.FirstName = cust.FirstName;
            custCurrent.LastName = cust.LastName;            
        }

        // DELETE api/Customer/5
        public void Delete(int id)
        {
            Customer custToDelete = DataRepository.Repository.CustomerList.Where(x => x.id == id).FirstOrDefault();
            DataRepository.Repository.CustomerList.Remove(custToDelete);
        }
    }
}
