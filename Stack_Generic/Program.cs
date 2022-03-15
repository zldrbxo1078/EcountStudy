using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Generic
{
    //GStack<string>    T>> string
    //
    class GStack<T>
    {

        T[] items; //저장 구조(타입)
        int stackpointer = 0; // 정적 배열의 위치 정보를 저장 [0][1][2][3][4]
        readonly int s_size;

        public GStack() : this(100)
        {

        }
        public GStack(int size)
        {
            this.s_size = size;
            this.items = new T[this.s_size]; //저장소 생성   size 가 3이면 [0][1][2]
        }

        public void Push(T item)
        {
            //..
            if (stackpointer >= s_size)
            {
                throw new InvalidOperationException("stack Full");
            }
            items[stackpointer] = item;
            stackpointer++; //이동
        }

        public T Pop()
        {
            stackpointer--;
            if (stackpointer >= 0)
            {
                return items[stackpointer];
            }
            else
            {
                stackpointer = 0;  //포인터 초기화
                throw new InvalidOperationException("stack empty");
            }


        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Stack 클래스 C#  API 제공 해주는 자원
            //내부적인 구현방법 이해 ....
            Stack stack = new Stack();  //C# API
            GStack<int> stack2 = new GStack<int>(); //개발자가 직접 생산한 Stack
            // Stack 동일하게 push() , pop()



            GStack<int> s = new GStack<int>(3);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            // s.Push(50);

            int number = s.Pop();  //[object][object][object] 
            Console.WriteLine(number);   //다운 캐스팅 ....
            int number2 = s.Pop();
            Console.WriteLine(number2);
            int number3 = s.Pop();
            Console.WriteLine(number3);

        }
    }
}
