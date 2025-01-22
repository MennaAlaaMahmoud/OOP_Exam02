using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Exam02
{
    internal class PracticalExam : Exam
    #region Test
    {
        //public PracticalExam(int time, int numQuestions) : base(time, numQuestions)
        //{
        //}

        //public override void ShowExam()
        //{
        //    foreach (var question in Questions)
        //    {
        //        if (question != null)
        //        {
        //            // Console.WriteLine($"Question: {question.Header}");
        //            Console.WriteLine($"Question: {question.Header} (Mark: {question.Mark})");
        //            Console.WriteLine(question.Body);
        //            foreach (var answer in question.Answers)
        //            {
        //                if (answer != null)
        //                {
        //                    Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
        //                }
        //            }
        //           // Console.WriteLine($"Mark: {question.Mark}");
        //        }
        //    }

        //    Console.WriteLine("Correct Answers:");
        //    foreach (var question in Questions)
        //    {
        //        if (question != null)
        //        {
        //            Console.WriteLine($"{question.Header}: {question.CorrectAnswer.AnswerText}");
        //        }
        //    }

        //}

        #endregion
        public PracticalExam(int time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            int totalMarks = 0;

         
            foreach (var question in Questions)
            {
                if (question != null)
                {
                   
                    Console.WriteLine($"Question: {question.Header} (Mark: {question.Mark})");
                    Console.WriteLine(question.Body);
                    foreach (var answer in question.Answers)
                    {
                        if (answer != null)
                        {
                            Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
                        }
                    }

                  
                    Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}");

                    // marks to total
                    totalMarks += question.Mark;
                }
            }

          
            Console.WriteLine($"\nTotal Marks: {totalMarks}");

           
            Console.WriteLine("\nPractical Exam with Correct Answers:");
            foreach (var question in Questions)
            {
                if (question != null)
                {
                    Console.WriteLine($"Question: {question.Header} (Mark: {question.Mark})");
                    Console.WriteLine($"Body: {question.Body}");
                    Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}");
                }
            }

    }

    }
}
