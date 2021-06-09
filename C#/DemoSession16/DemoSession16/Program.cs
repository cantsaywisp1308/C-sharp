using DemoSession16.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoSession16
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo4();
            Console.ReadLine();
        }

        static void Demo1()
        {
            Task<string> task1 = Task.Run(() =>
            {
                return "Content of File 1";
            });

            Task<string> task2 = Task.Run(() =>
            {
                return "Content of File 2";
            });

            Task<string> task3 = Task.Run(() =>
            {
                return "Content of File 3";
            });

            Task.WhenAll(task1, task2, task3).ContinueWith((re) =>
            {
                Console.WriteLine(string.Join(", ", re.Result));
            });
        }

        private static Task<string> ReadFileAsync(string fileName)
        {
            return Task.FromResult("Content of file: " + fileName);
        }

        private static Task<string> DownloadFileAsync(string fileName)
        {
            return Task.FromResult("Download of file: " + fileName);
        }
        static void Demo2()
        {
            Task<string> task1 = ReadFileAsync("a.txt");
            Task<string> task2 = ReadFileAsync("b.txt");
            Task.WhenAll(task1, task2).ContinueWith((re) =>
            {
                Debug.WriteLine(string.Join(", ", re.Result));
            });
        }

        static async void Demo3()
        {
            Task<string> task = DownloadFileAsync("a.gif");

            Debug.WriteLine("Render UI");

            string result = await task;
            Debug.WriteLine(result);
        }

        static void Demo4()
        {
            var student = new Student
            {
                Id = "st01",
                Name = "Name 1",
                Score = 6.7
            };

            var product = new Product
            {
                Id = "pr01",
                Name = "Product 01",
                Quantity = 15,
                Price = 5.5
            };

            Demo4_1(student);
            Demo4_1(product);
            Demo4_2(student);
            Demo4_2(product);
            Demo4_3(product);
            Demo4_3(student);
        }

        static void Demo4_1(object obj)
        {
            Type type = obj.GetType();
            Debug.WriteLine("Name: " + type.Name);
            Debug.WriteLine("Fullname: " + type.FullName);
        }

        static void Demo4_2(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            Debug.WriteLine("Name: " + type.Name);
            Debug.WriteLine("PropertyInfos: " + propertyInfos.Length);
            foreach(var propertyInfo in propertyInfos)
            {
                Debug.WriteLine("\tname: " + propertyInfo.Name);
                Debug.WriteLine("\ttype: " + propertyInfo.PropertyType.Name);
                Debug.WriteLine("\tValue: " + propertyInfo.GetValue(obj));
                Debug.WriteLine("\t-------------------------");
            }
        }

        static void Demo4_3(object obj)
        {
            Type type = obj.GetType();
            Debug.WriteLine("Name: " + type.Name);
            MethodInfo[] methodInfos = type.GetMethods();
            Debug.WriteLine("Method Info: " + methodInfos.Length);
            foreach(var methodInfo in methodInfos)
            {
                Debug.WriteLine("\tName: " + methodInfo.Name);
                Debug.WriteLine("\ttype: " + methodInfo.ReturnType.Name);
                ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                if(parameterInfos.Length > 0)
                {
                    foreach(var parameterInfo in parameterInfos)
                    {
                        Debug.WriteLine("\tParameter name: " + parameterInfo.Name);
                        Debug.WriteLine("\tParameter type: " + parameterInfo.ParameterType.Name);
                    }
                }
                Debug.WriteLine("-----------------------------");
            }
        }
    }
}
