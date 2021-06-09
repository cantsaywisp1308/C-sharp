using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession4.Entities;

namespace DemoSession4.Model
{
    class ProductModel
    {
        public Product[] Input()
        {
            Product[] products =
            {
                new Product
                {
                    Id = "p01",
                    Name = "product 01",
                    Price = 6.7,
                    Quantity = 12,
                    Category = new Category
                    {
                        Id = "C1",
                        Name = "Category 1"
                    },
                    Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id =5,
                            Title="Bad",
                            Content="The item is bad"
                        }
                    }
                },
                new Product
                {
                    Id = "p02",
                    Name = "product 02",
                    Price = 12.1,
                    Quantity = 33,
                    Category = new Category
                    {
                        Id="C2",
                        Name = "Category 2"
                    },
                    Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id = 3,
                            Title = "Expensive",
                            Content="Good but expensive"
                        },
                        new Comment
                        {
                            Id = 4,
                            Title="Good",
                            Content = "Good"
                        }
                    }
                },
                new Product
                {
                    Id = "p03",
                    Name = "product 03",
                    Price = 9.1,
                    Quantity = 21,
                    Category = new Category
                    {
                        Id = "C3",
                        Name = "Category 3"
                    },
                    Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id = 1,
                            Title="Evaluation",
                            Content = "It is so cheap"
                        },
                        new Comment
                        {
                            Id= 2,
                            Title = "So cheap",
                            Content = "Wow, so cheap"
                        }
                    }
                }
            };
            return products;
        }

        public void Print(Product[] products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("Total: " + product.Total());
                foreach(var comment in product.Comments)
                {
                    Console.WriteLine("\t" + comment.ToString());
                    Console.WriteLine("\t------------------------");
                }
                Console.WriteLine("===========================");
            }
        }

        public void Print(Product product)
        {
            Console.WriteLine(product.ToString());
            Console.WriteLine("Total: " + product.Total());
            Console.WriteLine("===========================");
        }

        public void FindByMinMax(double min, double max,Product[] products)
        {
            foreach(Product product in products)
            {
                if(product.Price>=min && product.Price <= max)
                {
                    Print(product);
                }
            }
        }

        public Product FindMinTotal(Product[] products)
        {
            var minTotal = products[0].Price * products[0].Quantity;
            var save = 0;
            for (var i =1; i<products.Length; i++)
            {
                
                if(minTotal > products[i].Price * products[i].Quantity)
                {
                    minTotal = products[i].Price * products[i].Quantity;
                    save = i;
                }
            }
            return products[save];
        }

        public Product FindMaxTotal(Product[] products)
        {
            var maxTotal = products[0].Price * products[0].Quantity;
            var save = 0;
            for (var i = 1; i < products.Length; i++)
            {

                if (maxTotal < products[i].Price * products[i].Quantity)
                {
                    maxTotal = products[i].Price * products[i].Quantity;
                    save = i;
                }
            }
            return products[save];
        }

        public Product[] Sort(Product[] products)
        {
            for (var i = 0; i < products.Length - 1; i++)
            {
                for (var j = i + 1; j < products.Length; j++)
                {
                    if (products[i].Price < products[j].Price)
                    {
                        var temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }
            return products;
        }
    }
}
