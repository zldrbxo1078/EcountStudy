using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_basic
{
    class Car
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            char c; //2byte 0~255
            c = 'A';

            char d;
            d = '나';
            Console.WriteLine("c:{0}, d:{1}", c,d);

            //지역변수는 반드시 [초기화]를 통해서 사용한다.
            short s = 10000;

        }
    }
}
