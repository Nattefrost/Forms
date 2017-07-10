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
            Answers = new Dictionary<string, FormAnswer>();
            Root = new QuestionRoot();
        }
        private QuestionRoot Root { get; set; }
        public string Title
        {
            get { return Root.Title; }
            set { Root.Title = value; }
        }
        public IReadOnlyDictionary<int, QuestionBase> Questions => Root.Questions;
        public Dictionary<string,FormAnswer> Answers {get;private set;}
        public FormAnswer FindOrCreateAnswer(string userName)
        {
            if (Answers.ContainsKey(userName)) return Answers[userName];
            return new FormAnswer(this, userName);
        }
    }

}
