using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    public class Form
    {
        public Form()
        {
            Questions = new List<QuestionBase>();
        }
        public IReadOnlyList<QuestionBase> Questions {get;private set;}
    }

}
