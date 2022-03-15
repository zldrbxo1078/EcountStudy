using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_File
{
    internal class Program
    {
        /*
         입출력 (IO)
        1. stream (중간 매개체, 통로)
            Byte
            문자
        2. C# Syste.io
         
         */
        static void Main(string[] args)
        {
            string path = @"D:\temp\test.txt";

            //File.Create(path);

            //if (File.Exists(path))
            //{
            //    Console.WriteLine("{0}파일이 존재합니다.", path);
            //}
            //else
            //{
            //    Console.WriteLine("{0}파일이 없습니다.", path);
            //}

            File.AppendAllText(path, "추가추가 합니다.");
            DateTime dt = File.GetCreationTime(path);
            Console.WriteLine(dt.ToString());

            dt = File.GetLastAccessTime(path);
        }
    }
}
