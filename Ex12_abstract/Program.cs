using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_abstract
{
    class Program
    {
        //1. 추상클래스
        //미완성 함수를 구현 >> 상속 클래스에서 구현하도록
        //2. 목적 : 상속관계에서 강제적 구현을 목적 >> 빼먹을까봐
        /*
          3. 특징 
                1. 스스로 객체 생성 불가
                2. 상속관계에서 구현
                3. abstract method 반드시 구현해야 한다.
                4. 자동 virtual 반드시 override 구현
        */

        abstract class AbstractClass
        {
            public void print()
            {
                Console.WriteLine("완성된 코드...");

            }
            public abstract void abMethod();  //실행블럭이 없어요
        }

        class Dummy : AbstractClass
        {
            public override void abMethod()
            {
                Console.WriteLine("추상 메서드 구현");
            }
        }

        static void Main(string[] args)
        {
            Dummy d = new Dummy();
            d.abMethod();
            d.print();
        }
    }
}
