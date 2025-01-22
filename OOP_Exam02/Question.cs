using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam02
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        private int AnswerCount;

        protected Question(string header , string body , int mark , int  answerCapacity)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new Answer[answerCapacity];
            AnswerCount = 0;

        }

        public void AddAnswer(Answer answer)
        {
            if (AnswerCount < Answers.Length)
            {
                Answers[AnswerCount++] = answer;
            }
            else
            {
                Console.WriteLine("Cannot add more answers, capacity reached.");
            }
        }
        public void SetCorrectAnswer(Answer correctAnswer)
        {
            CorrectAnswer = correctAnswer;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Q: {Header} - {Body}");
            foreach (var answer in Answers)
            {
                if (answer != null)
                {
                    Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
                }
            }
        }
    }    
}
