using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllText("fileOne.txt").Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            string[] secondFile = File.ReadAllText("fileTwo.txt").Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllText("mergedFiles.txt", String.Empty);

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("mergedFiles.txt", firstFile[i] + "\r\n" + secondFile[i] + "\r\n");
            }

            Console.WriteLine(File.ReadAllText("mergedFiles.txt"));
        }
    }
}
