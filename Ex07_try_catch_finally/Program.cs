using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new IndexOutOfRangeException("배열 문제");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine("***" + e.StackTrace);
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Power off");
            }
        }
    }
}
