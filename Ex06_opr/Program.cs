using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_opr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(100 + 100);
            Console.WriteLine("100" + "100");

            int k = 100;
            k++;    //후치 증가
            ++k;    //전치 증가

            int sum = 0;
            int s2 = 100;
            sum += s2;

            int ysum;
            int y = 10;
            ysum = y++ + 10;    //연산 먼저 진행되고 나중에 y++연산 >> ysum 자체에 적용 안됨
            Console.WriteLine($"y : {y}, ysum : {ysum}");

        }
    }
}
