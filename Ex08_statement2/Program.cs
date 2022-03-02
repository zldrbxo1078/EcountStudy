using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int data = 90;
            //switch (data)
            //{
            //    case 100:
            //        Console.WriteLine(data);
            //    case 90:
            //        Console.WriteLine(data);
            //    case 80:
            //        Console.WriteLine(data);
            //    default:
            //        break;
            //} 
            //C#에서는 break 생략 불가능

            string grade;
            //int score = Int32.Parse(Console.ReadLine());
            int score = 78;
            switch (score)
            {
                case int n when (n >= 90):
                    if (n >= 95)
                    {
                        grade = "A+";
                    }
                    else if (n >= 90)
                    {
                        grade = "A";
                    }
                    else
                    {
                        grade = "A-";
                    }
                    break;
                case int n when (n >= 80):
                    grade = "A+";
                    Console.WriteLine();
                    break;
                case int n when (n >= 90):
                    grade = "A+";
                    Console.WriteLine();
                    break;
                case int n when (n >= 90):
                    grade = "A+";
                    Console.WriteLine();
                    break;
                case int n when (n >= 90):
                    grade = "A+";
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
            if (score >= 90)
            {
                grade = "A";
                grade = (score >= 95) ? (grade += "+") : (grade += "-");
            }
            else if (score >= 80)
            {
                grade = "B";
                grade = (score >= 85) ? (grade += "+") : (grade += "-");
            }
            else if (score >= 70)
            {
                grade = "C";
                grade = (score >= 75) ? (grade += "+") : (grade += "-");
            }
            else if (score >= 50)
            {
                grade = "D";
                grade = (score >= 60) ? (grade += "+") : (grade += "-");
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine(grade);
                int m = 1;
                string r = "";
                switch (m)
	        {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    r = "31";
                    break;
                case 2:
                    r = "28";
                    break;
                default:
                    r = "30";
                break;
	        }
            string str = "ABC123";

            foreach(char c in str)
            {
                Console.Write($"{c}\t");
            }
            Console.WriteLine();
        }


}
}
