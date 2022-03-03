using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_static
{
    internal class Program
    {
        //static 자원
        //1. 객체 생성 이전에 메모리에 올라가는 자원
        //2. 객체를 생성하지 않고도 직접적인 접근이 가능한 자원
        //3. 종류 : static class, static field(Point), static constructor, static method(Point !)
        //4. 정리 >> "공유자원!"(객체간)
        //5. 접근 방법 ... 

        public class Sample
        {
            public static int s;
            public int i;
            public void print()
            {
                int l = 100;

            }
            public void printstatic()
            {
                Console.WriteLine(s);
            }
        }
        public class AirPlane
        {
            private string pName;
            private int pNum;
            public static int pCount;
            
            public AirPlane(string pName, int pNum)
            {
                pCount++;
                this.pName = pName;
                this.pNum = pNum;
                //Console.WriteLine($"{this.pName}, {this.pNum}");
                //Console.WriteLine("비행기의 총 대수 {0}", pCount);
            }

            public void printstate()
            {
                Console.WriteLine($"{this.pName}, {this.pNum}");
            }
            public void totalPlane()
            {
                Console.WriteLine("비행기의 총 대수 {0}", pCount);
            }



        }
        static void Main(string[] args)
        {
            Sample.s = 100;   //인스턴스 생성 전에도 접근 가능하다!    // static 자원은 공유자원!
            Sample sa = new Sample();
            sa.printstatic();
            Sample sa2 = new Sample();
            sa2.printstatic();
            Sample sa3 = new Sample();
            sa3.printstatic();

            AirPlane plane1 = new AirPlane("아시아나", 707);
            plane1.printstate();
            plane1.totalPlane();
            AirPlane plane2 = new AirPlane("대한항공", 708);
            plane2.printstate();
            plane2.totalPlane();
            AirPlane plane3 = new AirPlane("진에어", 709);
            plane3.printstate();
            plane3.totalPlane();

            Console.WriteLine(AirPlane.pCount);
        }
    }
}
