using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Singleton
{
    class Program
    {
        class Test
        {
            private static Test instance;  
            private Test()  //new 사용 불가
            {

            }
            public static Test getInstance ()
            {  //public을 통해 객체 얻어 내겠다
                if (instance == null)   //객체가 없을 때 생성! >> 한개만 생성 가능
                {
                    instance = new Test();  
                }
                return null;
            }
        }

        static void Main(string[] args)
        {
            Test t = Test.getInstance();
            Test t2 = Test.getInstance();
            Test t3 = Test.getInstance();

            Console.WriteLine(t == t2);
            Console.WriteLine(t2 == t3);
            //Console.WriteLine(t.GetHashCode()+" "+ t2.GetHashCode()+" "+ t3.GetHashCode());

        }
    }
}
