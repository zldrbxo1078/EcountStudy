using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_CallByVal
{
    class Car
    {
        public int speed;
        public void run(int data)
        {
            speed += data;
            data = 100;
        }
    }
    class Car2
    {
        public int speed;
        public void run(ref int data)   //주소값
        {
            speed += data;
            data = 50;  //주소에다 50을 쓰는 것
        }
    }
        class Car3
    {
        public int speed;
        public void run(out int data)   //주소값
        {
            data = 100;
            speed += data;
            data = 50;  //주소에다 50을 쓰는 것
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int data2 = 20;
            car.run(data2);
            Console.WriteLine(car.speed);
            Console.WriteLine("data2 : {0}", data2);
            

            Car2 car2 = new Car2();
            int data3 = 20; //주소값
            car2.run(ref data3);
            Console.WriteLine(car2.speed);
            Console.WriteLine("data3 : {0}", data3);


            Car3 car3 = new Car3();
            int data4 = 20;
            car.run(data4);
            Console.WriteLine(car.speed);
            Console.WriteLine("data4 : {0}", data4);

        }
    }
}
