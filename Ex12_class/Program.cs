using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("G80", "black");
            Console.WriteLine($"{ car.Name} {car.Color}");
            car.info();
            Car car2 = new Car();   //기본으로 생성 "g70" "white"
            car2.info();


        }
    }
}
