using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Systemm
{
    internal class Answer 
    {
        #region Property
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion


        #region Constructors
        public Answer(int _AnswerId, string _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;
        }

        #endregion

        public override string ToString()
        {
            return $"Answer Id: {AnswerId} , Answer Text: {AnswerText} ";
        }

    }
}
