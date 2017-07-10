using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class QuestionBase
    {
        public QuestionBase()
        {
            Children = new List<QuestionBase>();
        }
        internal Form Form { get; set; }
        public int Index { get; set; }
        public string Text { get; set; }
        public bool AllowEmptyAnswers { get; set; }
        public List<QuestionBase> Children { get; private set; }
        public QuestionBase AddNewQuestion(Type t, bool param)
        {
            Type a = Type.GetType(t, param);
            Object o = (Activator.CreateInstance(a));
            return o;
        }
        public QuestionBase AddNewQuestion(string t, bool param)
        {
            Type a = Type.GetType(t, param);
            Object o = (Activator.CreateInstance(a));
            return o;
        }
    }
}
