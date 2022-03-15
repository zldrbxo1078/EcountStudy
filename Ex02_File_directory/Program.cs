using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_File_directory
{

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\temp2";
            Directory.CreateDirectory(path);
            Console.WriteLine(Directory.Exists(path));

            string defaultDir = Directory.GetCurrentDirectory();    // 현재 실행되고 있는 파일
            Console.WriteLine(defaultDir);

            string[] dirs = Directory.GetDirectories(@"D:\temp");
            Console.WriteLine("D: 드라이브 폴더 목록");
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }

            string[] files = Directory.GetFiles(@"C:\windows");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            files = Directory.GetFiles(@"C:\windows", "*.log");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

        }
    }
}
