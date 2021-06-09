using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo3
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
            Save savePDF = SaveToPDF;
            Save saveText = SaveToText;
            Save saveWord = SaveToWord;
            Save savePDFText = savePDF + saveText;
            savePDFText += SaveToWord;
            savePDFText("Hello 1");

            savePDFText -= saveText;
            savePDFText("Hello 2");
        }
    }
}
