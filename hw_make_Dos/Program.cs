using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_make_Dos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            string path = args[0];
            if (args.Length < 1)
            {
                Console.WriteLine("사용법 : *.exe [디렉토리 경로]");
                return;
            }else 
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("디렉토리가 삭제되었습니다.");
            }
            else
            {
                Console.WriteLine("Directory Not Exist");
            }
        }
    }
}
