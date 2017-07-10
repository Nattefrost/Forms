using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    public class QuestionBase
    {
        internal Form Form { get; set; }
        public string Text { get; set; }
        public bool AllowEmptyAnswers { get; set; }
    }
}
