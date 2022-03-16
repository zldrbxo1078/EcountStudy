using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Object_Array
{
    //class 생성
    class Ani
    {
        private string dogname;
        public Ani() { }
        public Ani(string dogname)
        {
            this.dogname = dogname;
        }
        public void aniDisplay()
        {
            Console.WriteLine("개이름 : {0}", this.dogname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //Ani[] anis = new Ani[3];    //heap 메모리에 방만 3개 만든 것! 
            ////각각의 방에 값을 넣어야 한다. >> 각각의 방에 Ani 타입을 갖는 주소를 넣는다.
            //Ani a = new Ani("모카");
            //Ani a2 = new Ani("마루");
            //Ani a3 = new Ani("구름");

            //anis[0] = a;    //주소값 전달
            //anis[1] = a2;
            //anis[2] = a3;

            //anis[0].aniDisplay();
            //anis[1].aniDisplay();
            //anis[2].aniDisplay();

            //방법2
            Ani[] anis = new Ani[3];
            anis[0] = new Ani("모카");
            anis[0] = new Ani("마루");
            anis[0] = new Ani("구름");

            //방법3 !!
            Ani[] arr2 = new Ani[] { new Ani("모카"), new Ani("마루"), new Ani("구름") };

            //방법4 << 기억해두자! 가장 많이 활용
            Ani[] arr3 = { new Ani("모카"), new Ani("마루"), new Ani("구름") };
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i].aniDisplay();
            }
            Console.WriteLine("foreach");
            foreach (Ani item in arr3)  //item이 객체니까 Ani 타입으로 받아야한다.
            {
                item.aniDisplay();
            }
        }
    }
}
