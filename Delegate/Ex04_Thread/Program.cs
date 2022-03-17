using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //thread 추가하기

namespace Ex04_Thread
{
   
    
    class Program
    {
        //하나의 프로세스에 한개의 스레드 동작 (지금까지는) >> Main함수(메인스레드) 
        //하나의 프로세스 여러개의 일꾼을 만들어서 사용하겠다. 

        public static void sprint()
        {
            Console.WriteLine("static 함수");
        }
        public void Print()
        {
            Console.WriteLine("일반 함수");
        }

        static void Main(string[] args)
        {
            string input = null;
            Program p = new Program();
            ThreadStart ts1 = new ThreadStart(p.Print);
            ThreadStart ts2 = new ThreadStart(sprint);
            Thread th1 = new Thread(ts1);
            Thread th2 = new Thread(ts2);

            th1.Start();
            th2.Start();
            Console.WriteLine("thread 시작!");
            while (input == null)
            {
                input = Console.ReadLine();
            }
        }
    }
}
