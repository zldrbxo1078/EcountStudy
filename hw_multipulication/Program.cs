using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_multipulication
{
    //class Result {
    //    public string Query { get; }
    //    public string Answer { get; set; }
    //    public string Correct { get; set; }
    //    public Result(string answer, Quizinfo quiz) {
    //        this.Answer = answer;
    //    }
    //    public override string ToString()
    //    {
    //        return "문제 : "+ Query+"쓴 답 : " + Answer + "정답 : " + Correct;
    //    }

    //}
    class Quizinfo
    {
        
        public Dictionary<string, string> Quizzes { get; }
        public Quizinfo()
        {
            Quizzes = new Dictionary<string, string>();
        }


        public void put(string quiz, string correctanswer)
        {
            this.Quizzes.Add(quiz, correctanswer);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Quizinfo quizinfo = new Quizinfo();
            quizinfo.put("1+1", "2");
            quizinfo.put("2+2", "4");
            quizinfo.put("3+3", "6");
            quizinfo.put("4+4", "8");

            foreach (var item in quizinfo.Quizzes)
            {
                Console.WriteLine(item.ToString()); 
            }


        }
    }
}
