using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class Form
    {
        public Form()
        {
            Answers = new Dictionary<string, FormAnswer>();
            Questions = new QuestionRoot(this);
        }
        public string Title
        {
            get { return Questions.Title; }
            set { Questions.Title = value; }
        }
        public QuestionRoot Questions { get; private set; }
        public Dictionary<string, FormAnswer> Answers { get; private set; }
        public FormAnswer FindOrCreateAnswer( string userName )
        {
            if( Answers.ContainsKey( userName ) ) return Answers[userName];
            return new FormAnswer( this, userName );
        }

    }

}
