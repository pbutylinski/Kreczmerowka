using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreczmerowka
{
    public class Answer
    {
        public Answer()
        {
        }

        public Answer(int questionId, int problemId, UserChoice Odpow)
        {
            QuestionId = questionId;
            ProblemId = problemId;
            Choice = Odpow;
        }

        public int QuestionId { get; set; }
        public int ProblemId { get; set; }
        public UserChoice Choice { get; set; }
    }
}
