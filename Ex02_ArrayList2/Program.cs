﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_ArrayList2
{
    class Program
    {
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumps");

            // Displays the count, capacity and values of the ArrayList.
            Console.WriteLine("Initially,");
            Console.WriteLine("   Count    : {0}", myAL.Count);
            Console.WriteLine("   Capacity : {0}", myAL.Capacity);
            Console.Write("   Values:");
            PrintValues(myAL);

            // Trim the ArrayList.
            myAL.TrimToSize();

            // Displays the count, capacity and values of the ArrayList.
            Console.WriteLine("After TrimToSize,");
            Console.WriteLine("   Count    : {0}", myAL.Count);
            Console.WriteLine("   Capacity : {0}", myAL.Capacity);
            Console.Write("   Values:");
            PrintValues(myAL);

            // Clear the ArrayList.
            myAL.Clear();

            // Displays the count, capacity and values of the ArrayList.
            Console.WriteLine("After Clear,");
            Console.WriteLine("   Count    : {0}", myAL.Count);
            Console.WriteLine("   Capacity : {0}", myAL.Capacity);
            Console.Write("   Values:");
            PrintValues(myAL);

            
        }
    }
}
