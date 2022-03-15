using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_multipulication
{
    
    class Quizinfo
    {
        private string Question { get; }
        private string Answer { get; }
        private char OX { get; }
        public Quizinfo(string question, string answer)
        {
            this.Answer = answer;
            this.Question = question;
        }

    }

    class QuizGame
    {
        private List<Quizinfo> Quizzes;
        private Dictionary<Quizinfo, int> Answers { get; }

        public QuizGame()
        {
            Quizzes = new List<Quizinfo>();
            Answers = new Dictionary<Quizinfo, int>();
        }

        public void putQuiz(string question, string answer)
        {
            this.Quizzes.Add(new Quizinfo(question, answer));
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            
            QuizGame quizgame = new QuizGame();
            quizgame.putQuiz("1+1", "2");
            quizgame.putQuiz("2+2", "4");
            quizgame.putQuiz("3+3", "6");
            quizgame.putQuiz("4+4", "8");

            foreach (var item in quizinfo.Quizzes)
            {
                Console.WriteLine(item.ToString()); 
            }


        }
    }
}
