using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession6.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace DemoSession6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            Demo5();
            Console.ReadLine();
        }

        static void Demo1()
        {
            IHuman human1 = new Human { Name = "Human 1"};
            human1.Eat();
            human1.Sleep();
            human1.A();

            IHuman2 human2 = new Human { Name = "Human 2" };
            Console.WriteLine(human2.Run());
            human2.A();

            IB ib = new Human();
            ib.b2();
            ib.c2();

            ID id = new Human();
            id.d1();
            id.d2();
        }

        static void Demo2()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today: " + today);
            Console.WriteLine("ShortDateString: " + today.ToShortDateString());
            Console.WriteLine("LongDateString: " + today.ToLongDateString());
            Console.WriteLine("ShortTimeString: " + today.ToShortTimeString());
            Console.WriteLine("LongDateString: " + today.ToLongTimeString());
            Console.WriteLine("Today: " + today.ToString("dd/MM/yyyy HH:mm:ss"));
            int year = today.Year;
            Console.WriteLine("year: " + year);
            Console.WriteLine("month: " + today.Month);
            Console.WriteLine("day: " + today.Day);

            DateTime birthday1 = Convert.ToDateTime("11/13/1992");
            Console.WriteLine("birthday1: " + birthday1.ToString("yyyy-dd-MM"));

            DateTime birthday2 = DateTime.ParseExact("20/10/2021","dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine("birthday2: " + birthday2.ToString("yyyy-dd-MM"));
        }

        static void Demo3()
        {
            /* Nhập ngay sinh, kiem tra xem co phai sinh nhat k?
             * Tinh tuoi */
            DateTime today = DateTime.Now;
            Console.WriteLine("Enter a string for a date: ");
            string string1 = Console.ReadLine();
            DateTime date = DateTime.ParseExact(string1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if ((date.Day == today.Day) && (date.Month == today.Month))
            {
                Console.WriteLine("The String is that birthday");
            } else
            {
                Console.WriteLine("The String is not that birthday");
            }

            int age = today.Year - date.Year;
            Console.WriteLine("Age: " + age);
        }

        static void Demo4()
        {
            List<string> names = new List<string>();
            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 4");

            //names.RemoveAt(2);
            //names.Clear();

            var names2 = new List<string>
            {
                "Name 5", "Name 6", "Name 7"
            };

            names.AddRange(names2);


            Console.WriteLine("Size: " + names.Count);
            Console.WriteLine(names[1]);
            Console.WriteLine("List 1: ");
            for(var i =0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("list 2: ");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("list 3: ");
            names.ForEach(name => {  //Hàm ẩn danh (callback)
                Console.WriteLine(name);
            });
        }

        static void Demo5()
        {
            var a = new List<int>
            {
                10,5,-3,28,9,26,-6
            };
            a.ForEach(number =>
            {
                Console.WriteLine(number);
            });
        }
    }
}
