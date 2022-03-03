using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string winner;
            int cpu = 0;
            int input = 0;

            while (true)
            {
                cpu = rnd.Next(1, 4);
                winner = "";
                input = 0;

                Console.WriteLine("**");
                Console.WriteLine("1. 가위 | 2. 바위 | 3. 보 | 4. 종료");
                Console.WriteLine("**");
                Console.WriteLine("선택");


                input = int.Parse(Console.ReadLine());
                if (input == 4) break;
                winner = cpu == input ? "무승부" : (3 + input - cpu) % 3 == 1 ? "승리" : "패배";
                Console.WriteLine("컴퓨터: {0}\t 플레이어: {1}\t 결과: {2}", cpu, input, winner);
            }
        }
    }
}
