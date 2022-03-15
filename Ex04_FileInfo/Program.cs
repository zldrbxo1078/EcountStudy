using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            if (args.Length < 1)
            {
                Console.WriteLine("사용법 : *.exe [디렉토리 경로]");
                return;
            }
            DirectoryInfo dirinfo = new DirectoryInfo(args[0]); 
            if (dirinfo.Exists)
            {
                DirectoryInfo[] dirs = dirinfo.GetDirectories();
                foreach (var dir in dirs)
                {
                    FileInfo[] files = dir.GetFiles();
                    Console.WriteLine(dir.FullName, files.Length);

                    int index = 0;
                    foreach (FileInfo file in files)
                    {
                        string str = string.Format("[{0}] : Name:{1} , Extention{2}, size{3}", ++index, file.Name, file.Exists, file.Length);
                        Console.WriteLine(str);
                    }
                }
            }
        }
    }
}
