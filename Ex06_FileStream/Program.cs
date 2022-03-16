using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FileStream fs = new FileStream("hello.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int data = int.Parse(sr.ReadLine());
            float fdata = float.Parse(sr.ReadLine());
            string strdata = sr.ReadLine();
            sr.Close();
            fs.Close();
            Console.WriteLine($"{data} - {fdata} - {strdata}");
            */
            using (StreamReader sr = new StreamReader(new FileStream("hello3.txt", FileMode.Open, FileAccess.Read)))
            {
                int data = int.Parse(sr.ReadLine());
                float fdata = float.Parse(sr.ReadLine());
                string strdata = sr.ReadLine();

                Console.WriteLine($"{data} - {fdata} - {strdata}");

            }   //자동 close() = finally
        }
    }
}
