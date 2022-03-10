using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Property
{
    class BirthdayInfo
    {
        //생성자가 없지만 만든 property를 통해 초기화가 가능하다.
        public string Name
        {
            get;
            set;
        }   
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "홍길동",
                Birthday = new DateTime(1650, 2, 12)
            };

            Console.WriteLine("Name: {0}", birth.Name);
            Console.WriteLine("Birthday: {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age: {0}", birth.Age);
        }
    }
}
