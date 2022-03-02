using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    //설계도(class) : 속성 + 기능
    //기능 == 행위 == , method(함수)
    class Test
    {
        private int i; //instance varibale, member field
        //행위 기능 4가지
        //void, parameter(x)    ex) public void m(){}
        //void, parameter(o)    ex) public void m(int a){}
        //return, parameter(x)  ex) public int m(){return result;}
        //return, parameter(x)  ex) public int m(int a){return result;}
        public void callMethod()
        {
            Console.WriteLine("일반함수");
        }
        public void callMethod2(int a)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.callMethod();
        }
    }
}
