using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{
    public class Member
    {
        
        private string name;
        public Member(string name)
        {
            this.name = name; 
        }
        
    }
    //type없이 default 타입으로 생성가능

    //설계도(class) : 속성 + 기능
    //기능 == 행위 == , method(함수)
    class Test
    {
        private int i; //instance varibale, member field
        //행위 기능 4가지
        //void, parameter(x)    ex) public void m(){}
        //void, parameter(o)    ex) public void m(int a){}
        //return, parameter(x)  ex) public int m(){return result;}
        //return, parameter(o)  ex) public int m(int a){return result;}
        public void callMethod()
        {
            Console.WriteLine("일반함수");
        }
        public void callMethod2(int a)
        {
            if (i < 10)
            {
                Console.WriteLine("...");
            }
            else
            {
                Console.WriteLine("<<<<<");
            }
        }
        public string callMethod3()
        {
            return "타입만 동일";
        }
        public string callMethod4(string str)
        {
            return str + "방가";
        }
        //추가
        public int callMethod5(int i, int j, int k)
        {
            return i + j + k;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.callMethod();
            test.callMethod2(5);
            string result = test.callMethod3();
            Console.WriteLine(result);
            result = test.callMethod4("규태님!");
            Console.WriteLine(result);
            int value = test.callMethod5(1, 2, 3);
            Console.WriteLine(value);

            Member member = new Member("규태");
            Member member2 = new Member("상윤");
        }
    }
}
