using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using PetShop.Repository;


namespace PetShop.Controller
{
    public class CustomerController
    {
        CustomerRepository repo;
        public CustomerController()
        {
            repo = new CustomerRepository();
        }
        public void Validate(string name, string email, string password, string gender, string address)
        {
            if(!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z\d]+$"))
            {
                throw new Exception("Password must have alphabet and number");
            }
            if (!repo.isEmailUnique(email))
            {
                throw new Exception("Email already exist");
            }
            if (!address.EndsWith("Street"))
            {
                throw new Exception("Address must end with 'Street'");
            }
            repo.addCustomer(name, email, password, gender, address);
        }
    }
}