using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class QuestionBase
    {
        public QuestionBase()
        {
            SubQuestions = new List<QuestionBase>();
        }
        internal Form Form { get; set; }
        public string Text { get; set; }
        public bool AllowEmptyAnswers { get; set; }
        public List<QuestionBase> SubQuestions { get; private set; }
    }
}
