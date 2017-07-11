using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class BooleanQuestion : QuestionBase
    {
        List<string> _possibleAnswers;
        public BooleanQuestion( QuestionBase parent) : base( parent)
        {
            _possibleAnswers = new List<string>(new string[] { "yes", "no" });
        } 
        
    }
}
