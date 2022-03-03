using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_const_readonly
{
    class Test
    {
        //const
        //1. 반드시 초기화
        //2. 객체간 공유자원 > 자동 static
        public const int MAXVALUE = 10000;

        //readonly 상수 생성시
        //1. 반드시 초기화 할 필요없다.
        //2. 생성자에서 딱 한번 값을 할당 할 수 있다. (변경불가)
        //3. 객체마다 다른 상수값을 설정할 수 있다. 
        public readonly int readdata;

        public Test(int data)
        {
            readdata = data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test.MAXVALUE);

            Test t = new Test(10);
            Console.WriteLine("t.readdata : {0}", t.readdata);
            Test t2 = new Test(20);
            Console.WriteLine("t2.readdata : {0}", t2.readdata);

        }
    }
}
