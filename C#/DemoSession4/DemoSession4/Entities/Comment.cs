using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession4.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return "Title: " + Title + "\nContent: " + Content;
        }
    }
}
