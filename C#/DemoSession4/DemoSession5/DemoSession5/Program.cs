using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession5.Entities;

namespace DemoSession5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo1();
            //Demo2();
            //Demo3();
            //Demo4();
            //Demo5();
            Demo6();
            Console.ReadLine();
        }

        static void Demo1()
        {
            var student = new Student { Name = "Student 1", Gender = "Male", Id="st01", Score=6.5 };
            Console.WriteLine("Student Info: ");
            Console.WriteLine("Name: "+student.Name);
            Console.WriteLine("Gender: " + student.Gender);
            Console.WriteLine("ID: " + student.Id);
            Console.WriteLine("Score: " + student.Score);

        }

        static void Demo2()
        {
            var employee = new Employee { Name = "Employee 1", Gender = "Female", Id="emp01", Salary=1000 };
            Console.WriteLine("Employee Info: ");
            Console.WriteLine("Employee Name: " + employee.Name);
            Console.WriteLine("Employee Gender: " + employee.Gender);
            Console.WriteLine("Employee ID: " + employee.Id);
            Console.WriteLine("Employee Salary: " + employee.Salary);
        }

        static void Demo3()
        {
            var student2 = new Student("Student 2", "Female", "st02", 7.5);
            Console.WriteLine("Student 2 Info: ");
            //Console.WriteLine("Student 2 Name: " + student2.Name);
            //Console.WriteLine("Student 2 Gender: " + student2.Gender);
            //Console.WriteLine("Student 2 ID: " + student2.Id);
            //Console.WriteLine("Student 2 Score: " + student2.Score);
            student2.Print();
            Console.WriteLine("======================================");

            var employee2 = new Employee("Employee 2", "Male", "emp02", 1250);
            Console.WriteLine("Employee 2 Info: ");
            //Console.WriteLine("Employee 2 Name: " + employee2.Name);
            //Console.WriteLine("Employee 2 Gender: " + employee2.Gender);
            //Console.WriteLine("Employee 2 ID: " + employee2.Id);
            //Console.WriteLine("Employee 2 Salary: " + employee2.Salary);
            employee2.Print();
        }

        static void Demo4()
        {
            Human human1 = new Human();
            human1.Input();
            Human human2 = new Student();
            human2.Input();
            Human human3 = new Employee();
            human3.Input();
        }

        static void Demo5()
        {
            Animal[] animals =
            {
                new Cat {Name = "Cat 1"},
                new Duck{Name = "Duck 1"},
                new Chicken{Name = "Duck 1"},
                new Cat{Name = "Cat 2"},
                new Duck{Name = "Duck 2"},
                new Chicken{Name = "Chicken 2"}
            };
            foreach(Animal animal in animals)
            {
                animal.Sound();
            }
        }

        static void Demo6()
        {
            HinhHoc[] hinhHocs =
            {
                new HinhTron{Name = "Hinh tron 1", BanKinh = 1},
                new HinhVuong{Name = "Hinh Vuong 1", Canh = 2},
                new HinhChuNhat{Name = " Hinh Chu Nhat 1", ChieuDai=3, ChieuRong = 4},
                new HinhTron{Name = "Hình tròn 2", BanKinh=1.5},
                new HinhVuong{Name = "Hình Vuông 2", Canh=3.2},
                new HinhChuNhat{Name = "Hình chũ nhật 2", ChieuDai=3.1, ChieuRong = 5.6}
            };
            foreach(HinhHoc hinhHoc in hinhHocs)
            {
                Console.WriteLine(hinhHoc.Name);
                Console.WriteLine("Diện tích: " + hinhHoc.DienTich());
                Console.WriteLine("Chu vi: " + hinhHoc.ChuVi());
                Console.WriteLine("============================");
            }
        }
    }
}
