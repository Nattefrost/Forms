using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    internal class QuestionRoot : QuestionBase
    {
        public QuestionRoot()
        {
            Questions = new Dictionary<int, QuestionBase>();
        }
        public IReadOnlyDictionary<int, QuestionBase> Questions { get; private set; }
        public string Title { get; set; }

    }
}
