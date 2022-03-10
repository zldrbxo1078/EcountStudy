using Ex05_override;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_override
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
        public int x=100;
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
        public override void Vprint()
        {
            base.Vprint();
        }
    }


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
        }
    }
}
   




