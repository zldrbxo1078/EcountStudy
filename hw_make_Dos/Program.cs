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
            string path = args[0];
            if (args.Length < 1)
            {
                Console.WriteLine("사용법 : *.exe [옵션] [디렉토리 경로]");
                Console.WriteLine("[옵션] : -s");
                return;
            }
            if (path.Trim() == "-s")
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("디렉토리를 삭제하시겠습니까?");
                    Console.WriteLine("Y / N");
                    string input = Console.ReadLine();
                    if (input == "Y")
                    {
                        File.Delete(path);
                    }
                    else
                    {
                        return;
                    }
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
}
