using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_Systemm
{
    abstract class Exam
    {

        public int TimeOfExam { get; set; }

        public int NumberOfQuestions { get; set; }

        public List<Question> QuestionList ;
        public Subject AssociatedSubject { get; set; }

        public abstract void CreateExam(int NumofQuestion);
        public abstract void ShowExam();
        public abstract void ExamAnswer();
    }
}
