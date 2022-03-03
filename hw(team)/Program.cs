using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_team_
{
    public class Method
    {
        public int Square(int num)
        {
            return num * num;
        }

        public double Square(double num)
        {
            return num * num;
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Method method = new Method();
            Console.WriteLine(method.Square(input);
            
        }
    }
}
