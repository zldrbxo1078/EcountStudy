using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            List<string> list2 = new List<string>();

            Stack stack = new Stack();
            stack.Push("aaa");
            stack.Push("bbb");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            Queue<string> q2 = new Queue<string>();

            Hashtable ht = new Hashtable();
            ht.Add("a", "ㅇㄴㄹ");
            ht.Add("b", "ㅇㄴㄹ");
            ht.Add("c", "dsgs");
            Console.WriteLine(ht.ContainsKey("c")); //key 가 있나 확인

            ICollection ic = ht.Keys;
            foreach (string key in ic)
            {
                Console.WriteLine(key);
            }
            foreach(DictionaryEntry item in ht)
            {

            }
            //List<>
            //Dictionary
            SortedList so = new SortedList();
            so.Add(10, "F");
            so.Add(3, "D");
            so.Add(31, "K");
            so.Add(1, "A");
            Console.WriteLine(so.GetKey(0));
            Console.WriteLine(so.IndexOfValue("D"));

            IList solist = so.GetKeyList();
            foreach (int item in solist)
            {
                Console.WriteLine(item);
            }
            solist = so.GetValueList();
            foreach (string item in solist)
            {
                Console.WriteLine(item);
            }
            /*
            1.ArraylList    >> List<T>
            2. Stack        >> Stack<T> 
            3. Queue        >> Queue<T>
            4. HashTable    >> HashTable<T>
            5. SortedList   >> SortedList<T,V>
            6.linkedList    
             */

        }
    }
}
