using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession7.Entities;
using System.Globalization;

namespace DemoSession7.Model
{
    public class ProductModel
    {
        public static List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = "ID01",
                    Name = "Camera 1",
                    Created = DateTime.ParseExact("20/10/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 5.6,
                    Quantity =12,
                    Status = true,
                    Category = "Category 1"
                },
                new Product
                {
                    Id = "ID02",
                    Name = "Laptop 2",
                    Created = DateTime.ParseExact("15/05/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 2.5,
                    Quantity =19,
                    Status = false,
                    Category = "Category 2"
                },
                new Product
                {
                    Id = "ID03",
                    Name = "Laptop 3",
                    Created = DateTime.ParseExact("21/03/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 3.3,
                    Quantity =23,
                    Status = true,
                    Category = "Category 2"
                },
                new Product
                {
                    Id = "ID04",
                    Name = "Desktop 3",
                    Created = DateTime.ParseExact("12/04/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 5.4,
                    Quantity =13,
                    Status = false,
                    Category = "Category 3"
                },
                new Product
                {
                    Id = "ID05",
                    Name = "Desktop 4",
                    Created = DateTime.ParseExact("11/04/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Price = 7.4,
                    Quantity =28,
                    Status = false,
                    Category = "Category 3"
                }
            };
        }
    }
}
