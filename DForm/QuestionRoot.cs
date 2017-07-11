using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class QuestionRoot : QuestionBase
    {
        public QuestionRoot( ):base(null)
        {
          
        }
        public new QuestionBase Parent => null;
        public bool Contains(QuestionBase q)
        {
            return this.Children.Contains(q);
        }
    }
}
