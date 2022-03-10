using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_abstract
{
    abstract class EmptyCan
    {
        public int count;
        public abstract int Count
        {
            get;    //return 구현
            set;    //value parameter 구현
        }

        public void speak()
        {
            Console.WriteLine("Speak!!");
        }

        public abstract void sound();
        public abstract void who();
    }

    class BeerCan : EmptyCan
    {
        public override int Count
        {
            get { return this.count; }
            set
            {
                this.count = value;
            }
        }
                

        public override void sound()
        {
            Console.WriteLine("깡깡깡...");
        }

        public override void who()
        {
            Console.WriteLine("홍길동이");
        }
    }
    class CyderCan : EmptyCan
    {
        public override int Count
        {
            get { return this.count; }
            set
            {
                this.count = value;
            }
        }


        public override void sound()
        {
            Console.WriteLine("깽깽갱...");
        }

        public override void who()
        {
            Console.WriteLine("아무개");
        }
        public void where()
        {
            Console.WriteLine("공원에서...");
        }
    }
    //필요시 함수를 추가 구현하는 것은 개발자 마음

    class Program
    {
        static void Main(string[] args)
        {
            BeerCan beer = new BeerCan();
            beer.sound();
            beer.who();
            

            CyderCan cyder = new CyderCan();
            cyder.sound();
            cyder.who();
            cyder.where();
        }
    }
}
