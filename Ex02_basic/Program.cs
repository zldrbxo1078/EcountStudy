using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03_EmpLib;

namespace Ex02_basic
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Emp emp = new Emp();    //참조된 lib 클래스 인스턴스 생성
            emp.Empno = 7788;   //Emp.cs의 Empno set메서드 작동
            emp.Ename = "홍길동";  
            emp.Sal = 1000;
            Console.WriteLine(emp.Empno); //Emp.cs의 Ename get 메서드 작동
            emp.EmpPrint();
        }
    }
}
