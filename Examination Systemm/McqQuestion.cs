using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    internal class McqQuestion : Question
    {
        #region Constructors
        public McqQuestion()
        {
            Header = "MCQ Choose (One Answer) Question";
        }
        

        #endregion


        // method for create question from type MCQ
        public void CreateMcqQuestion()
        {

            #region Body Of method that Create mcq question
            
            Console.WriteLine(this.Header);


            do
            {
                Console.WriteLine("-Plz Enter Body Of Question");
                 this.Body = Console.ReadLine()??"";
            } while (this.Body == "");



            bool Flag;
            int _Mark, Answer;
            do
            {
                Console.WriteLine("-Plz Enter Mark Of Question");
                Flag = int.TryParse(Console.ReadLine(), out _Mark);
            } while (!Flag || _Mark <= 0);
            this.Mark = _Mark;


            AnswerList = new Answer[3];
            Console.WriteLine("-Plz Enter Choices Of Questions");

            string Choice;
            for (int j = 1; j <= 3; j++)
            {
                do
                {
                    Console.WriteLine($"--Choice Number ({j}): ");
                    Choice = Console.ReadLine() ?? "";
                } while (Choice == "");
                AnswerList[j-1] = new Answer(j, Choice);
            }


            do
            {
                Console.WriteLine($"-Plz Specify The Right Number of Choice of Question");
                Flag = int.TryParse(Console.ReadLine(), out Answer);

            } while (!Flag || (Answer != 1 && Answer != 2 && Answer != 3));

            if (Answer == 1)
                RightAnswer = AnswerList[0];
            else if (Answer == 2)
                RightAnswer = AnswerList[1];
            else
                RightAnswer = AnswerList[2];
           
            #endregion


        }

    }
}
