using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Interface
{
   /*
        인터페이스 : 표준, 약속, 규칙, 규약을 만드는 행위
        1. 소프트웨어 설계 최상위 단계
        2. 게임 >> run() 달린다, move(int x, int y) 표준
        
        **초급 개발자**
        1. 인터페이스를 [다형성] 입장에서 접근 사용
        2. 서로 연관성이 없는 클래스를 하나로 묶어주는 기능
        3. C# 제공하는 수 많은 API (Collection) >> 인터페이스 활용 >> 사용방법
        4. ~able ... ~ 수리 할 수 있는, 날 수 있는 의미 접근
        5. 객체간 연결 고리 (객체간 소통) >> 다형성
        
        문법)
        1. 인터페이스는 모든 멤버라 구현부를 가지지 않는다.
        2. 인터페이스는 상속을 통한 강제 구현을 목적으로 한다.
        3. 모든 접근자는 public 
        4. 멤버필드를 가지지 않는다.
    */
   public interface Ia
    {
        void m();
        int Count
        {
            get;
        }
    }

    public interface Ib
    {
        void m2();


    }

    abstract class Abclass
    {
        public void run() { }
        public abstract void move();
    }
    class Child : Abclass, Ia, Ib
    {
        public override void move()
        {
        }
        public int Count
        {
            get { return 100; }
        }

        public void m()
        {
            Console.WriteLine("Ia.m()");
        }

        public void m2()
        {
            Console.WriteLine("Ib.m2()");
        }

    }

    interface Irepairable {
    } //할 수 있는 (하나의 의미로)

    class Unit
    {
        public int hitpoint; //기본 에너지
        public readonly int MAXHP; //최대 에너지
        public Unit(int hp)
        {
            this.MAXHP = hp;
        }
    }

    //지상유닛
    class GroundUnit : Unit
    {
        public GroundUnit(int hp) : base(hp)
        { // Unit 생성자 호출(부모)

        }
    }

    class AirUnit : Unit
    {
        public AirUnit(int hp) : base(hp)
        { // Unit 생성자 호출(부모)

        }
    }

    class CommandCenter : Irepairable
    {
        public int hitpoint; //기본 에너지
        public readonly int MAXHP; //최대 에너지
        public CommandCenter(int hp)
        {
            this.MAXHP = hp;
        }

        //수리하는 방법이 다르다

    }

    class Tank : GroundUnit, Irepairable
    {  //Irepairable >>  부모타입
        public Tank() : base(50)
        {

        }

        

        public override string ToString()
        {
            return "Tank";
        }
    }

    class Marine : GroundUnit
    {
        public Marine() : base(50)
        {

        }

        public override string ToString()
        {
            return "Marine";
        }
    }

    class Scv : GroundUnit, Irepairable
    {
        public Scv() : base(50)
        {

        }
        public override string ToString()
        {
            return "Scv";
        }

        //수리하다
        //scv 구체화되고 특수화된 기능 
        //repair
        //repair : Tank , Scv , CommandCenter

        /*
        public void repair(Tank t) {
            if (t.hitpoint != t.MAXHP) 
            {
                t.hitpoint += 5;
            }
        }

        public void repair(Scv s)
        {
            if (s.hitpoint != s.MAXHP)
            {
                s.hitpoint += 5;
            }
        }

        public void repair(CommandCenter c)
        {
        }
        */
        /*
        1. Unit 개수가 증가하면 repair  함수의 개수도 같이 증가한다
        2. 한개의  repair 모든 수리를 하고 싶다 
        ex)  public void repair(Unit unit) {   }  //Marine repair 대상이 아닌데  ... 
             public void repair(GroundUnit unit) {} // //Marine repair 대상이 아닌데  ...
         

             Marine , Scv , Tank , commandCenter 서로 연관성이 없다 
             //서로 연관성이 없는 자원들을 .... 묶어주기 ....
             
             //수리 가능한 , 수리 할 수 있는   (~able) : interface  >> interface Irepairable { }
             
             //class CommandCenter : Irepairable
             //class Scv : GroundUnit , Irepairable
             //class Tank : GroundUnit , Irepairable
            */
        public void Repair(Irepairable repairunit)
        {
            if (repairunit is Unit)
            {
                Unit unit = (Unit)repairunit;
                Console.WriteLine("유닛이 수리되었습니다.");
                if (unit.hitpoint < unit.MAXHP)
                {
                    unit.hitpoint += 5;
                }
            }
            else if (repairunit is CommandCenter)
            {
                CommandCenter center = (CommandCenter)repairunit;
                Console.WriteLine("커맨드 센터가 수리되었습니다.");
                //Console.WriteLine(center.MAXHP);
                if (center.hitpoint < center.MAXHP)
                {
                    center.hitpoint += 20;
                }
            }
        }


    }

        
    

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.m();
            child.m2();
            child.move();

            CommandCenter c = new CommandCenter(100);
            Scv scv = new Scv();
            scv.Repair(c);            
        }
    }
}
