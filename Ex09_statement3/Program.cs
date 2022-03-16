using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_statement3
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputdata = 0;
            do
            {
                Console.WriteLine("숫자를 입력해 주세요(0~9)");
                inputdata = int.Parse(Console.ReadLine());
            } while (inputdata >= 10);
            Console.WriteLine("당신이 입력한 숫자는 : {0}", inputdata);

            //간단한 피보나치
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < 10; i++)
            {
                a = b;
                b = c;
                c = a + b;
                //Console.WriteLine($"{a}, {b}, {c}");
                Console.WriteLine($"     {c}");
            }
            //java에서 '=='는 주소값 기반 비교 >>  equals 사용 but.C#은 == 사용.
            //C#에서는 문자열 비교도 그냥 '==' 쓰자
            string opr = "+";
            if (opr == "+")
            {
                Console.WriteLine("같은 문자열");
            }
        }
    }
}
