using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ValueType
{
    #region +값 타입 : 구조체 : 작은 타입을 모아서 의미있는 집합으로 만드는 것
    enum mycolor {black, white, red, green, blue }; //열거 타입 >> 상수값 자동 지정 0~ -> 열거형도 값타입이다.
    enum week { mon, tue = 101, sat, sun }  //지정한 숫자부터 자동 지정 ++
    //명시적으로 상수값 설정
    struct Book
    {
        public string name;
        public int price;

        public Book(string _name , int _price)  //생성자 함수 Book이 가지는 member 초기화
        {
            name = _name;
            price = _price;
        }
    }
    #endregion

    class Car
    {
        public string name;
        public int price;

        public Car(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = 3.14f;

            Book book = new Book("홍길동전", 10000);
            //구조체에서 new 는 객체를 생성하는 연산자가 아니다. 단지 초기화만 담당
            //Book 구조체가 값 타입임을 증명
            Book book2 = book;
            //구조체의 할당은 새로운 구조체를 하나 더 만드는 것이다. 
            book2.name = "길동이";
            book2.price = 30000;
            Console.WriteLine("book  {0} : {1}", book.name, book.price);
            Console.WriteLine("book2 {0} : {1}", book2.name, book2.price);
            //같은 struct를 공유하는 것이 아닌 새로운 값을 가지는 구조체 생성

            Car car = new Car("GV80", 1000);
            //new 라는 연산자는 [객체를 생성하는 연산자] (heap에 저장)
            Car car2 = car;
            car2.name = "newOne";
            car2.price = 5000;
            Console.WriteLine("car  {0} : {1}", car.name, car.price);
            Console.WriteLine("car2 {0} : {1}", car2.name, car2.price);
            //같은 주소값을 가진다. 주소값 참조

            mycolor m;
            //열거 타입 변수는 열거형 중에 하나를 가질 수 있다. 
            m = mycolor.black;
            Console.WriteLine(m);
            Console.WriteLine((int)m);

            Console.BackgroundColor = ConsoleColor.Green; //이미 만들어져있는 열거형 타입

            week w = week.sat;  //개발자는 문자열 형태로 코드해석 편하게 작업 가능
            Console.WriteLine($"여기에 표현하겠다 : {w}");

            //보간법
            int a = 10;
            int b = 20;
            Console.WriteLine($"{a} + {b} = {a + b}");

            //상수
            const double PI = 3.14; //상수 : 관용적 표현 - 상수의 이름은 대문자로 쓰자
            //PI = 3.141592 //변경불가

            long lon2 = 100000;
            int num2 = (int)lon2;    //값을 보지말고 가지고 있는 타입으로 생각 long >> int 문제
            //다행이도 형변환한 값이 int 범위라면 문제(손실)가 없다.
            Console.WriteLine(num2);

            //데이터 손실
            long lon3 = 10000000000;
            int num3 = (int)lon3;
            Console.WriteLine(num3);
            //큰 타입 -> 작은 타입 변환 시 손실을 감안해야 한다.

            
        }
    }
}
