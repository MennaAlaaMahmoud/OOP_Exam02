using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam02
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, int answerCapacity) : base(header, body, mark, answerCapacity)
        {

        }

        public override void Show()
        {
            base.Show();
        }


    }
}
