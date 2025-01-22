using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam02
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumQuestions { get; set; }
        public Question[] Questions { get; set; }

        private int QuestionCount; // هستخدمها جوا الكلاس نفسه 

       public Exam(int time, int numQuestions)
        {
            Time = time;
            NumQuestions = numQuestions;
            Questions = new Question[numQuestions];
            QuestionCount = 0;
        }
        public void AddQuestion(Question question)
        {
            if (QuestionCount < Questions.Length)
            {
                Questions[QuestionCount++] = question;
            }
            else
            {
                Console.WriteLine("Cannot add more questions, capacity reached.");
            }
        }

        public abstract void ShowExam();
    }
}
