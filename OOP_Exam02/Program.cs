using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System;

namespace OOP_Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test
            //try
            //{
            //    Console.WriteLine("Select Exam Type ( *_* 1. Final, *_* 2. Practical):");
            //    if (!int.TryParse(Console.ReadLine(), out int examType))  
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        return;
            //    }

            //    Console.WriteLine("Enter Exam Duration in Minutes:");
            //    if (!int.TryParse(Console.ReadLine(), out int duration)) 
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        return;
            //    }

            //    Console.WriteLine("Enter Number of Questions:");
            //    if (!int.TryParse(Console.ReadLine(), out int numQuestions))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        return;
            //    }

            //    Subject subject = new Subject(1, "Mathematics");
            //    Exam exam;

            //    if (examType == 1)
            //    {
            //        exam = new FinalExam(duration, numQuestions);
            //    }
            //    else if (examType == 2)
            //    {
            //        exam = new PracticalExam(duration, numQuestions);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid exam type selected.");
            //        return;
            //    }

            //    for (int i = 0; i < numQuestions; i++)
            //    {
            //        Console.WriteLine($"Enter details for Question {i + 1}:");
            //        Console.WriteLine("Enter Header:");
            //        string header = Console.ReadLine(); 
            //        Console.WriteLine("Enter Body:");
            //        string body = Console.ReadLine();
            //        Console.WriteLine("Enter Mark:");

            //        //if (!int.TryParse(Console.ReadLine(), out int mark))
            //        //{
            //        //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //        //    return;
            //        //}

            //        int mark = (examType == 1) ? 1 : 2; // الامتحان النظري درجة و الامتحان العملي درجتين

            //        Console.WriteLine("Enter Number of Answers:");
            //        if (!int.TryParse(Console.ReadLine(), out int answerCapacity))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //            return;
            //        }

            //        Question question = (examType == 1 && i == 0) ? new TrueFalseQuestion(header, body, mark) : new MCQQuestion(header, body, mark, answerCapacity);

            //        for (int j = 0; j < answerCapacity; j++)
            //        {
            //            Console.WriteLine($"Enter Answer {j + 1} Id:");
            //            if (!int.TryParse(Console.ReadLine(), out int answerId))
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid number.");
            //                return;
            //            }

            //            Console.WriteLine($"Enter Answer {j + 1} Text:");
            //            string answerText = Console.ReadLine();
            //            question.AddAnswer(new Answer(answerId, answerText));
            //        }

            //        Console.WriteLine("Enter Correct Answer Id:");
            //        if (!int.TryParse(Console.ReadLine(), out int correctAnswerId) || correctAnswerId < 1 || correctAnswerId > answerCapacity)
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number within the range of answers.");
            //            return;
            //        }

            //        question.SetCorrectAnswer(question.Answers[correctAnswerId - 1]);

            //        exam.AddQuestion(question);
            //    }

            //    subject.CreateExam(exam);
            //    Console.Clear();
            //    Console.WriteLine(subject);
            //    subject.Exam.ShowExam();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //} 
            #endregion

            try
            {
                int examType, time, numberOfQuestions;
                Exam exam = null;


                Console.WriteLine("Select Exam Type (1. Final , 2. Practical) *_*");
                if (!int.TryParse(Console.ReadLine(), out examType))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                Console.WriteLine("Enter Exam Duration in Minutes:");
                // عشان المستخدم يختار المده زاي دقيقه او اتنين
                if (!int.TryParse(Console.ReadLine(), out time)|| time <= 0) 
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                // ادخال عدد الاسئلة
                Console.WriteLine("Enter Number of Questions:");
                if (!int.TryParse(Console.ReadLine(), out int numQuestions) || numQuestions <= 0 )
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                Console.Clear();

                Subject subject = new Subject(1, "Mathematics");
                //  Exam exam;
                // إنشاء الامتحان بناءً على الاختيار

                if (examType == 1)
                {
                    exam = new FinalExam(time, numQuestions);
                }
                else if (examType == 2)
                {
                    exam = new PracticalExam(time, numQuestions);
                }
                else
                {
                    Console.WriteLine("Invalid exam type selected.");
                    return;
                }

                for (int i = 0; i < numQuestions; i++)
                {
                    Console.WriteLine($"Enter details for Question {i + 1}:");

                    // إدخال عنوان السؤال
                    Console.WriteLine("Enter Header:");
                    string header = Console.ReadLine();

                    // إدخال نص السؤال
                    Console.WriteLine("Enter Body:");
                    string body = Console.ReadLine();

                   
                    int mark = (examType == 1) ? 1 : 2; // Final Exam (1 mark), Practical Exam (2 marks)

                    Console.WriteLine("Enter Number of Answers:");
                    if (!int.TryParse(Console.ReadLine(), out int answerCapacity))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }

                    // Create the question with the specified mark
                    Question question = (examType == 1 && i == 0) ? new TrueFalseQuestion(header, body, mark) : new MCQQuestion(header, body, mark, answerCapacity);

                    for (int j = 0; j < answerCapacity; j++)
                    {
                        Console.WriteLine($"Enter Answer {j + 1} Id:");
                        if (!int.TryParse(Console.ReadLine(), out int answerId))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            return;
                        }

                        Console.WriteLine($"Enter Answer {j + 1} Text:");
                        string answerText = Console.ReadLine();
                        question.AddAnswer(new Answer(answerId, answerText));
                    }

                    Console.WriteLine("Enter Correct Answer Id:");
                    if (!int.TryParse(Console.ReadLine(), out int correctAnswerId) || correctAnswerId < 1 || correctAnswerId > answerCapacity)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number within the range of answers.");
                        return;
                    }

                    question.SetCorrectAnswer(question.Answers[correctAnswerId - 1]);

                    exam.AddQuestion(question);
                }

                Console.Clear();

                // بداية توقيت الامتحان
                DateTime startTime = DateTime.Now;
                Console.WriteLine($"Exam started at: {startTime:HH:mm:ss}");

                // exam.ShowExam();  // يمكن تركها لعرض الأسئلة أثناء الامتحان

                // نهاية توقيت الامتحان
                DateTime endTime = DateTime.Now;
                Console.WriteLine($"Exam ended at: {endTime:HH:mm:ss}");

                // حساب الوقت المستغرق
                TimeSpan timeTaken = endTime - startTime;
                Console.WriteLine("\nExam Finished!");
                Console.WriteLine($"Time Taken: {timeTaken.Minutes} minutes and {timeTaken.Seconds} seconds");


                subject.CreateExam(exam);
                Console.Clear();
                Console.WriteLine(subject);
                subject.Exam.ShowExam();
               // DateTime startTime = DateTime.Now;
               // exam.ShowExam();  // يمكن تركها لعرض الأسئلة أثناء الامتحان
               // DateTime endTime = DateTime.Now;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


            // test 

          // Subject ID: 1, Name: Mathematics
          //Question: 2 + 2 ? (Mark: 1)
          //4
          //1: 1
           //Correct Answer: 1

          //Total Marks: 1

          //Final Exam with Correct Answers:
           //  Question: 2 + 2 ? (Mark: 1)
           //  Body: 4
           //Correct Answer: 1




        }
    }
}
