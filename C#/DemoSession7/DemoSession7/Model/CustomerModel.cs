using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession7.Entities;
using System.Globalization;


namespace DemoSession7.Model
{
    public class CustomerModel
    {
        public static Customer[] FindAll()
        {
            Customer customer5 = new Customer
            {
                Id = "Cus005",
                Name = "Kagami",
                Gender = "Male",
                Birthday = DateTime.ParseExact("06/11/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };
            Customer customer1 = new Customer
            {
                Id = "Cus001",
                Name = "Henry",
                Gender = "Male",
                Birthday = DateTime.ParseExact("22/02/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };
            Customer customer2 = new Customer
            {
                Id = "Cus002",
                Name = "Adele",
                Gender = "Female",
                Birthday = DateTime.ParseExact("11/06/1995", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            Customer customer3 = new Customer
            {
                Id = "Cus003",
                Name = "Miro",
                Gender = "Male",
                Birthday = DateTime.ParseExact("08/03/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };
            Customer customer4 = new Customer
            {
                Id = "Cus004",
                Name = "Mimi",
                Gender = "Female",
                Birthday = DateTime.ParseExact("08/03/1997", "dd/MM/yyyy", CultureInfo.InvariantCulture)
            };

            Customer[] customers = 
            {
                customer1,customer2,customer3,customer4,customer5  
            };
            return customers;
        }

        public static Customer Find(string id)
        {
            Customer result = new Customer();
            foreach(Customer customer in CustomerModel.FindAll())
            {
                if (customer.Id.ToLower() == id.ToLower())
                {
                     result = customer;
                }
            }
            return result;
        }

        public  static Customer FindByGenderAndDate(string gender)
        {
            Customer result = new Customer();
            foreach (Customer customer in CustomerModel.FindAll())
            {
                if (customer.Gender.ToLower() == gender.ToLower())
                {
                    result = customer;
                }
            }
            return result;
        }
    }
}
