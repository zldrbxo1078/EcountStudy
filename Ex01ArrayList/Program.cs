using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01ArrayList
{

    class Program
    {
        public static void PrintValues(IEnumerable myList)
        {
            IList li = (IList)myList;
            Console.WriteLine("count : {0}", li.Count);
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //collection 구현하고 있는 (상속) 대표적인 클래스
            //ArrayList 
            //동적 데이터 관리 
            //using System.Collections; 아래 있는 자원

            //ArrayList는 내부적으로 데이터를 array로 관리
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine(list.ToString());
            foreach (int to in list)
            {
                Console.WriteLine("to : {0}", to);
            }
            Console.WriteLine(list.Count);  //값이 있는 개수 >> length 와는 다르다!! length와는!
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list : [{0}]", i);

            }
            Console.WriteLine("list ArrayList");
            Console.WriteLine("Count : {0}", list.Count);       //현재 개수
            Console.WriteLine("Capacity : {0}", list.Capacity); //사용가능 용량
            



            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the ArrayList.
            Console.WriteLine("The ArrayList initially contains the following:");
            PrintValues(myAL);

            // Removes the element containing "lazy".
            myAL.Remove("lazy");

            // Displays the current state of the ArrayList.
            Console.WriteLine("After removing \"lazy\":");
            PrintValues(myAL);

            // Removes the element at index 5.
            myAL.RemoveAt(5);

            // Displays the current state of the ArrayList.
            Console.WriteLine("After removing the element at index 5:");
            PrintValues(myAL);

            // Removes three elements starting at index 4.
            myAL.RemoveRange(4, 3);

            // Displays the current state of the ArrayList.
            Console.WriteLine("After removing three elements starting at index 4:");
            PrintValues(myAL);
        }
    }
}
