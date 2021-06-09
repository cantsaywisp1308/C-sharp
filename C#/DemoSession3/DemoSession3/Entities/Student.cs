using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession3.Entities
{
    public class Student
    {
        private string id;
        private string name;
        private double score;

        public Student() { }
        public Student(string id)
        {
            this.id = id;
        }

        public Student(string id, string name, double score)
        {
            this.Id = id;
            this.Name = name; 
            this.Score = score; //kiem tra dieu kien o day
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Score
        {
            get
            { 
                return score;
            }
            set
            {
                score = value;
            }
        }

        public void Print()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Score: " + Score);
        }

        public override string ToString()
        {
            return "Id: " + Id + "\nName: " + Name + "\nScore: " + Score;
        }

    }
}
