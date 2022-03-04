using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayQuiz
{
    
    class Seat
    {
        string[,] seat = new string[3, 5];
        int select = 0;

        public void SetSeat()
        {

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {

                    seat[i, j] = "__";

                }
            }
        }

        public void ShowSeat()
        {
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {

                    Console.Write(seat[i, j] == "__" ? $"[{i+1}-{j+1}]" : "[예매]");
                }
                Console.WriteLine();
            }
        }

        public void Reservation(int row, int col, string customerNum)
        {
            if(seat[row - 1, col - 1] == "__")
            {
                seat[row - 1, col - 1] = customerNum;
                Console.WriteLine("예매가 완료되었습니다.");
                Console.WriteLine($"예매된 좌석 : {row}-{col} / 예매번호 : {customerNum}");
            }
            else if (seat[row - 1, col - 1] == "예매")
            {
                Console.WriteLine("이미 예약된 좌석입니다.");
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

        }
        public void ReserveCancel(string inputnum)
        {
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    if (seat[i, j] == inputnum)
                    {
                        Console.WriteLine($"고객님의 좌석은 {i+1}-{j+1}입니다.");
                        Console.WriteLine("취소하시겠습니까?(예.1 아니오.2)");
                        select = Int32.Parse(Console.ReadLine());
                        if (select == 1)
                        {
                            seat[i, j] = "__";
                            Console.WriteLine("예매가 취소되었습니다.");
                            break;
                        }
                        break;
                    }

                }
            }
            
        }
        
    }


  
    class Program
    {
        static void Main(string[] args)
        {
            Seat seats = new Seat();
            seats.SetSeat();
            int row, col;
            string customernum = (new Random()).Next().ToString();

            string inputnum = "";

            while (true)
            {
                Console.WriteLine("************************");
                Console.WriteLine("*****영화 예매 시스템*****");
                Console.WriteLine("************************");
                Console.WriteLine("1. 예매하기\n");
                Console.WriteLine("2. 예매조회\n");
                Console.WriteLine("3. 예매취소\n");
                Console.WriteLine("4. 종료\n");
                int select = Int32.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("좌석의 행을 입력하세요");
                        row = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("좌석의 열을 입력하세요");
                        col = Int32.Parse(Console.ReadLine());

                        seats.Reservation(row,col, customernum);
                        break;
                    case 2:
                        seats.ShowSeat();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("예약번호를 입력해주세요");
                        inputnum = Console.ReadLine();
                        seats.ReserveCancel(inputnum);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }
        }
    }
}
