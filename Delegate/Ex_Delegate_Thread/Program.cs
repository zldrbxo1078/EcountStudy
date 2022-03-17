using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex_Delegate_Thread
{
    internal class Program
    {
        delegate void simple();
        delegate void simple2(int x);
        delegate void staticDel();
        delegate string simple3(string x);

        class Test
        {
            public void Fmethod()
            {
                Console.WriteLine("일반메서드");
            }
            public void Fmethod2(int i)
            {
                Console.WriteLine("값 : {0}", i);
            }
            public void SMethod()
            {
                Console.WriteLine("정적 메서드");
            }
            public string Fmethod3(string s)
            {
                return s + "입니다.";
            }
        }

        static void Main(string[] args)
        {
            
            Test t = new Test();
            simple s = new simple(t.Fmethod);
            s();

            simple2 s2 = new simple2(t.Fmethod2);
            s2(10);
            staticDel s3 = new staticDel(t.SMethod);
            simple3 s4 = new simple3(t.Fmethod3);

        }
    }
}
