using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i : {0}", i);

            }
            //int i;    //문법적으로 이해만 하자 
            //for(i =0; i< 10; i++)
            //{
            //    Console.WriteLine("i : {0}", i)
            //}

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i,j,i*j);
                }
            }

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    //Console.WriteLine("*"); ;
                    if (i == j) continue;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int result;
            Console.WriteLine("숫자값을 입력하세요:");
            result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine(result);
                    break;
                case 4:
                    Console.WriteLine(result);

                    break;
                case 5:
                    Console.WriteLine(result);

                    break;
                default: Console.WriteLine("nothing");
                    break;

            }
        }
    }
}
