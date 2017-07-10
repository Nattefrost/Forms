using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class QuestionRoot : QuestionBase
    {
        public string Title { get; set; }
        public new QuestionBase Parent => null;

    }
}
