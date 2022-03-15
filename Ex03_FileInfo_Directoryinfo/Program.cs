using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_FileInfo_Directoryinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Program Files (x86)\Internet Explorer");
            if (dirInfo.Exists) //경로 맞는지 확인
            {
                Console.WriteLine("전체 경로: {0}", dirInfo.FullName);
                Console.WriteLine("디렉토리이름 : {0}", dirInfo.Name);
                Console.WriteLine("생성일 : {0}", dirInfo.CreationTime);
                Console.WriteLine("속성 : {0}", dirInfo.Attributes);
                Console.WriteLine("루트 경로 : {0}", dirInfo.Root);
                Console.WriteLine("부모 Dir {0}", dirInfo.Parent);
            }
            else
            {
                Console.WriteLine("잘못된 경로입니다..");
            }
            Console.WriteLine();
            FileInfo finfo = new FileInfo(@"D:/temp/test.txt");
            if (finfo.Exists) //경로 맞는지 확인
            {
                Console.WriteLine("폴더이름: {0}", finfo.Directory);
                Console.WriteLine("파일이름 : {0}", finfo.Name);
                Console.WriteLine("확장자 : {0}", finfo.Extension);
                Console.WriteLine("생성일 : {0}", finfo.CreationTime);
                Console.WriteLine("파일크기 : {0}", finfo.Length);  //길이로 판단!
                Console.WriteLine("파일속성 : {0}", finfo.Attributes);
            }
            else
            {
                Console.WriteLine("잘못된 경로입니다..");
            }
        }
    }
}
