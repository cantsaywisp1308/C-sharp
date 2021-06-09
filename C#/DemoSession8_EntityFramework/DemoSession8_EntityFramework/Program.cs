using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession8_EntityFramework.Model;
using System.Globalization;

namespace DemoSession8_EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo18();
            Console.ReadLine();
        }

        static void Demo26()
        {
            var db = new DatabaseContext2();
            var account = db.Accounts.Find(4);
            account.Username = "broodMother";
            account.Roles.Clear();
            account.Roles = new List<Role>
            {
                db.Roles.Find(1),
                db.Roles.Find(4),
            };

            db.Entry(account).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        static void Demo25()
        {
            var db = new DatabaseContext2();
            var account = db.Accounts.Find(7);
            account.Roles.Clear();
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        static void Demo24()
        {
            var db = new DatabaseContext2();
            var account = new Account
            {
                Username = "bristleback",
                Password = "1234",
                Fullname = "Bristleback",
                Birthday = DateTime.Now,
                Email = "bristleback@gmail.com",
                Roles = new List<Role>
                {
                    db.Roles.Find(2),
                    db.Roles.Find(4)
                }
            };
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        static void Demo23()
        {
            var db = new DatabaseContext2();
            var category = db.Categories.Find(2);
            category.Name = "Television";
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        static void Demo22()
        {
            var db = new DatabaseContext2();
            var product =  db.Products.Find(14);
            db.Products.Remove(product);
            db.SaveChanges();
        }

        static void Demo21()
        {
            var product = new Product
            {
                Name = "Camera 3",
                Price = 125.8M,
                Quantity = 18,
                Status = false,
                Created = DateTime.ParseExact("14/08/2021","dd/MM/yyyy",CultureInfo.InvariantCulture),
                Description = "Quite bad",
                CategoryId = 6
            };
            var db = new DatabaseContext2();
            db.Products.Add(product);
            var rows = db.SaveChanges();
            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("ID: " + product.Id);
        }

        static void Demo20()
        {
            var category = new Category
            {
                Name = "Camera"
            };
            var db = new DatabaseContext2();
            db.Categories.Add(category);
            var rows = db.SaveChanges();
            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("ID: " + category.Id);
        }

        static void Demo19()
        {
            var db = new DatabaseContext2();
            var result = db.Products.GroupBy(p => p.CategoryId).Select(g => new
            {
                CategoryId = g.Key,
                CountProduct = g.Count(),
                SumQuantity = g.Sum(p=>p.Quantity),
                AveragePrice = g.Average(p=>p.Price),
                MinPrice = g.Min(p=>p.Price),
                MaxPrice = g.Max(p=> p.Price)
            }).Where(g=>g.SumQuantity>10).ToList();
            foreach(var r in result)
            {
                Console.WriteLine("Category ID: " + r.CategoryId);
                Console.WriteLine("Number of Products : " + r.CountProduct);
                Console.WriteLine("Sum Quantity: " + r.SumQuantity);
                Console.WriteLine("Average price: " + r.AveragePrice);
                Console.WriteLine("Min Price: " + r.MinPrice);
                Console.WriteLine("Max Price: " + r.MaxPrice);
                Console.WriteLine("==============================");
            }
        }

        static void Demo18() // join các tables trong database
        {
            var db = new DatabaseContext2();
            var results = db.Categories.Join(
                db.Products,
                c => c.Id, // khóa chính
                p => p.CategoryId, // khóa ngoại
                (c,p) => new //tạo đối tượng ẩn danh
                {
                    productId = p.Id,
                    productName = p.Name,
                    Price = p.Price,
                    CategoryId = c.Id,
                    CategoryName = c.Name
                }
                ).ToList();
            foreach(var result in results)
            {
                Console.WriteLine("Product ID: " + result.productId);
                Console.WriteLine("Product Name: " + result.productName);
                Console.WriteLine("Product Price: " + result.Price);
                Console.WriteLine("Category ID: " + result.CategoryId);
                Console.WriteLine("Category Name: " + result.CategoryName);
                Console.WriteLine("==============================");
            }
        }

        static void Demo17() //set distinct trong mysql --> loại bỏ những dữ liệu trùng
        {
            var db = new DatabaseContext2();
            var categoryIds = db.Products.Select(p => p.CategoryId).Distinct().ToList();
            foreach(var categoryId in categoryIds)
            {
                Console.WriteLine(categoryId);
            }
        }

        static void Demo6()
        {
            /*Dùng lambda 
             * Liet ke sp san xuat trong 1 thang cua name
             * liet ke hoa don dc lap cho tai khoan acc1
             * Liet ke hoa don theo payment
             * liet ke san pham co danh muc category 1 2 3 
             * Liet ke cac hoa don la nu sinh 8/3
             6. Liet ke thong tin cac san pham thuoc 1 hoa don
             7. Liet ke cac hoa don da mua 1 san pham
             8. Liet ke cac khach hang co ho ten chua 1 tu khoa*/

            var db = new DatabaseContext2();
            Console.WriteLine("Câu 1: ");
            db.Products.Where(p => p.Created.Month == 12).ToList().ForEach(p =>
              {
                  Console.WriteLine("ID: " + p.Id);
                  Console.WriteLine("Name: " + p.Name);
                  Console.WriteLine("Price: " + p.Price);
                  Console.WriteLine("Quantity: " + p.Quantity);
                  Console.WriteLine("Category " + p.Category.Id);
                  Console.WriteLine("Category name: " + p.Category.Name);
                  Console.WriteLine("================================");
              });

            Console.WriteLine("Câu 2: ");
            db.Invoices.Where(i => i.Account.Id == 1).ToList().ForEach(i =>
              {
                  Console.WriteLine("ID: " + i.Id);
                  Console.WriteLine("Name: " + i.Name);
                  Console.WriteLine("Payment: "+i.Payment);
                  Console.WriteLine("Status: " + i.Status);
                  Console.WriteLine("================================");
              });
            Console.WriteLine("Câu 3: ");
            db.Invoices.Where(i => i.Payment == "Cash").ToList().ForEach(i =>
            {
                Console.WriteLine("ID: " + i.Id);
                Console.WriteLine("Name: " + i.Name);
                Console.WriteLine("Customer ID: " + i.Account.Id);
                Console.WriteLine("Payment: " + i.Payment);
                Console.WriteLine("Customer Name: " + i.Account.Fullname);
                Console.WriteLine("================================");
            });

            Console.WriteLine("Câu 4: ");
            db.Products.GroupBy(p => p.Category.Id).Select(g => new
            {
                g.Key,
                TotalQuantity = g.Sum(p => p.Quantity)
            }).ToList().ForEach(g=> {
                Console.WriteLine("Category: " +g.Key);
                Console.WriteLine("Total quanity: " +g.TotalQuantity);
            });

            Console.WriteLine("Câu 6: ");

        }

        static void Demo16()
        {
            var db = new DatabaseContext2();
            db.Accounts.ToList().ForEach(a =>
            {
                Console.WriteLine("ID: " + a.Id);
                Console.WriteLine("Name: " + a.Fullname);
                Console.WriteLine("Roles: " + a.Roles.Count);
                foreach(var role in a.Roles)
                {
                    Console.WriteLine("Role ID: " + role.Id);
                    Console.WriteLine("Role Name: " + role.Name);
                }
            });
        }

        static void Demo15()
        {
            var db = new DatabaseContext2();
            db.Roles.ToList().ForEach(r =>
            {
                
                Console.WriteLine("Role ID: " + r.Id);
                Console.WriteLine("Role name: " + r.Name);
                Console.WriteLine("Account number: " + r.Accounts.Count());
            });
        }
        static void Demo13()
        {
            var db = new DatabaseContext2();
            var min1 = db.Products.Min(p => p.Price);
            Console.WriteLine("Min 1: " + min1);

            var min2 = db.Products.Where(p => p.Status == false).Min(p => p.Price);
            Console.WriteLine("Min 2: " + min2);

            var ave1 = db.Products.Where(p => p.Status == false).Average(p => p.Price);
            Console.WriteLine("Min 2: " + ave1);

            var max1 = db.Products.Where(p => p.Status == false).Max(p => p.Price);
            Console.WriteLine("Min 2: " + max1);
        }

        static void Demo14()
        {
            /*
             Su dung bieu thuc Lambda thuc hien cac yeu cau sau:
                1. Tinh tong tien cua 1 hoa don
                2. Dem co bao nhieu hoa don duoc mua boi khach hang co ho ten Nguyen Van A
                3. Tinh tong tien cac hoa don duoc lap theo 1 hinh thuc thanh toan trong 1 thang cua 1 nam
                4. Tim gia san pham nho nhat trong cac danh muc co ten la Category 1 hoac Category 2
                5. Kiem tra 1 username da ton tai hay chua?
                6. Tinh tong tien cac hoa don duoc lap cho khach hang co ho ten Nguyen Van A
             **/

            Console.WriteLine("Câu 1: ");
            var db = new DatabaseContext2();
            var total1 = db.InvoiceDetails.Where(i => i.InvoiceId == 1).Sum(i => i.Price*i.Quantity);
            Console.WriteLine("Total 1: " + total1);

            Console.WriteLine("Câu 2: ");
            var count1 = db.Invoices.Where(i => i.Account.Fullname == "Alchemist").Count();
            Console.WriteLine("Count 1: " + count1);

            Console.WriteLine("Câu 3: ");
            var total2 = db.InvoiceDetails.Where(i => i.Invoice.Payment == "Cash" && i.Invoice.Created.Value.Month == 11).Sum(i => i.Price*i.Quantity);
            Console.WriteLine("Total 2: " + total2);

            Console.WriteLine("Câu 4: ");
            var min1 = db.Products.Where(p => p.Category.Name == "Laptop").Min(p => p.Price * p.Quantity);
            Console.WriteLine("Min 1: " + min1);

            Console.WriteLine("Câu 5: ");
            var username = "tinker";
            var result = db.Accounts.Count(a => a.Username == username);
            if (result > 0)
            {
                Console.WriteLine("Exist !");
            }
            else
            {
                Console.WriteLine("Username not exist !");
            }

            Console.WriteLine("Câu 6: ");
            var total3 = db.InvoiceDetails.Where(id => id.Invoice.Account.Fullname == "Alchemist").Sum(id => id.Price * id.Quantity);
            Console.WriteLine("Total 3: " + total3);
        }


        static void Demo12()
        {
            var db = new DatabaseContext2();
            var result1 = db.Products.Count();
            Console.WriteLine("Result 1: " + result1);

            var result2 = db.Products.Where(p => p.Status).Count();
            Console.WriteLine("Result 2: " + result2);

            var result3 = db.Products.Count(p => p.Status == true);
            Console.WriteLine("Result 3: " + result3);
        }

        static void Demo11()
        {
            var db = new DatabaseContext2();
            var result1 = db.Products.Sum(p => p.Quantity);
            Console.WriteLine("Result 1: " + result1);

            var result2 = db.Products.Where(p => p.Status == true).Sum(p => p.Quantity);
            Console.WriteLine("Result 2: " + result2);

            var result3 = db.Products.Where(p => p.Status == true).Sum(p => p.Price * p.Quantity);
            Console.WriteLine("Result 3: " + result3);


        }

        static void Demo10()
        {
            var db = new DatabaseContext2();
            db.Products.OrderByDescending(p=>p.Price).Take(2).ToList().ForEach(p =>
            {
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Price: " + p.Price);
                Console.WriteLine("Status: " + p.Status);
            });

            Console.WriteLine("List 2: ");
            db.Products.OrderByDescending(p=>p.Price).Skip(1).Take(2).ToList().ForEach(p =>
            {
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Price: " + p.Price);
                Console.WriteLine("Status: " + p.Status);
            });

            Console.WriteLine("List 3: ");
            db.Products.Where(p=>p.Status==true).OrderByDescending(p => p.Price).Skip(1).Take(2).ToList().ForEach(p =>
            {
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Price: " + p.Price);
                Console.WriteLine("Status: " + p.Status);
            });
        }

        static void Demo9()
        {
            var db = new DatabaseContext2();
            //db.Products.OrderBy(p => p.Price).ToList().ForEach(p =>
            //{
            //    Console.WriteLine("ID: " + p.Id);
            //    Console.WriteLine("Name: " + p.Name);
            //    Console.WriteLine("Price: " + p.Price);
            //});
            db.Products.Where(p=>p.Status==true).OrderByDescending(p => p.Price).ToList().ForEach(p =>
            {
                Console.WriteLine("ID: " + p.Id);
                Console.WriteLine("Name: " + p.Name);
                Console.WriteLine("Price: " + p.Price);
                Console.WriteLine("Status: " + p.Status);
            });
        }

        static void Demo8()
        {
            var db = new DatabaseContext2();
            var products = db.Products.Select(p => new
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            }).ToList();
            foreach(var product in products)
            {
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
            }
        }

        static void Demo7()
        {
            var db = new DatabaseContext2();
            var product1 = db.Products.SingleOrDefault(p => p.Id == 3);
            Console.WriteLine("ID: " + product1.Id);
            Console.WriteLine("name: " + product1.Name);
            Console.WriteLine("Price: " + product1.Price);
            Console.WriteLine("Quantity: " + product1.Quantity);
            Console.WriteLine("Category ID: " + product1.Category.Id);
            Console.WriteLine("Category Name: " + product1.Category.Name);


            
            var product2 = db.Products.FirstOrDefault(p => p.Id == 6);
            Console.WriteLine("ID: " + product2.Id);
            Console.WriteLine("name: " + product2.Name);
            Console.WriteLine("Price: " + product2.Price);
            Console.WriteLine("Quantity: " + product2.Quantity);
            Console.WriteLine("Category ID: " + product2.Category.Id);
            Console.WriteLine("Category Name: " + product2.Category.Name);

            //Tìm đối tượng dựa trên khóa chính
            var product3 = db.Products.Find(5);
            Console.WriteLine("ID: " + product3.Id);
            Console.WriteLine("name: " + product3.Name);
            Console.WriteLine("Price: " + product3.Price);
            Console.WriteLine("Quantity: " + product3.Quantity);
            Console.WriteLine("Category ID: " + product3.Category.Id);
            Console.WriteLine("Category Name: " + product3.Category.Name);
        }

        static void Demo5()
        {
            var db = new DatabaseContext2();
            db.Products.Where(p => p.Status == true).ToList().ForEach(p =>
              {
                  Console.WriteLine("ID: " + p.Id);
                  Console.WriteLine("Name: " + p.Name);
                  Console.WriteLine("Price: " + p.Price);
                  Console.WriteLine("Quantity: " + p.Quantity);
                  Console.WriteLine("Status: " + p.Status);
                  Console.WriteLine("Categoy ID: " + p.Category.Id);
                  Console.WriteLine("Category Name: " + p.Category.Name);
                  Console.WriteLine("================================");
              });
        }

        static void Demo4() //Quan hệ nhiều 1
        {
            var db = new DatabaseContext2();
            db.Invoices.ToList().ForEach(i =>
            {
                Console.WriteLine("ID: " + i.Id);
                Console.WriteLine("Name: " + i.Name);
                Console.WriteLine("Payment: " + i.Payment);
                Console.WriteLine("Customer ID: " + i.Account.Id);
                Console.WriteLine("Customer Name: " + i.Account.Fullname);
                Console.WriteLine("====================================");
            });
        }

        static void Demo3() //quan hệ 1 nhiều
        {
            var db = new DatabaseContext2();
            db.Accounts.ToList().ForEach(a =>
            {
                Console.WriteLine("ID: " + a.Id);
                Console.WriteLine("Username: " + a.Username);
                Console.WriteLine("Invoices: " + a.Invoices.Count);
                a.Invoices.ToList().ForEach(i =>
                {
                    Console.WriteLine("ID: " + i.Id);
                    Console.WriteLine("Name: " + i.Name);
                    Console.WriteLine("Payment: " + i.Payment);
                });
                Console.WriteLine("============================");
            });
        }
        static void Demo1()
        {
            var db = new DatabaseContext2();
            var categories = db.Categories.ToList();
            Console.WriteLine("Categories: " + categories.Count);
            foreach (var category in categories)
            {
                Console.WriteLine("Id: " + category.Id);
                Console.WriteLine("Name: " + category.Name);
                Console.WriteLine("Products: " + category.Products.Count);
                category.Products.ToList().ForEach(p =>
                {
                    Console.WriteLine("Id: " + p.Id);
                    Console.WriteLine("Name: " + p.Name);
                    Console.WriteLine("Price: " + p.Price);
                });
                Console.WriteLine("============================");
            }
        }

        static void Demo2()
        {
            var db = new DatabaseContext2();
            var products = db.Products.ToList();
            Console.WriteLine("Products: " + products.Count);
            foreach (var product in products)
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Created: " + product.Created);
                Console.WriteLine("Category Id: : " + product.Category.Id);
                Console.WriteLine("Category Name: " + product.Category.Name);
                Console.WriteLine("============================");
            }
        }
    }
}
