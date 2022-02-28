using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_basic
{
    class Car
    {

    }
    class Test 
    {
        public int data;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            char c; //2byte 0~255
            c = 'A';

            char d;
            d = '나';
            Console.WriteLine("c:{0}, d:{1}", c, d);

            //지역변수는 반드시 [초기화]를 통해서 사용한다.
            short s = 10000;
            Console.WriteLine(s);

            int i = 10000000;
            Console.WriteLine(i);

            //실수 리터럴 기본형 double
            float f = 1.12f;    //float type에 넣기 위해 f 접미사 사용
            Console.WriteLine(f);

            double dd = 1.123456789;
            Console.WriteLine(dd);

            bool b = true; //논리 타입 true false

            //value type 증명
            int aa = 100;
            Console.WriteLine(aa.GetType());
            int bb = aa;
            bb = 200;
            Console.WriteLine("aa의 값은 {0}", aa);
            Console.WriteLine(aa.GetHashCode());

            Test t = new Test();
            Console.WriteLine(t.GetHashCode());
            t.data = 100;

            //참조타입 증명
            Test t2 = t;    
            //주소값 할당- 같은 주소값을 가진다 >> 새로 인스턴스를 생성한 것이아닌 기존의 인스턴스 값 지정했기 때문에
            t2.data = 1111;
            Console.WriteLine("t객체의 data 변수값은 : {0}", t.data);
            Console.WriteLine(t == t2);
            Console.WriteLine("{0}-{1}",t.GetHashCode(),t2.GetHashCode());

        }
    }
}
