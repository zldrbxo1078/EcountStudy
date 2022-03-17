using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Multi_Delegate
{
    delegate void MulDel(string s);
    delegate void MulDel2(string s);
    delegate int MulDel3(int i, int j);

    class Test
    {
        public void mul_1(string s)
        {
            Console.WriteLine("1번 : {0}", s);
        }
        public void mul_2(string s)
        {
            Console.WriteLine("2번 : {0}", s);
        }
        public void mul_3(string s)
        {
            Console.WriteLine("2번 : {0}", s);
        }
        public int mul_4(int i, int j)
        {
            return i + j;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test();
            MulDel m = new MulDel(test.mul_1);
            MulDel m2 = new MulDel(test.mul_2);
            m("출발");
            m2("나도 출발");

            MulDel m3;
            m3 = m;
            m3 += m2;   //메소드를 합쳐서 같이 실행할 수 있다. 단, 형식이 같아야한다.

            m3("전체 출발");

            MulDel3 m4 = new MulDel3(test.mul_4);
            int result = m4(3, 5);
            Console.WriteLine(result);


        }
    }
}
