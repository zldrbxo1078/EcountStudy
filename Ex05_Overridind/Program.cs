using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Overridind
{
    /*
        [상속관계]에서 override
        상속관계에서 자식클래스가 부모클래스의 method 내용만 바꾼다.
        재정의 : 틀의 변화는 없고 내용만 수정한다.
        1. 이름 동일
        2. parameter 동일
        3. return type 형식 동일
    
        new(안써도 상관은 없다), virtual, override
        new를 쓰나안쓰나 위의걸 무시한다. 하지만 new 사용 시 상속된 함수 및 변수가 상속되었다는 것을 표시할 수 있다.
        virtual
            상속되면 재정의 해줬으면 좋겠다. (강한 의지)
        override
            재정의
    */
    public class BassC
    {
        public int x = 100;
        public void Invoke()
        {
            Console.WriteLine("부모함수");
        }
    }
    public class DerivedC : BassC
    {
        new public int x = 111;
        new public void Invoke()
        {
            Console.WriteLine("자식함수");
        }
    }

    public class Father
    {
        public int Fmoney = 1000;
        public void Fprint()
        {
            Console.WriteLine($"Fmoney : {Fmoney}");
        }
        public virtual void Vprint()    //자식이 Vprint 함수를 재정의 해줬으면 좋겠다.
        {
            Console.WriteLine("부모함수 Vprint");
        }
        
    }

    class Child : Father
    {
        public override void Vprint() {

            Console.WriteLine("자식함수 Vprint");
        }
        public void fathervprint()
        {
            base.Vprint();  //부모의 함수를 호출 할 수 있는 유일한 방법 = java.super
        }
    }
    //간단한 문제
    class Point2    //한 점을 가지는 클래스
    {
        public int x = 4;
        public int y = 5;

        public virtual string getPosition()
        {
            return this.x + ":" + this.y;
        }
    }

    class Point3D : Point2
    {
        int z = 6;

        public override string getPosition()    
        {
            //return this.x + ":" + this.y+":" + this.z;  //안좋은 방법(특히 상속관계에서)
            return this.x + ":" + this.y + ":" + this.z;

        }
    }

    //private이 아닌 부모타입의 변수, 함수에 접근할 수 있다.
    //재정의 할 시 부모함수 호출 불가
    class Program
    {
        static void Main(string[] args)
        {
            DerivedC derivedc = new DerivedC();
            derivedc.Invoke();
            Console.WriteLine(derivedc.x);

            Child child = new Child();
            child.Fprint();
            child.Vprint();

            Father c = child;    //자식이 가지고 있는 주소를 부모타입 변수에 할당(상속관계여야 한다.)
            c.Fprint();
            c.Vprint(); //부모 type으로 접근하더라도 재정의가 되어있다면 자식쪽으로 넘겨버린다.

        }
    }
}
