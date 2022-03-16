using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Array_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seat = new string[3, 5];

            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {

                    seat[i, j] = "__";

                }
            }

            seat[2, 1] = "홍길동";
            seat[0, 0] = "김유신";
            
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {
                    
                    Console.Write(seat[i, j] == "__" ? "[빈좌석]" : "[예매]");
                }
                Console.WriteLine();
            }

            int row, col;
            //예매 시작
            row = 0;
            col = 0;    //0행 0열 예매
            if (seat[row, col] == "__")
            {
                Console.WriteLine("예매 가능한 좌석 입니다.");
            }
            else
            {
                Console.WriteLine("이미 예약된 좌석입니다.");
            }

            //예매 가능 하도록 좌석 초기화
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {

                    seat[i, j] = "__";  //좌석 초기화

                }
            }
            for (int i = 0; i < seat.GetLength(0); i++)
            {
                for (int j = 0; j < seat.GetLength(1); j++)
                {

                    Console.Write(seat[i, j] == "__" ? "[빈좌석]" : "[예매]");
                }
                Console.WriteLine();
            }
        }
    }
}
