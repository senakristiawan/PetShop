using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetShop.Model;
using PetShop.Factory;
namespace PetShop.Repository
{
    public class CustomerRepository
    {
        PetshopEntities db = new PetshopEntities();

        public  bool isEmailUnique(string email)
        {
            return db.Customers.Count(c => c.CustomerEmail == email) == 0;
        }
        public void addCustomer(string name, string email, string password, string gender, string address)
        {
            Customer customer = CustomerFactory.insertCustomer(name, email, password, gender, address);

            db.Customers.Add(customer);
            db.SaveChanges();
        }
    }
}