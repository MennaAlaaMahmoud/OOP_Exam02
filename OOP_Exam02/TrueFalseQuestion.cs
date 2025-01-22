using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam02
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark) : base(header, body, mark, 2)
        {
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }
        public override void Show()
        {
            Console.WriteLine($"Q: {Header} - {Body}");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }

        public bool CheckAnswer(int userAnswer)
        {
            return (userAnswer == 1 && CorrectAnswer.AnswerText == "True") || (userAnswer == 2 && CorrectAnswer.AnswerText == "False");
        }


    }
}
