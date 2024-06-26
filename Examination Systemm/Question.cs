using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    abstract class Question
    {
        public string Header { get; set;}

        public string Body { get; set; }

        public int Mark { get; set; }

        public Answer[] AnswerList ;

        public Answer RightAnswer { get; set; }



    }
}
