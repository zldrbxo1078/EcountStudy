using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayQuiz_Emp
{
    class Emp
    {
        static int count = 0;
        private int empno;
        private string ename;
        private string job;
        private int sal;

        public Emp( string ename, string job, int sal)
        {
            this.empno = ++count;
            this.ename = ename;
            this.job = job;
            this.sal = sal;
        }

        public override string ToString()
        {
            return this.empno + " " + this.ename + " " + this.job + " " + this.sal;
        }

        public void showEmp()
        {
            Console.WriteLine($"{empno} {ename} {job} {sal}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emplist = new List<Emp>();
            emplist.Add(new Emp("이순신", "장군", 10000));
            emplist.Add(new Emp("김유신", "장군", 8000));
            emplist.Add(new Emp("이병철", "회장", 10000000));
            foreach (Emp item in emplist)
            {
                item.showEmp();
            }
            Console.WriteLine("==============================");
            for (int i = 0; i < emplist.Count; i++)
            {
                emplist[i].showEmp();
            }
            Console.WriteLine("==============================");
            for (int i = 0; i < emplist.Count; i++)
            {
                Console.WriteLine(emplist[i]);
            }
        }
    }
}
