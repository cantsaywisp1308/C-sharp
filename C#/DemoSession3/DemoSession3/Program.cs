using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession3.Entities;
using DemoSession3.Model;

namespace DemoSession3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            Demo4();
            Console.ReadLine();
        }

        static void Demo1() {
            Student student1 = new Student();
            student1.Id = "st01";
            student1.Name = "student 01";
            student1.Score = 6.5;
            Console.WriteLine("student1 info");
            Console.WriteLine("Id: " + student1.Id);
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Score: " + student1.Score);
            var student2 = new Student {
                Id = "st02",
                Name = "Student 2",
                Score = 7.5
            };

            Console.WriteLine("student2 info");
            Console.WriteLine("Id: " + student2.Id);
            Console.WriteLine("Name: " + student2.Name);
            Console.WriteLine("Score: " + student2.Score);
        }

        static void Demo2()
        {
            var student = new Student();
            //Nhap thong tin sinh vien tu ban phim, in thong tin sinh vien va xep loai sinh vien
            Console.WriteLine("Input ID: ");
            student.Id = Console.ReadLine();
            Console.WriteLine("Input Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Input Score: ");
            student.Score = double.Parse(Console.ReadLine());
            Console.WriteLine("student2 info");
            Console.WriteLine("Id: " + student.Id);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Score: " + student.Score);
            Console.Write("Rank: ");
            if(student.Score < 5)
            {
                Console.WriteLine("Failed");
            } else if(student.Score>=5 && student.Score <6)
            {
                Console.WriteLine("Average");
            } else if(student.Score>=6 && student.Score <7)
            {
                Console.WriteLine("Fair");
            } else if(student.Score >= 7 && student.Score < 8)
            {
                Console.WriteLine("Good");
            } else if(student.Score>=8 && student.Score < 9)
            {
                Console.WriteLine("Excellent");
            } else
            {
                Console.WriteLine("BLAST!");
            }
        }

        static void Demo3()
        {
            var product = new Product();
            Console.WriteLine("Input ID: ");
            product.Id = Console.ReadLine();
            Console.WriteLine("Input Name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Input Price: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Quantity: ");
            product.Quantity = int.Parse(Console.ReadLine());

        }

        static void Demo4()
        {
            var student4 = new Student("st04", "Student 4", 5.5);
            //student4.Print();
            //Console.WriteLine(student4.ToString());

            var studentModel = new StudentModel();
            studentModel.Save(student4).Print();
        }

        static void Demo5()
        {
            var point1 = new Point();
            Console.WriteLine("Input point 1: ");
            Console.Write("x1: ");
            point1.X = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            point1.Y = int.Parse(Console.ReadLine());
            var point2 = new Point();
            Console.WriteLine("Input point 2: ");
            Console.Write("x2: ");
            point2.X = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            point2.Y = int.Parse(Console.ReadLine());
            var point3 = new Point();
            Console.WriteLine("Input point 3: ");
            Console.Write("x3: ");
            point3.X = int.Parse(Console.ReadLine());
            Console.Write("y3: ");
            point3.Y = int.Parse(Console.ReadLine());
        }
    }
}
