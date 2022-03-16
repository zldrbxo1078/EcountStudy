using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //fileStream을 통해 text 형태의 파일을 접근할 수 있다. 
            /*
            FileStream fs = null;
            StreamWriter streamWriter = null;
            try
            {
                fs = new FileStream("hello.txt", FileMode.OpenOrCreate);
                streamWriter = new StreamWriter(fs);

                int data = 100;
                float fdata = 3.14f;
                string strdata = "hello world";

                streamWriter.Write(data);
                streamWriter.Write(fdata);
                streamWriter.Write(strdata);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                streamWriter.Close();
                fs.Close();
            }
            */
            using(StreamWriter sw = new StreamWriter(new FileStream("hello3.txt", FileMode.OpenOrCreate))){
                int data = 100;
                float fdata = 3.14f;
                string strdata = "hello world";

                sw.WriteLine(data);
                sw.WriteLine(fdata);
                sw.WriteLine(strdata);
            }   //자동 close() = finally
        }
    }
}
