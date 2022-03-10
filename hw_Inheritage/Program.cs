using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_Inheritage
{
    class Vmachine
    {
        int inputmoney;
        int outputmoney;
        
        public virtual void returnProduct()
        {
            Console.WriteLine("제품이 나옵니다.");
        }
        public int calc(int num)
        {
            return inputmoney - num;
        }
    }
    class BeverageMachine : Vmachine
    {
        string[] coldbeverage;
        string[] hotbeverage;
    }
    
    class CoffeeMachine :Vmachine
    {
        string[] icecoffee;
        string[] hotcoffee;

        public override void returnProduct()
        {
            Console.WriteLine("음료가 다 나올 때까지 컵을 빼지 마십시오");
        }
    }


    class SnackMachine : Vmachine
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
}
