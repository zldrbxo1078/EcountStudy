using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_static_scope
{
        public class Test
        {
            private static int i;   //private 접근자 > 클래스 이름 접근 불가    > test.i (x)
            public static int j;    //public 접근자 > 클래스 이름 접근 가능     > Test.j (O) 

            //클래스가 일반자원 과 static 자원 모두 가지고 있는경우
            // 일반함수에서 static member 가지고 놀 수 있다. 
            //static 함수에서 일반 member 가지고 놀 수 없다.  >> 생성시점의 문제 때문에 (언제나 static이 먼저 들어간다!)
            public static void method()
            {
                i = 100;    //static
                j = 200;
                Console.WriteLine("i: {0}, j : {1}", i, j);
            }

            public void gMethod()
            {
                i = 300;    //static
                j = 500;
                Console.WriteLine("i: {0}, j : {1}", i, j);
            }

        }
    class Program
    {
        private static int sint;
        private int gint;

        static void Main(string[] args)
        {
            Test.method();
            Test t = new Test();
            t.gMethod();

            Program.sint = 100;     //같은 static이므로 사용가능
            Program p = new Program();
            p.gint = 100;           //memory 에 안담겨 있기 때문에 new 를 통해 객체 호출해야한다.
        }
    }
}
