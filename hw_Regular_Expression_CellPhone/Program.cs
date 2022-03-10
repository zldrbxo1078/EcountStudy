using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hw_Regular_Expression_CellPhone
{
    class PhoneNum
    {
        
        //public string phNumber { get; set; }

        public void numberCheck(string phnumber)
        {
            Regex regex = new Regex(@"^01([0-1|6-9])[ -]?([0-9]{3,4})[ -]?([0-9]{4})$");
            showresult(regex.IsMatch(phnumber));
        }
        private void showresult(bool result)
        {
                Console.WriteLine("테스트 결과 : {0}", result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneNum pnum1 = new PhoneNum();

            pnum1.numberCheck("01046305470");
            pnum1.numberCheck("011-46305470");
            pnum1.numberCheck("018-4630-5470");
            pnum1.numberCheck("019 463 5470");
            pnum1.numberCheck("013 4630 5470");
            pnum1.numberCheck("019 46305 5470");

        }
    }
}
