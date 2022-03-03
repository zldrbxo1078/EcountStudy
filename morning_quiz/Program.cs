using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morning_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i < num+1; i++)
            {
                result *= i;
            }
            Console.WriteLine($"{num}의 팩토리얼 = {result}");
        }
    }
}
