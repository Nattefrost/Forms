using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class Form
    {
        public Form()
        {
            Questions = new Dictionary<int,QuestionBase>();
            Answers = new Dictionary<string, FormAnswer>();
        }
        public IReadOnlyDictionary<int,QuestionBase> Questions { get; private set; }
        public string Title { get; set; }
        public Dictionary<string,FormAnswer> Answers {get;private set;}
        public FormAnswer FindOrCreateAnswer(string userName)
        {
            if (Answers.ContainsKey(userName)) return Answers[userName];
            return new FormAnswer(this, userName);
        }
    }

}
