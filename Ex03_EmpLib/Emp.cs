using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_EmpLib
{
    public class Emp    //설계도
    {
        //속성(정보를 저장) + 기능
        private int empno;
        private string ename;
        private int sal;

        public Emp() { }
        public Emp(int empno, string ename, int sal)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
        }
        //private >> 캡슐화
        public int Empno
        {
            get { return empno; }
            set { empno = value; }
        }
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }
        public int Sal
        {
            get { return sal; }
            set { sal = value; }
        }

        public void EmpPrint()
        {
            Console.WriteLine("{0} - {1} - {2}", this.empno, this.ename, this.sal);
        }
    }
}
