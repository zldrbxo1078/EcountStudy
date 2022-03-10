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
        private int money = 1000;
        private int bonuspoint;
        public Product[] cart;


        //hint)
        //오버로딩 개념
        //다형성 개념


        //모든 전자제품의 부모는  Product  (다형성)
        //Product product = new Audio();
        //Product product = new KtTv();
        //Product product = new NoteBook();
        //단 product 는 자신의 자원 볼 수 있다 (

        public void Buy(Product n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }
        public void summary()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
