using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Constructor
{
    class Test
    {
        /*
            생성자 >> 특수한 목적의 함수 : member field의 초기화를 목적으로 
            생성방법 : 함수의 이름  = class이름과 동일, 접근자 public, return 타입 x
            종류 : default constructor(파라메터 X), 
                  overloading constructor(파라메터 의 개수와 타입을 달리해서 함수를 만드는 방법)
            실행시점 : 객체 생성과 동시에 호출(New Test(), new Test(100,200)) 
         */
    }
    class Test2
    {
        
        public Test2(){ } //default Constructor
    }
    class Test3
    {
        public Test3() { }
        public Test3(int i) { } //overloading Constructor
    }

    class Book
    {
        private string bName;
        private int price;

        public Book() { }
        public Book(string bName)
        {
            this.bName = bName;
            this.price = 1000;
        }
        public Book(int price)
        {
            this.bName = "무제";
            this.price = price;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
