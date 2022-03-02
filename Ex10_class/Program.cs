using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{
    //클래스 == 설계도 == 데이터 타입
    class Person
    {
        //설계도라고 정의 : 속성 + 기능
        public int num;    //클래스가 가지는 변수 = instance variable
        int ename;
        //기본적으로 접근자 가지고 있다. default private
        private int k;
        public int y;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Ename
        {
            get { return num; }
            set { ename = value; }
        }
    }
    class Apt
    {
        private string aptname;
        private string aptcolor;

        //함수 이용해서 초기화 
        //특수 목적의 함수 (member field의 초기화)
        //설계 약속 : 함수의 이름 클래스 이름과 같다.
        //생성자 함수 >> 객체가 생성될 때 호출
        //member field 가 먼저 올라가고 생성자 함수가 실행된다. 
        public Apt()        //void 타입형이 숨겨져 있다. 
        {

        }

        //생성자 함수 - overloading (함수의 이름은 같으나 parameter의 개수와 타입을 다르게)
        public Apt(string aptname,string aptcolor)
        {
            this.aptname = aptname;
            this.aptcolor = aptcolor;
        }
        public string Aptname
        {
            get { return aptname; }
        }
        public string Aptcolor
        {
            get { return aptcolor; }
        }
    }
    //요구사항
    //아파트 만들 때 특별한 요구사항이 없으면 이름과 색상은 기본설정을 한다
    //Apt apt = new Apt();
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person();
            p.num = 100;

            Apt apt = new Apt();
            Apt apt2 = new Apt("Ian","blue");   //인스턴스 생성과 동시에 초기화
            Console.WriteLine($"apt.name : {apt2.Aptname}");
            Console.WriteLine($"apt.color : {apt2.Aptcolor}");

        }
    }
}
