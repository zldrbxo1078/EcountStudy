using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RefType
{
    //하나의 네임스페이스 안에 다른 클래스 잘 안만든다. >> 수업용이다.
    class Test
    {
        public int i;   //member field (instance variable) = 전역변수
        //클래스 내에서 유효하다. 자동으로 default값이 부여됨(0)
        
        public void print()
        {
            int data = 100; //local variable 선언된 함수 내에서만 사용
            Console.WriteLine("data : {0}", data);
            Console.WriteLine(i);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.print();

            Test test2 = new Test();
            test2.print();

            Test test3 = new Test();
            test3.print();

            
        }
    }
}
