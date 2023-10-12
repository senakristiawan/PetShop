using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetShop.Model;

namespace PetShop.Factory
{
    public class CustomerFactory
    {
        public static Customer insertCustomer(string name, string email, string password, string gender, string role)
        {
            Customer customer = new Customer();
            customer.CustomerName = name;
            customer.CustomerEmail = email;
            customer.CustomerPassword = password;
            customer.CustomerGender = gender;
            customer.CustomerRole = "user";

            return customer;
        }
    }
}