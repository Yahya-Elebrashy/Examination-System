using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    internal class PracticalExam : Exam
    {
        #region Constructor
        // ctor To initialize Practical Exam
        public PracticalExam(int _TimeOfExam, int _NumberOfQuestions)
        {
            TimeOfExam = _TimeOfExam;
            NumberOfQuestions = _NumberOfQuestions;
            CreateExam(_NumberOfQuestions);
        }

        #endregion


        #region Methods
        // to Create Practical Exam Consist From Num Of Questions
        public override void CreateExam(int NumberOfQuestions)
        {
            QuestionList = new List<Question>();
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                McqQuestion mcqQuestion = new McqQuestion();
                Console.WriteLine($"Enter Question Number ({i})");
                mcqQuestion.CreateMcqQuestion();
                QuestionList.Add(mcqQuestion);
                Console.Clear();
            }
        }



        //To Show Answer Of Practical Exam
        public override void ExamAnswer()
        {
            Console.WriteLine($"The Right Answers Of Practical Exam:");
            for (int i = 0; i < QuestionList.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}. {QuestionList[i].Body}\t:{QuestionList[i].RightAnswer.AnswerText}");
            };
            Console.WriteLine();
        }


        // method to Show Question Of exam To Solve it
        public override void ShowExam()
        {
            Console.WriteLine($"******************************* Practical Exam ****************************************");
            Console.WriteLine($"************************** For {AssociatedSubject.SubjectName}            Time: {TimeOfExam} **********************************\n");

            for (int i = 0; i < QuestionList.Count; i++)
            {
                Console.WriteLine($"{QuestionList[i].Header}             Mark ({QuestionList[i].Mark})");
                Console.WriteLine($"{QuestionList[i].Body}");

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{QuestionList[i].AnswerList[j].AnswerId}. {QuestionList[i].AnswerList[j].AnswerText}");
                }
                Console.WriteLine("----------------------------------");

                bool Flag;
                int Answer;
                do
                {
                    Console.Write("Plz Enter right Answer: ");
                    Flag = int.TryParse(Console.ReadLine(), out Answer);
                } while (!Flag || (Answer != 1 && Answer != 2 && Answer != 3));


                Console.WriteLine("\n=====================================");

            }

            Console.Clear();
            ExamAnswer();
        }

        #endregion

    }
}
