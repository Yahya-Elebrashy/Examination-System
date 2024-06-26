using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    internal class Subject
    {
        #region Property

        public int SubjectId { get; }
        private string subjectName;

        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value ?? throw new Exception("Subject Name Musn't Null") ; }
        }

        public Exam? Exam { get; set; }

        #endregion

        #region Constructor
        public Subject(int _SubjectId, string _SubjectName)
        {
            SubjectId = _SubjectId;
            subjectName = _SubjectName ?? $"Subject Of Subject Id {_SubjectId}";
        }

        #endregion

        // method for create Exam For the Subject
        public void CreateExam()
        {
            #region Common Input Question of any Exam
            bool Flag;
            int Type, NumOfQuestions;
            int Minutes;
            do
            {
                Console.Write("Plz Enter Type Of Exam U Want To Create ( 1 For Practical Exam and 2 For Final Exam): ");
                Flag = int.TryParse(Console.ReadLine(), out Type);

            } while (!Flag || (Type != 1 && Type != 2));

            do
            {
                Console.Write("Plz Enter Time Of Exam In Minutes: ");
                Flag = int.TryParse(Console.ReadLine(), out Minutes);

            } while (!Flag || Minutes <= 0);


            do
            {
                Console.Write("Plz Enter Number Of Questions U Want To Create: ");
                Flag = int.TryParse(Console.ReadLine(), out NumOfQuestions);

            } while (!Flag || NumOfQuestions <= 0);

            Console.Clear();

            #endregion

            //Practical Exam
            if (Type == 1)
            {
                Exam = new PracticalExam(Minutes, NumOfQuestions);
                Exam.AssociatedSubject = this;
                
            }

            //Final Exam
            else if (Type == 2)
            {
                Exam = new FinalExam(Minutes, NumOfQuestions);
                Exam.AssociatedSubject = this;

            }

        }


        // method for Show Exam For the Subject
        public void ShowExam()
        {
            Exam?.ShowExam();
        }
        
    }
}
