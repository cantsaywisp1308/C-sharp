using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo2
    {
        public delegate void Save(string content);
        public void SaveToWord(string content)
        {
            Debug.WriteLine(content + " Save to Word file");
        }

        public void SaveToText(string content)
        {
            Debug.WriteLine(content + " Save to Text file");
        }

        public void SaveToPDF(string content)
        {
            Debug.WriteLine(content + " Save to PDF file");
        }
        public void Run()
        {
            Save save = SaveToPDF;
            save("Hello 1");

            save = SaveToWord;
            save("Hello 2");

            save = SaveToText;
            save("Hello 3");

            save = (string content) =>
            {
                Debug.WriteLine(content + " Save to database");
            };
            save("Hello 4");
        }
    }
}
