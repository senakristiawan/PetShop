using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetShop.Model;

namespace PetShop.Repository
{
    public class LoginRepository
    {
        PetshopEntities db = new PetshopEntities();
        public Customer login(string email, string password)
        {
            Customer customer = db.Customers.Where(x => x.CustomerEmail == email && x.CustomerPassword == password).FirstOrDefault();
            return customer;
        }
    }
}