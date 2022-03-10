using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_CartQuiz
{
    /*
    요구사항

    카트 (Cart) >> Buy 안에 구현
    카트에는 매장에 있는 모든 전자제품을 담을 수 있다
    카트의 크기는 고정되어 있다 (10개) : 1개 , 2개 담을 수 있고 최대 10개까지 담을 수 있다

    고객이 물건을 구매 하면 ... 카트에 담는다
    계산대에 가면 전체 계산
    계산기능이 필요

    summary() 기능 추가해 주세요
    당신이 구매한 물건이름 과 가격정보 나열
    총 누적금액 계산 출력
    hint) 카트 물건을 담는 행위 (Buy() 함수안에서 cart 담는 것을 구현 )
    hint) Buyer ..>> summary() main 함수에서 계산할때
    구매자는 default 금액을 가지고 있고 초기금액을 설정할 수 도 있다

    */
    class Product : Object
    {
        public int price;
        public int bonuspoint;
        public Product() { }
        public Product(int price)
        {
            this.price = price;
            this.bonuspoint = (int)(this.price / 10.0);
        }
    }

    class KtTv : Product
    {
        public KtTv() : base(500)  //상위 생성자를 호출하는  base
        {

        }

        public override string ToString()  //Object 가지는 public virtual 자원 
        {
            return "KtTv";
        }

    }


    class Audio : Product
    {
        public Audio() : base(100)
        {

        }

        public override string ToString()
        {
            return "Audio";
        }
    }


    class NoteBook : Product
    {
        public NoteBook() : base(150)
        {

        }

        public override string ToString()
        {
            return "NoteBook";
        }
    }

    //구매자
    class Buyer
    {
        private int money;
        private int bonuspoint;
        private Product[] cart;
        private int count;

        public Buyer() : this(1000) { }
        public Buyer(int money)
        {
            this.money = money;
            count = 0;
            cart = new Product[10];
        }
        //hint)
        //오버로딩 개념
        //다형성 개념


        //모든 전자제품의 부모는  Product  (다형성)
        //Product product = new Audio();
        //Product product = new KtTv();
        //Product product = new NoteBook();
        //단 product 는 자신의 자원 볼 수 있다 (

        public void Buy(Product n)
        {  
            if (count > 9)
            {
                Console.WriteLine("장바구니가 꽉 찼습니다!");
            }
            else
            {
                cart[count++] = n;
            }
        }
        public void summary()
        {
            int priceSum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"구매한 물건은 {cart[i].ToString()}");
                priceSum += cart[i].price;
                this.bonuspoint += cart[i].bonuspoint;
            }
            this.money -= priceSum;
            if (money < priceSum)
            {
                Console.WriteLine("잔액이 부족합니다.ㅠ");
            }
            else
            {
                Console.WriteLine($"총합은 : {priceSum}원 입니다.");
                Console.WriteLine($"남은 잔액은 : {this.money}입니다.");
                Console.WriteLine($"현재 포인트 : {this.bonuspoint}");
            }
        }
       

        class Program
        {
            static void Main(string[] args)
            {
                Buyer buyer = new Buyer(10000);
                buyer.Buy(new Audio());
                buyer.Buy(new NoteBook());
                buyer.Buy(new KtTv());
                buyer.Buy(new KtTv());
                buyer.Buy(new KtTv());
                buyer.summary();

                Buyer b2 = new Buyer();
                b2.Buy(new NoteBook());
                b2.Buy(new KtTv());
                b2.Buy(new KtTv());
                b2.summary();

                Buyer b3 = new Buyer(5000);
                for (int i = 0; i < 11; i++)
                {
                    b3.Buy(new Audio());
                }
            }
        }
    }
}
