using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_team_
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Square(input));
            int Square(int num)
            {
                return num * num;
            }
            int Square(double num)
            {
                return num*num;
            }
        }
    }
}
