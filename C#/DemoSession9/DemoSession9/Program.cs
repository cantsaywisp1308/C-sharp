using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession9.Entities;
using System.IO;

namespace DemoSession9
{
    class Program
    {
        static void Main(string[] args) //partial và File
        {
            Demo9();
            Console.ReadLine();
        }

        static void Demo11()
        {
            using (var streamWriter = new StreamWriter(@"D:\Data\ef.txt"))
            {
                streamWriter.WriteLine("ABC");
                streamWriter.WriteLine("XYZ");
                streamWriter.Write("WWWW");

            }
        }

        static void Demo10()
        {
            //File.WriteAllText(@"D:\Data\e.txt","ABC");
            File.AppendAllText(@"D:\Data\e.txt", "WWWWWWWWW");
        }

        static void Demo9()
        {
            var products = ImportCSV(@"D:\Data\products.csv");
            Console.WriteLine("Products: " + products.Count);
            products.ForEach(p =>
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("==========================");
            });
        }

        static List<Product> ImportCSV(string fileName)
        {
            try
            {
                var products = new List<Product>();
                using (var streamReader = new StreamReader(fileName))
                {
                    var line = "";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var result = line.Trim().Split(new char[] { ',' });
                        products.Add(new Product
                        {
                            Id = result[0].Trim(),
                            Name = result[1].Trim(),
                            Price = double.Parse(result[2].Trim()),
                            Quantity = int.Parse(result[3].Trim())
                        }) ;
                    }
                    return products;
                }


            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        static void Demo8()
        {
            using (var streamReader = new StreamReader(@"D:\Data\d.txt"))
            {
                var line = "";
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
               
        }

        static void Demo7()
        {
            var streamReader = new StreamReader(@"D:\Data\d.txt");
            var line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            streamReader.Close();
            
            
        }
        static void Demo6()
        {
            string[] lines = File.ReadAllLines(@"D:\Data\d.txt");
            Console.WriteLine("Lines: " + lines.Length);
            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        static void Demo5()
        {
            var content = File.ReadAllText(@"D:\Data\a.txt");
            Console.WriteLine(content);
        }

        static void Demo4()
        {
            var directoryInfo = new DirectoryInfo(@"D:\Data");
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            if (fileInfos.Length > 0)
            {
                Console.WriteLine("Files: " + fileInfos.Length);
                foreach(var fileInfo in fileInfos)
                {
                    Console.WriteLine("File Name: " + fileInfo.Name);
                    Console.WriteLine("File Extension: " + fileInfo.Extension);
                    Console.WriteLine("File Length: " + fileInfo.Length);
                    Console.WriteLine("==================================");
                }
            }

            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            if(directoryInfos.Length > 0)
            {
                Console.WriteLine("Directories: " + directoryInfos.Length);
                foreach(var directoryInf in directoryInfos)
                {
                    Console.WriteLine("Name: " + directoryInf.Name);
                    Console.WriteLine("==================================");
                }
            }
        }

        static void Demo3()
        {
            var directoryInfo = new DirectoryInfo(@"D:\Data\Folder 1");
            Console.WriteLine("File ");
        }

        static void Demo2()
        {
            var fileInfo = new FileInfo(@"D:\Data\a.txt");
            Console.WriteLine("File Name: " + fileInfo.Name);
            Console.WriteLine("File Extension: " + fileInfo.Extension);
            //Console.WriteLine("File Size " + fileInfo.Length);
            Console.WriteLine("Full Name: " + fileInfo.FullName);
        }

        static void Demo1()
        {
            //partial 
            // Student a.cs b.cs
            //a.cs -->Hạn chế edit
            //b.cs --> thêm code
            //database --> EF(Product, Category,... kiểm tra diều kiện)
            var student = new Student
            {
                Id = "st01",
                Name = "Student 1",
                Score = 8.5
            };
            Console.WriteLine("Student Id: " + student.Id);
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Score: " + student.Score);
            student.Work1();
        }
    }
}
