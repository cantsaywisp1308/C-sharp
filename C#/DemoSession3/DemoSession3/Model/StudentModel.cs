using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSession3.Entities;

namespace DemoSession3.Model
{
    class StudentModel
    {
        public Student Save(Student student)
        {
            Console.WriteLine("Create new student: ");
            student.Id = student.Id;
            student.Name = student.Name;
            student.Score = student.Score;
            return student;
        }
    }
}
