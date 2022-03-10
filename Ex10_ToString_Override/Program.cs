using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ToString_Override
{
    class Program
    {
        //1. 사용자가 만드는 모든 클래스는 기본적으로 Object를 상속받는다.
        //2. 프레임워크가 제공하는 수많은 클래스도 Object를 상속받고 필요에 따라 재정의를 구현하고 있다.
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public override string ToString()
            {
                return "Person : " + Name + "-" + Age;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Name = "Smith",
                Age = 12
            };
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p);   //둘다 같은 출력을 한다!namespace.클래스이름

            Console.WriteLine(p.ToString());    //재정의 된 함수로 출력! 
            Console.WriteLine(p);               //개발자가 목적에 따른 출력에 의해 재정의를 가장 많이 하는 함수

        }
    }
}
