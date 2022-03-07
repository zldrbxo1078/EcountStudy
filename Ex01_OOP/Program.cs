using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_OOP
{
    /*
    class == 설계도 == 데이터 타입
    문제점)
    설계도가 한장이 아니라 여러장이 사용됨

    관계 ....
    여러장의 설계도
    is ~ a  : 상속
    has ~ a : 포함

    */
    class GrandFather   //따로 구현하지 않아도 모든 클래스는 object를 상속받는다. 단, 접근자 public
    {
        public int Gmoney = 1000;
        private int Pmoney = 1000000;   //누구에게도 상속하지 않는다. 
        protected int tmoney = 2000;    //상속관계에서만 존재
        //양면 : 직접 상속관계에선 public, 그외에는 private >>child에서 접근 불가!!

    }
    class Father : GrandFather
    {
        public int Fmoney = 500;
        public void print()
        {
            Console.WriteLine("tmoney : {0}", tmoney);
        }
    }
    class Child : Father
    {
        public int Cmoney = 100;
        //할아버지 돈도 내돈, 아버지 돈도 내돈, 내돈도 내돈
    }

    sealed class aaa //봉인된 >> 상속 불가 클래스
    {

    }

    //class bbb : aaa   //aaa는 sealed class이므로 상속받을 수 없다. 
    //{

    //}

    //다형성 : 하나의 이름으로 여러가지 기능 >>함수 (생성자, 일반함수)
    //입력 파라메터에 따라 다르게 정의 가능하다.
    //사용목적 : 개발자의 편의를 위해
    class Test
    {
        public void method() {
            Console.WriteLine("일반함수");
        }

        public void method(int i)
        {
            Console.WriteLine("i : {0}", i);
        }
        public void method(string i)
        {
            Console.WriteLine($"문자열 {i}");
        }
        public void method(int i, int j)
        {
            Console.WriteLine("i + j = {0}", i+j);
        }
        public void method(int i, string j)
        {
            Console.WriteLine("i + j = {0}", i+j);
        } 
        public void method(string j,int i)  //순서가 달라도 인정
        {
            Console.WriteLine("i + j = {0}", i+j);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("Gmoney: {0}", child.Gmoney);
            Console.WriteLine("Fmoney: {0}", child.Fmoney);
            Console.WriteLine("Cmoney: {0}", child.Cmoney);
            Father father = new Father();
            Test t = new Test();
           
            t.method();
            t.method(15);
            t.method("string");
            t.method(10, 5);
            t.method(10, "개");

        }
    }
}
