using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");

            double filesSize = 0.0D;

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);

                filesSize += info.Length;
            }

            Console.WriteLine(filesSize / 1024 / 1024);
        }
    }
}
