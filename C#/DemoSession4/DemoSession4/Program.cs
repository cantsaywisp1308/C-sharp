using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession4.Entities;
using DemoSession4.Model;

namespace DemoSession4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            Demo3();
            Console.ReadLine();
        }

        static void Demo1()
        {
            Product[] products =
            {
                new Product
                {
                    Id = "p01",
                    Name = "product 01",
                    Price = 6.7,
                    Quantity = 12
                },
                new Product
                {
                    Id = "p02",
                    Name = "product 02",
                    Price = 12.1,
                    Quantity = 33
                },
                new Product
                {
                    Id = "p03",
                    Name = "product 03",
                    Price = 9.1,
                    Quantity = 21
                }
            };
            Console.WriteLine("List 1: ");
            for (var i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ID: " + products[i].Id);
                Console.WriteLine("Name: " + products[i].Name);
                Console.WriteLine("Price: " + products[i].Price);
                Console.WriteLine("Quantity: " + products[i].Quantity);
                Console.WriteLine("Category: " + products[i].Category);
                Console.WriteLine("===========================");
            }

            Console.WriteLine("List 2: ");
            for (var i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ToString());
                Console.WriteLine("Total: " + products[i].Total());
                Console.WriteLine("===========================");
            }

            Console.WriteLine("List 3: ");
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("Total: " + product.Total());
                Console.WriteLine("===========================");
            }
        }

        static void Demo2()
        {
            var productModel = new ProductModel();
            productModel.Print(productModel.Input());
        }

        static void Demo3()
        {
            /* Xay dung menu thuc hiện các yêu cầu:
             * 1. Nhập 1 từ khóa. Liệt kê các sản phầm có từ khóa đó;
             * 2. Nhập vào 2 số min max, Đếm và trả về kết quả các sản phẩm có giá từ min đến max
             * 3. Liệt kê sản phẩm có tổn tiền lớn nhất nhỏ nhất
             * 4. Sắp xếp các sản phẩm theo giá giảm dần
             * 5. Nhập vào 1 mã sản phẩm, kiểm tra xem sản phẩm có tồn tại trong danh sách sản phẩm  hay không
             */
            Console.WriteLine("Input the key: ");
            var key = Console.ReadLine();
            var productModel = new ProductModel();
            foreach (Product product in productModel.Input())
            {
                if (product.Id.Contains(key.ToLower()) || product.Name.Contains(key.ToLower()))
                {
                    productModel.Print(product);
                }
            }

            Console.WriteLine("Input min: ");
            var min = double.Parse(Console.ReadLine());
            Console.WriteLine("Input max: ");
            var max = double.Parse(Console.ReadLine());
            productModel.FindByMinMax(min, max, productModel.Input());

            Console.WriteLine("Product which has minimum total: ");
            Product minTotal = productModel.FindMinTotal(productModel.Input());
            productModel.Print(minTotal);

            Console.WriteLine("Product which has maximum total: ");
            Product maxTotal = productModel.FindMaxTotal(productModel.Input());
            productModel.Print(maxTotal);

            productModel.Print(productModel.Sort(productModel.Input()));
        }
    }
}
