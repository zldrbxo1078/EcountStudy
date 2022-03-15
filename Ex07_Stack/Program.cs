using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex07_Stack
{
    class MyStack
    {
        private object[] items;
        private int top;

        public object[] Items { get => items; }
        public int Top { get => top; }

        public MyStack() :this(10)
        {
        }
        public MyStack(int size)
        {
            items = new object[size];
            top = 0;
        }
        public void Push(object item)
        {
            if (top < items.Length)
            {
                items[top] = item;
                ++top;
            }
            else
            {
                Console.WriteLine("Stack is Full");
            }
        }

        public object Pop()
        {
            object val;
            if (top > 0)
            {
                
                val = items[top--];
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                val = default;
            }
            return val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            MyStack stack2 = new MyStack();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
            for (int i = 0; i < stack2.Top; i++)
            {
                Console.WriteLine(stack2.Items[i]);
            }
            int num = (int)stack2.Pop();
            Console.WriteLine(num);
            int num2 = (int)stack2.Pop();
            Console.WriteLine(num2);
            int num3 = (int)stack2.Pop();
            Console.WriteLine(num3);
            stack2.Pop();
            stack2.Pop();



        }
    }
}
