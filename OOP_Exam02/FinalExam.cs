using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam02
{
    internal class FinalExam : Exam
    {
        #region Test
        //public FinalExam(int time, int numQuestions) : base(time, numQuestions)
        //{
        //}

        //public override void ShowExam()
        //{
        //    int totalMarks = 0;

        //    foreach (var question in Questions)
        //    {
        //        if (question != null)
        //        {
        //            //Console.WriteLine($"Question: {question.Header}");
        //            //Console.WriteLine(question.Body);

        //            Console.WriteLine($"Question: {question.Header} (Mark: {question.Mark})");
        //            Console.WriteLine(question.Body);
        //            foreach (var answer in question.Answers)
        //            {
        //                if (answer != null)
        //                {
        //                    Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");

        //                    totalMarks += question.Mark;
        //                }
        //            }
        //            // Console.WriteLine($"Mark: {question.Mark}");

        //            Console.WriteLine($"\nTotal Marks: {totalMarks}");

        //            foreach (var question in Questions)
        //            {
        //                if (question != null)
        //                {
        //                    Console.WriteLine($"Question: {question.Header} (Mark: {question.Mark})");
        //                    Console.WriteLine($"Body: {question.Body}");
        //                    Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}");
        //                }
        //            }

        //        }

        #endregion
        public FinalExam(int time, int numQuestions) : base(time, numQuestions) { }

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

                    //  marks to total
                    totalMarks += question.Mark;
                }
            }

         
            Console.WriteLine($"\nTotal Marks: {totalMarks}");

          
            Console.WriteLine("\nFinal Exam with Correct Answers:");
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
