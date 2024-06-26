using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    internal class FinalExam : Exam
    {
        #region Constructor
        
        //Ctor to initialize Final Exam
        public FinalExam(int _TimeOfExam, int _NumberOfQuestions)
        {
            TimeOfExam = _TimeOfExam;
            NumberOfQuestions = _NumberOfQuestions;
            CreateExam(_NumberOfQuestions);
        }
        #endregion

        #region Common Variables For Final Exam
        
        List<string> MyAnswer = new List<string>();
        bool Flag;
        int Answer, TotalGrade = 0, MyGrade = 0;

        #endregion

        #region Methods 
        // to Create Final Exam Consist From Num Of Questions
        public override void CreateExam(int NumberOfQuestions)
        {
            bool Flag;
            int TypeOfQuestion;
            QuestionList = new List<Question>();
            for (int i = 1; i <= NumberOfQuestions; i++)
            {
                #region Input to Know The Type of Question

                do
                {
                    Console.Write($"Plz Enter Type Of Question Number ({i}) ( 1 For True|False Question  and  2 For MCQ Question): ");
                    Flag = int.TryParse(Console.ReadLine(), out TypeOfQuestion);

                } while (!Flag || (TypeOfQuestion != 1 && TypeOfQuestion != 2));

                #endregion

                Console.Clear();


                #region Create MCQ Question
                //MCQ
                if (TypeOfQuestion == 2)
                {
                    McqQuestion mcqQuestion = new McqQuestion();
                    mcqQuestion.CreateMcqQuestion();
                    QuestionList.Add(mcqQuestion);
                    Console.Clear();
                }
                #endregion


                #region Create True False Question
                //T|F
                if (TypeOfQuestion == 1)
                {
                    TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion();
                    trueFalseQuestion.CreateTrueFalseQuestion();
                    QuestionList.Add(trueFalseQuestion);
                    Console.Clear();
                }

                #endregion

            }
        }



        //To Show Answer Of Final Exam
        public override void ExamAnswer()
        {
            Console.WriteLine($"Your Final Exam Answers:");
            for (int i = 0; i < QuestionList.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}. {QuestionList[i].Body}\t:{MyAnswer[i]}");
            };
            Console.WriteLine($"\nYour Exam Grade is  {MyGrade} From {TotalGrade} ");
        }


        // method to Show Question Of exam To Solve it
        public override void ShowExam()
        {

            Console.WriteLine($"************************************* Final Exam *****************************************");
            Console.WriteLine($"***************************** For {AssociatedSubject.SubjectName}            Time: {TimeOfExam} min ******************************\n");

            for (int i = 0; i < QuestionList.Count; i++)
            {
                Console.WriteLine($"{QuestionList[i].Header}             Mark ({QuestionList[i].Mark})");
                Console.WriteLine($"{QuestionList[i].Body}");

                for (int j = 0; j < QuestionList[i].AnswerList.Length; j++)
                {
                    Console.WriteLine($"{QuestionList[i].AnswerList[j].AnswerId}. {QuestionList[i].AnswerList[j].AnswerText}                      ");
                }
                Console.WriteLine("----------------------------------");

                do
                {
                    Console.Write("Plz Enter right Answer: ");
                    Flag = int.TryParse(Console.ReadLine(), out Answer);
                } while (!Flag || (Answer != 1 && Answer != 2 && Answer != 3));

                TotalGrade += QuestionList[i].Mark;

                if (Answer == QuestionList[i].RightAnswer.AnswerId)
                {
                    MyGrade += QuestionList[i].Mark;
                }

                for (int j = 0; j < QuestionList[i].AnswerList.Length; j++)
                {
                    if (QuestionList[i].AnswerList[j].AnswerId == Answer)
                        MyAnswer.Add(QuestionList[i].AnswerList[j].AnswerText);
                }


                Console.WriteLine("\n=====================================");

            }

            Console.Clear();
            ExamAnswer();

        } 

        #endregion
    }
}
