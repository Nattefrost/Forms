using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class FormAnswer
    {
        public FormAnswer(Form f, string userName)
        {
            this.UniqueName = userName;
            this.Form = f;
            f.Answers.Add(userName,this);
        }
        public string UniqueName { get; private set; }
        public Form Form { get;private set;}
    }
}
