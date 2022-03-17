using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Event_Delegate
{
    delegate void onClick(string what); //델리게이트 타입(void, parameter(string))

    class TestDel
        {
            public void MouseClick(string what)
            {
                Console.WriteLine("마우스의 {0} 버튼이 클릭되었습니다.", what);
            }
            public void KeyBoardClick(string what)
            {
                Console.WriteLine("키보드의 {0} 자판이 클릭되었습니다.", what);
            }

        }
    class Program
    {
        public event onClick myClick;
        static void Main(string[] args)
        {
            TestDel td = new TestDel();
            Program m = new Program();
            m.myClick += new onClick(td.MouseClick);

            m.myClick += new onClick(td.KeyBoardClick);

            m.myClick("왼쪽");

        }
    }
}
    
