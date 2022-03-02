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
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
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
                default:
                    Console.WriteLine("nothing");
                    break;

            }
            int k = 1;
            int ksum = 0;
            while (k <= 100)
            {
                ksum += k;
                k++;
            }
            Console.WriteLine("누적합 : {0}, i : {1}", k, ksum);

            //짝수합
            int y = 1;
            int ysum = 0;
            while (y <= 100)
            {
                if (y % 2 == 0)
                {
                    y++;
                    continue;
                }
                ysum += y;
                y++;
            }
            Console.WriteLine($"홀수합 : {ysum}, y : {y}");

            int even = 0;
            int odd = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
            }
            Console.WriteLine($"짝수 : {even}, 홀수 : {odd}");

            Console.WriteLine("ID : ");
            string id = Console.ReadLine();
            Console.WriteLine("PASSWORD : ");
            string pw = Console.ReadLine();

            if (id == "admin" && pw == "1234")
            {
                    Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("정보가 없습니다.");
            }

            //삼항 연산자 : 암기
            int p2 = 10;
            int k2 = -10;

            int result2 = (p2 == k2) ? p2 : k2;
            Console.WriteLine("result2 : {0}", result2);

            int x1 = 3;
            int x2 = 5;

            Console.WriteLine(x1 & x2);
            Console.WriteLine(x1 | x2);


        }


    }
}
