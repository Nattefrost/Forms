using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class BooleanQuestion : QuestionBase
    {
        List<string> _possibleAnswers;
        public BooleanQuestion() : base()
        {
            _possibleAnswers = new List<string>(new string[] { "yes", "no" });
        } 
        
    }
}
