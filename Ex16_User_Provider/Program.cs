using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_User_Provider
{
    /*
        객체간의 관계
        상속 : 포함

        user : 사용자
        provider : 제공자

        class A{}
        class B{}
        관계 A는 B를 사용합니다.
        
        1. 상속 : class A : B
        2. 포함 : A라는 클래스 안에서 memberfield B를 사용 class A {B b;}
        
        전체관계
        class B{}
        class A{
            B b;
            A(){
                b = new B();
            }
        }

        >>운명 공동체    
        >>A가 생성되면 B도 생성, 소멸시 같이 소멸
    
        --------------------------------------------------------------
        부분의 관계
        class B{}

        class A{
            B b;    (A는 B를 사용)
            A(){}
            A(B b){
                   this.b = b;
            }
        }   //A가 생성될 때 B도 같이 생성
        >>Main() {B b = new B(); A a = newA(b)} A가 필요에따라 B를 사용하는 것 뿐
        >>서로 다른 운명
        >> lifeCycle이 다르다.
        --------------------------------------------------------------
        의존관계 (dependency) : 함수를 기반으로 작업(함수 안에서 생성, 전달 등...)
        class B {}
        class A {
            //member field 로 B타입 변수를 가지지 않는 것
            B print(){
                B b = new B();
                return b;
            }
        }

        활용사례
        interface Icall{ void m(); }
        class C : Icall{
            //반드시 재정의
            public void m(){}
        }
        class D : Icall{
            //반드시 재정의
            public void m(){}
        }
        ***현대적인 프로그램 방식은 : 유연한, 대충 되는 것
        class E {
            void method(Icall ic){
                Icall을 구현한 C 또는 D 올 수 있다.
            }
            void method2(C c){}
            void method3(D d){}
            
        }
        
        

     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
