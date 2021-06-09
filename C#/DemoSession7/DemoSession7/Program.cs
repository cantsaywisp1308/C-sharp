using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;
using DemoSession7.Entities;
using DemoSession7.Model;
using System.Globalization;

namespace DemoSession7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo5();
            //Demo6();
            //Demo7();
            //Demo8();
            //Demo9();
            //Demo10();
            //Demo11();
            //Demo12();
            //Demo13();
            //Demo14();
            //Demo15();
            //Demo16();
            //Demo17();
            Homework();
            Console.ReadLine();
        }

        static void Homework()
        {
            /*Xay dung class Customer co cac thuoc tinh sau:
            1. id kieu chuoi
            2. name kieu chuoi
            3. gender kieu chuoi
            4. birthday kieu datetime
            Xay dung class Invoice co cac thuoc tinh sau:
            1. id kieu chuoi
            2. total kieu so thuc
            3. payment kieu chuoi
            4. status kieu chuoi
            5. customer kieu Customer
            6. created kieu datetime
            Khai bao List chua danh sach cac invoice va su dung Lambda thuc hien cac yeu cau sau:
            1) Liet ke cac hoa don duoc lap cho khach hang co ma la c01 trong ngay hom nay
            2) Tinh tong tien cac hoa don theo tung khach hang
            3) Tinh tong tien cac hoa don theo hinh thuc thanh toan va liet ke cac hinh thuc thanh toan nao co tong tien cac hoa don lon hon 500
            4) Liet ke cac hoa don duoc lap cho cac khach hang nu co ngay sinh la 8 thang 3
            5) Tim thong tin 1 hoa don va in thong tin hoa don vua tim duoc
            6) Liet ke 2 hoa don co tong tien lon nhat duoc mua boi khach hang co hoa ten nguyen van a mua trong nam 2021

            */
            Console.WriteLine("Câu 1: ");
            
            InvoiceModel.FindAll().Where(i => i.Created == DateTime.Today 
            && i.Customer.Id == "Cus001" ).ToList().ForEach(i=> {
                i.Print();
                Console.WriteLine("===============================");
            });

            Console.WriteLine("Câu 2: ");
            InvoiceModel.FindAll().GroupBy(i => i.Customer.Id).ToList().Select(g => new {
                g.Key,
                Total = g.Sum(i => i.Total),
            }).ToList().ForEach(g=> {
                Console.WriteLine("Customer: " + g.Key);
                Console.WriteLine("Total: " + g.Total);
            }) ;

            Console.WriteLine("Câu 3: ");
            InvoiceModel.FindAll().GroupBy(i => i.Payment).ToList().Select(g => new
            {
                g.Key,
                PaymentTotal = g.Sum(i => i.Total)
            }).Where(g=>g.PaymentTotal >=500).ToList().ForEach(g =>
            {
                Console.WriteLine("Payment: " + g.Key);
                Console.WriteLine("Total: " + g.PaymentTotal);
            });

            Console.WriteLine("Câu 4: ");
            InvoiceModel.FindAll().Where(i => i.Customer.Gender == "Female" && i.Customer.Birthday.Month == 3 && i.Customer.Birthday.Day ==8).ToList().ForEach(i => {
                i.Print();
                Console.WriteLine("======================================");
            });

            Console.WriteLine("Câu 6: ");
            InvoiceModel.FindAll().Where(i => i.Customer.Name == "Mimi" && i.Created.Year == 2021).ToList().ForEach(i =>
                {
                    i.Print();
                    Console.WriteLine("======================================");
                });
        }

        static void Demo3()
        {
            var a = new List<int>
        {
            -2,3,4,5,-6,7,8,-9
        };
            Console.WriteLine("ASC");
            a.OrderBy(i => i).ToList().ForEach(i =>
            {
                Console.WriteLine(i + " ");
            });
            Console.WriteLine("DES");
            a.OrderByDescending(i => i).ToList().ForEach(i =>
            {
                Console.WriteLine(i + " ");
            });

            a.Where(i => i > 0).OrderByDescending(i => i).ToList().ForEach(i =>
            {
                Console.WriteLine(i + " ");
            });

        }

        static void Demo4()
        {
            var a = new List<int>
        {
            -2,3,4,5,-6,7,8,-9
        };
            Console.WriteLine("ASC");
            a.OrderByDescending(i => i).Take(2).ToList().ForEach(i =>
              {
                  Console.WriteLine(i + " ");
              });

            a.OrderByDescending(i => i).Skip(2).Take(3).ToList().ForEach(i =>
            {
                Console.WriteLine(i + " ");
            });
        }

        static void Demo5()
        {
            var a = new List<int>
        {
            -2,3,4,5,-6,7,8,-9
        };
            var result1 = a.Sum();
            Console.WriteLine("result1: " + result1);
            var result2 = a.Where(i => i > 0).Sum();
            Console.WriteLine("result 2: " + result2);
        }

        static void Demo6()
        {
            var a = new List<int>
        {
            -2,3,4,5,-6,7,8,-9
        };
            var result1 = a.Count();
            Console.WriteLine("result 1: " + result1);
            var result2 = a.Count(i => i < 0);
            Console.WriteLine("result 2: " + result2);
            var result3 = a.Where(i => i > 0).Count();
            Console.WriteLine("result 3: " + result3);
        }

        static void Demo7()
        {
            var a = new List<int>
        {
            -2,3,4,5,-6,7,8,-9
        };
            var min1 = a.Min();
            Console.WriteLine("Min1: " + min1);
            var min2 = a.Where(i => i > 0).Min();
            Console.WriteLine("Min2: " + min2);
            var max1 = a.Max();
            Console.WriteLine("Max1: " + max1);
            var max2 = a.Where(i => i < 0).Max();
            Console.WriteLine("max2: " + max2);
            var average1 = a.Average();
            var average2 = a.Where(i => i > 0).Average();
            Console.WriteLine("average1: " + average1);
            Console.WriteLine("average2: " + average2);
        }

        static void Demo8()
        {
            ProductModel.FindAll().ForEach(p =>
            {
                p.Print();
                Console.WriteLine("==========================");
            });
        }

        static void Demo9()
        {
            ProductModel.FindAll().Where(p => (p.Price >= 5 && p.Price <= 10) && p.Status == true).ToList().ForEach(p =>
               {
                   p.Print();
                   Console.WriteLine("==========================");
               });
        }

        static void Demo10()
        {
            /* Sử dụng lambda thực hiện các yêu cầu sau:
             * Liet ke sp dc san xuat trong 1 ngay cua nam
             * Liet ke sp san xuat hom nay
             * Sap xep sp theo gia giam dan
             * Sap xep sp tang dan gia sp voi dieu kien tim kiem theo status va co so luong trong min den max
             * Liet ke n sp co gia lon nhat
             * Liet ke sp co chua tu khoa
             * Dem co bao nhieu sp co gia tu min den max
             * tinh tong tien tat ca sp
             * tinh tong tien sp theo status */
            Console.WriteLine("Câu 1: ");
            ProductModel.FindAll().Where(p => p.Created == DateTime.ParseExact("20/10/2021", "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList().ForEach(p =>
            {
                p.Print();
                Console.WriteLine("==============================");
            });
            Console.WriteLine("Câu 2: ");
            ProductModel.FindAll().Where(p => p.Created == DateTime.Today).ToList().ForEach(p =>
            {
                p.Print();
                Console.WriteLine("==============================");
            });
            Console.WriteLine("Câu 3: ");
            ProductModel.FindAll().OrderByDescending(p => p.Price).ToList().ForEach(p =>
            {
                p.Print();
                Console.WriteLine("==============================");
            });
            Console.WriteLine("Câu 4: ");
            ProductModel.FindAll().Where(p => p.Status == true && p.Quantity >= 10 && p.Quantity <= 20).ToList().ForEach(p =>
               {
                   p.Print();
                   Console.WriteLine("==============================");
               });
            Console.WriteLine("Câu 5: ");
            ProductModel.FindAll().OrderByDescending(p => p.Price).Take(2).ToList().ForEach(p =>
            {
                p.Print();
                Console.WriteLine("==============================");
            });
            Console.WriteLine("Câu 6: ");
            ProductModel.FindAll().Where(p => p.Name.Contains("Laptop")).ToList().ForEach(p =>
            {
                p.Print();
                Console.WriteLine("==============================");
            });
            Console.WriteLine("Câu 7:");
            var count1 = ProductModel.FindAll().Where(p => p.Price >= 3 && p.Price <= 5).Count();
            Console.WriteLine("Số lượng: " + count1);
            Console.WriteLine("==============================");
            Console.WriteLine("Câu 8: ");
            var sum1 = ProductModel.FindAll().Sum(p => p.Price * p.Quantity);
            Console.WriteLine("Total: " + sum1);
            Console.WriteLine("==============================");
            Console.WriteLine("Câu 9: ");
            var sum2 = ProductModel.FindAll().Where(p => p.Status == true).Sum(p => p.Price * p.Quantity);
            Console.WriteLine("Sum2: " + sum2);
        }

        static void Demo11()
        {
            var products = ProductModel.FindAll().Select(p => new
            {
                Masp = p.Id,
                Tensp = p.Name,
                Gia = p.Price
            }).ToList();
            foreach(var product in products ){
                Console.WriteLine("ID: " + product.Masp);
                Console.WriteLine("Name: " + product.Tensp);
                Console.WriteLine("Price: " + product.Gia);
            };
        }

        static void Demo12()
        {
            var product1 = ProductModel.FindAll().SingleOrDefault(p => p.Id == "ID05"); //Single nếu k tìm dc -> bung exception; singleOrdefault -> null
            if(product1 == null)
            {
                Console.WriteLine("Products not found! ");
            } else
            {
                Console.WriteLine("ID: " + product1.Id);
                Console.WriteLine("Name: " + product1.Name);
            }
            
        }

        static void Demo13()
        {
            var product1 = ProductModel.FindAll().Where(p => p.Id == "ID01").FirstOrDefault();  //First nếu k tìm dc -> bung exception; FirstIrDefault -> null
            if (product1 == null)
            {
                Console.WriteLine("Products not found! ");
            }
            else
            {
                Console.WriteLine("ID: " + product1.Id);
                Console.WriteLine("Name: " + product1.Name);
            }

        }

        static void Demo14()
        {
            var student = new
            {
                Id = "st01",
                Name = "Name 1",
                Score = 4.5
            };
            Console.WriteLine("ID: " + student.Id);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Score: " + student.Score);
        }

        static void Demo15()
        {
            dynamic username = "acc1";
            dynamic price = 4.5;
            dynamic quantity = 6;
            dynamic email;
            email = "abc@gmail.com";
            dynamic total = price * quantity;
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Email: " + email);
            Console.WriteLine(Hello("ABC"));
            dynamic student1 = new ExpandoObject();
            student1.Id = "st01";
            student1.Gender = "Male";
            student1.Score = 5.6;
            Console.WriteLine("ID: " + student1.Id);
            Console.WriteLine("Gender: " + student1.Gender);
            Console.WriteLine("Score: " + student1.Score);
            student1.Name = "Student 1";
            Console.WriteLine("Name: " + student1.Name);
        }

        static void Demo16()
        {
            Dictionary<string, object> student = new Dictionary<string, object>();
            student.Add("ID", "St01");
            student.Add("Name", "Student 01");
            student.Add("Score", 6.7);
            student.Remove("Score");
            Console.WriteLine("ID: " + student["ID"]);
            Console.WriteLine("Student Info: ");
            foreach(KeyValuePair<string, object>kv in student)
            {
                Console.WriteLine(kv.Key + ": " + kv.Value);
            }

            Dictionary<string, object> product = new Dictionary<string, object>
            {
                {"id","pr01" },
                {"name","Laptop 01" },
                {"price",500 },
                {"quantity", 67 }
            };

            foreach(KeyValuePair<string,object> kv in product)
            {
                Console.WriteLine(kv.Key + ": " + kv.Value);
            }
        }

        static void Demo17()
        {
            ProductModel.FindAll().GroupBy(p => p.Category).Select(g => new
            {   //khu vực quy định thông tin cần xuất ra
                g.Key,
                CountProduct = g.Count(),
                SumQuantity = g.Sum(p=>p.Quantity),
                AveragePrice = g.Average(p=>p.Price),
                MinPrice = g.Min(p=> p.Price),
                MaxPrice = g.Max(p => p.Price)
            }).Where(g=>g.SumQuantity>=20).ToList().ForEach(g =>    //g ở đây là từng nhóm sản phẩm
            {
                Console.WriteLine("Category: " + g.Key);
                Console.WriteLine("Count: " + g.CountProduct);
                Console.WriteLine("Sum: " + g.SumQuantity);
                Console.WriteLine("Max Price: " + g.SumQuantity);

            });
        }

        static dynamic Hello(dynamic name)
        {
            return "Hello" + name;
        }

        static void Demo2()
        {
            var a = new List<int> {
                5, 10, -3, 9, 20, -7, 6
            };
            a.Where(i => i >= 4 && i <= 15).ToList().ForEach(i =>
            {
                Console.Write(i + "   ");
            });
        }

        static void Demo1()
        {
            var a = new List<int> {
                5, 10, -3, 9, 20, -7, 6
            };
            var result = a.Where(i => i > 0).ToList();
            result.ForEach(i =>
            {
                Console.Write(i + "   ");
            });
        }

    }
}
