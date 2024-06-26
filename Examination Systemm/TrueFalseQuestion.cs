using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    internal class TrueFalseQuestion : Question
    {
        
        #region Constructor

        public TrueFalseQuestion() 
        {
            Header = "true|False Question";
        }

        #endregion


        // Create Question From Type T|F
        public void CreateTrueFalseQuestion()
        {
            #region Variables
            bool Flag;
            int _Mark, Answer;
            #endregion

            #region Body Of Method of T|F Question
            
            Console.WriteLine(this.Header);

            do
            {
                Console.WriteLine("-Plz Enter Body Of Question");
                this.Body = Console.ReadLine() ?? "";
            } while (this.Body == "");


            do
            {
                Console.WriteLine("-Plz Enter Mark Of Question");
                Flag = int.TryParse(Console.ReadLine(), out _Mark);
            } while (!Flag || _Mark <= 0);
            this.Mark = _Mark;


            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");


            do
            {
                Console.WriteLine($"-Plz Enter The Right Answer For Question ( 1 For True  and  2 For False ) ");
                Flag = int.TryParse(Console.ReadLine(), out Answer);

            } while (!Flag || (Answer != 1 && Answer != 2));


            if (Answer == 1)
                RightAnswer = AnswerList[0];
            else
                RightAnswer = AnswerList[1];

            #endregion

            
        }
    }
}
