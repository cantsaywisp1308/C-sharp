using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using Test3_Entity_Framework.Entity;

namespace Test3_Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo3();
            Console.ReadLine();
        }



        static void Demo4()
        {
            Console.WriteLine("input key: ");
            string key = Console.ReadLine();
            var students = importCSV(@"D:\Data\students.csv");
            StudentLib studentLib = new StudentLib();
            studentLib.ID += StudentLib_ID;
            studentLib.Name += StudentLib_Name;
            studentLib.Run(students, key);
        }

        private static void StudentLib_Name(SinhVien sinhVien, string key)
        {



            Console.WriteLine(sinhVien.ID);
            Console.WriteLine(sinhVien.Name);
            Console.WriteLine(sinhVien.Birthday);
            Console.WriteLine(sinhVien.Score);
            Console.WriteLine("=========================");


        }

        private static void StudentLib_ID(SinhVien sinhVien, string key)
        {


            Console.WriteLine(sinhVien.ID);
            Console.WriteLine(sinhVien.Name);
            Console.WriteLine(sinhVien.Birthday);
            Console.WriteLine(sinhVien.Score);
            Console.WriteLine("=========================");


        }
        static void Demo3()
        {
            var db = new DataContext();
            var students = db.SinhViens.Where(s => 2021 - s.Birthday.Value.Year < 20).ToList();

            students.ForEach(s =>
               {
                db.SinhViens.Remove(s);
                db.SaveChanges();
                
                
                //File.AppendAllText(@"D:\Data\cau3.txt", s.ID + "\n" + s.Name + "\n" + s.Birthday + "\n" + s.Score + "\n" + "=====================" + "\n");
            });
        }

        static void Demo2()
        {
            Console.WriteLine("Input min: ");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Input max: ");
            double max = double.Parse(Console.ReadLine());
            var students = importCSV(@"D:\Data\students.csv");
            students.Where(s => s.Score >= min && s.Score <= max).ToList().ForEach(s =>
            {
                File.AppendAllText(@"D:\Data\student2.txt", s.ID + "\n" + s.Name + "\n" + s.Birthday + "\n" + s.Score + "\n" + "=====================" + "\n");
            });
        }

        static void Demo1()
        {
            var students = importCSV(@"D:\Data\students.csv");
            students.ForEach(s =>
            {
                Console.WriteLine(s.ID);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Birthday);
                Console.WriteLine(s.Score);
                Console.WriteLine("--------------------");
            });
        }

        static List<SinhVien> importCSV(string fileName)
        {
            try
            {
                var students = new List<SinhVien>();
                using (var streamReader = new StreamReader(fileName))
                {
                    var line = "";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        var result = line.Trim().Split(new char[] { ',' });
                        students.Add(new SinhVien
                        {
                            ID = result[0].Trim(),
                            Name = result[1].Trim(),
                            Birthday = DateTime.ParseExact(result[2].Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                            Score = double.Parse(result[3].Trim())
                        });
                    }
                }
                return students;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }

   
}
