using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetShop.Model;
namespace PetShop.Repository
{
    public class DatabaseRepository
    {
        private static PetshopEntities db = null;

        private DatabaseRepository() { }

        public static PetshopEntities getDb()
        {
            if(db == null)
            {
                db = new PetshopEntities();

            }
            return db;
        }
    }
}