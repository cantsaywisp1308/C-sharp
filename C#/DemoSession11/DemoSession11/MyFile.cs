using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession11
{
    public class MyFile
    {
        public delegate void ReadFileDelegate(FileInfo fileInfo);

        public delegate void ReadFolderDelegate(DirectoryInfo directoryInfo);
        public event ReadFileDelegate ReadFile;
        public event ReadFolderDelegate ReadFolder;

        public void Run(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            foreach(var fileInfo in fileInfos)
            {
                if(ReadFile != null)
                {
                    ReadFile(fileInfo);
                }
            }

            DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
            foreach(var directoryInfo1 in directoryInfos)
            {
                if(ReadFolder != null)
                {
                    ReadFolder(directoryInfo1);
                }
            }
        }

    }
}
