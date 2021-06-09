using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoSession11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo7();
            Homework();
            Console.ReadLine();
        }

        static void Demo1()
        {
            var numbers =new  List<int>{
                4,10,-2,-7,-11,9,-15
            };
            var myForEach = new MyForEach();
            myForEach.PositiveNumberEvent += MyForEach_PositiveNumberEvent;
            myForEach.NegativeNumberEvent += MyForEach_NegativeNumberEvent;
            myForEach.Run(numbers);
        }

        private static void MyForEach_NegativeNumberEvent(int value, int index)
        {
            Debug.WriteLine("value: " + value + " index: " + index);
        }

        private static void MyForEach_PositiveNumberEvent(int value, int index)
        {
            Debug.WriteLine("value: " + value + " index: " + index);
        }

        static void Demo2()
        {
            /*Khai bao class MyFile
             * Xác đinh khi gặp 1 file trong folder sẽ đọc thông tin gồm có tên file, đuôi của file và kích thước file
             * Khi gặp folder trong folder xác định hiển thị tện folder */

            var myFiles = new MyFile();
            myFiles.ReadFile += MyFiles_ReadFile;
            myFiles.ReadFolder += MyFiles_ReadFolder;
            myFiles.Run(@"D:\Data");
        }

        private static void MyFiles_ReadFolder(DirectoryInfo directoryInfo)
        {
            Debug.WriteLine("Name: " + directoryInfo.Name);
            Debug.WriteLine("==================================");
        }

        private static void MyFiles_ReadFile(FileInfo fileInfo)
        {
            Debug.WriteLine("File Info: ");
            Debug.WriteLine("File Name: " + fileInfo.Name);
            Debug.WriteLine("File Extension: " + fileInfo.Extension);
            Debug.WriteLine("File Size " + fileInfo.Length);
            Debug.WriteLine("Full Name: " + fileInfo.FullName);
            Debug.WriteLine("==================================");
        }

        static void Demo3() //Xử lý bất đồng bộ
        {
            Task.Run(() =>
            {
                Debug.WriteLine("Action 1");
            });

            Task.Run(() =>
            {
                Debug.WriteLine("Action 2");
            });

            Task.Run(() => Demo3_Action3());
            Debug.WriteLine("Done!");
        }

        static void Demo3_Action3()
        {
            Debug.WriteLine("Action 3");
        }

        static void Demo4()
        {
            int a = 10, b = 5;
            Task.Run(() => Demo4_AddAsync(a, b));
            Task.Run(() => Demo4_MinusAsync(a, b));
            Task.Run(() => Demo4_MultipleAsync(a, b));
            Task.Run(() => Demo4_DivideAsync(a, b));
        }

        static void Demo4_AddAsync(int a, int b)
        {
            Task.Run(() =>
            {
                Debug.WriteLine("Plus: " + a + b);
            });
        }

        static void Demo4_MinusAsync(int a, int b)
        {
            Task.Run(() =>
            {
                Debug.WriteLine("Minus: " + (a - b));
            });
        }

        static void Demo4_MultipleAsync(int a, int b)
        {
            Task.Run(() =>
            {
                Debug.WriteLine("Multiple: " + a * b);
            });
        }

        static void Demo4_DivideAsync(int a, int b)
        {
            Task.Run(() =>
            {
                Debug.WriteLine("Divide: " + (a / b));
            });
        }

        static void Demo5()
        {
            var numbers = new List<int>{
                4,10,-2,-7,-11,9,-15
            };

            /*Sử dụng task:
             * tổng các số âm
             * tông các số dương
             * Đếm có bao nhiêu số âm
             * Đếm có bao nhiêu số dương */
            Task.Run(() => Demo5_CountPositive(numbers));
            Task.Run(() => Demo5_CountNegative(numbers));
            Task.Run(() => Demo5_TotalPositive(numbers));
            Task.Run(() => Demo5_TotalNegative(numbers));
        }

        static void Demo5_TotalPositive(List<int> list)
        {
            var result = list.Where(i => i >= 0).Sum();
            Debug.WriteLine("Total Positive: " + result);
        }

        static void Demo5_TotalNegative(List<int> list)
        {
            var  result = list.Where(i => i < 0).Sum();
            Debug.WriteLine("Total Negative: " + result);
        }

        static void Demo5_CountPositive(List<int> list)
        {
            var result = list.Where(i => i >= 0).Count();
            Debug.WriteLine("Count Positive: " + result);
        }

        static void Demo5_CountNegative(List<int> list)
        {
            var result = list.Where(i => i < 0).Count();
            Debug.WriteLine("Count Negative: " + result);
        }

        static void Demo6()
        {
            Task<string> task1 = Task.Run(() =>
            {
                return "Hello World";
            });
            Console.WriteLine(task1.Result);

            Task<int> task2 = Task.Run(() =>
            {
                return 123;
            });
            Console.WriteLine(task2.Result);

        }

        static void Demo7()
        {
            Task.Run(() =>
            {
                return "Hello 1";
            }).ContinueWith((result) =>
            {
                Console.WriteLine(result.Result);
            });

            Task.Run(() =>
            {
                return "Hello 2";
            }).ContinueWith((result) =>
            {
                Console.WriteLine(result.Result);
            });

            Task.Run(() =>
            {
                return "Hello 3";
            }).ContinueWith((result) =>
            {
                Console.WriteLine(result.Result);
            });
        }

        static void Homework()
        {
            /*Làm máy tính đơn giản +- * VÀ / SỬ DỤNG EVENT*/
            int a = 6, b = 8;
            Console.WriteLine("Input operator: ");
            string Ope = Console.ReadLine();

            CALCULATOR calculator = new CALCULATOR();
            calculator.Add += Calculator_Add;
            calculator.Minus += Calculator_Minus;
            calculator.Multiple += Calculator_Multiple;
            calculator.Divide += Calculator_Divide;
            calculator.Run(a, b, Ope);
        }

        private static void Calculator_Divide(int a, int b, string Operator)
        {
            Console.WriteLine("Divde: " + (a / b));
        }

        private static void Calculator_Multiple(int a, int b, string Operator)
        {
            Console.WriteLine("Multiple: " + (a * b));
        }

        private static void Calculator_Minus(int a, int b, string Operator)
        {
            Console.WriteLine("Minus: " + (a - b));
        }

        private static void Calculator_Add(int a, int b, string Operator)
        {
            Console.WriteLine("Add: " + (a + b));
        }
    }
}
