using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    internal class ATM
    {
        string name;
        private int ecount;

        public ATM()
        {
            this.name = "홍길동";
            this.ecount = 0;
        }
        public ATM(string name, int ecount)
        {
            this.name = name;
            this.ecount = ecount;
        }

        public void Deposit(int ecount)
        {
            this.ecount += ecount;
            Console.WriteLine($"{ecount}");
        }
        public void Withdraw(int ecount)
        {
            if (this.ecount > ecount)
            {
                this.ecount -= ecount;
            }
            else
            {
                Console.WriteLine("잔액이 부족합니다.");
            }
            Console.WriteLine($"{ecount}");
        }

    }
}
