using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    /*
     개발환경에서 업무가 복잡하다. (도메인 지식)
     ex) 쇼핑몰
     회원관리, 주문관리, 상품관리, 배송관리 >> 각각의 업무가 독립적인 것 보다는 관계를 가지고 있다.
     여러 설계도는 서로 관계를 가져야 한다.
     1. 상속 (is ~ a)은 이다 명제가 성립되면 90% 상속을 통해 구현(원은 도형이다. 새는 조류다. )
     2. 포함 (has ~ a) 은 ~을 가지고 있다 명제 성립되면 구현

     원 - 점과의 관계
     원은 점이다 (x)
     원은 점을 가지고 있다. (O) 포함관계


     원, 삼각형, 네모 - 도형이다.
     도형 : 이름, 색깔 >> 공통자원
        원 : 반지름, 넓이공식 >> 본인만의 특징 , 한 점 >> 부품정보(한 점은 x,y)
     class shape {색상, 그리다}  >> 부모
     class Point {좌표값}  >> 부품 >> 포함관계

     class Circle : Shape{ }    


     */

    class Shape
    {
        // 공통 속성, 함수
        public string color = "gold";
        public void draw()
        {
            Console.WriteLine("도형을 그리다.");
        }
        

    }
    class Point
    {
        private int x, y;

        

        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void showPoint()
        {
            Console.WriteLine("도형의 좌표 : {0} , {1}", X, Y);
        }
    }

    //원의 정의 : 원은 한점과 반지름을 가지고 있다.
    //1. 원은 도형이다.
    //2. 원은 점을 가지고 있다.
    //3. 원은 반지름을 가지고 있다.(특수성)
    //3.1 원의 반지금은 초기값 10을 가지고 있다.
    //3.2 점의 좌표는 초기값 10,15
    //3.3 

    class Circle : Shape
    {
        Point pCir;
        int radius;
        public Circle()
        {
            pCir = new Point(10, 15);
            radius = 10;
        }
        public Circle(Point point, int rad) //주의!!
        {
            this.pCir = point;
            this.radius = rad;
        }

        public void circlePrint()
        {
            pCir.showPoint();
            Console.WriteLine("반지름 : {0}", this.radius);
        }
    }

    //문제2)
    //삼각형 클래스를 만드세요
    //삼각형의 정의는 3개의 점과 색상과 draw 기능을 가지고 있다.
    //Shape, Point 클래스는 제공을 받는다.
    //default 값으로 삼각형을 그릴 수 있고 3개의 좌표값 모두를 입력받아서 삼각형을 그릴 수 있다.
    class Triangle : Shape
    {
        Point[] pointS;
        
        public Triangle()
        {
            pointS = new Point[3];
            
        }
        public Triangle(Point[] point) //주의!!
        {
            this.pointS = new Point[3] { new Point(1,2), new Point(3, 4), new Point(5, 6) } ;
        }

        public void squarePrint()
        {
            for (int i = 0; i < 3; i++)
            {
                pointS[i].showPoint();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.draw();
            circle.circlePrint();
            //Point point = new Point(6, 9);
            Circle circle2 = new Circle(new Point(3,5), 5);
            circle2.draw();
            circle2.circlePrint();

            Triangle t = new Triangle();
            Point[] pointarr = new Point[] { new Point(10,20), new Point(30, 40), new Point(50, 60), };
            t.draw();
            t.squarePrint();
            Triangle t2 = new Triangle(pointarr);
        }
    }
}
