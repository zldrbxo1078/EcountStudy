using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_abstract_Interface
{
    /*
     공통점
        강제 구현
        상속을 목적으로 한다
        스스로 객체 생성 불가
        다형성
     차이점
        추상클래스
            단일상속
            멤버 필드를 가질 수 있다.
            일반 함수 가질 수 있다.
        인터페이스
            다중상속
            멤버필드 x 구현 함수 x
     
     
     */
    abstract class Unit
    {
            
    }
    class Tank : Unit
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Tank[] tanklist = { new Tank(), new Tank(), new Tank() };
            foreach(Tank t in tanklist)
            {
                t.move(555, 444);
            }
        }
    }
}
