﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class QuestionRoot : QuestionBase
    {
        public QuestionRoot(Form f):base(null)
        {
            Document = f;
        }
        public Form Document { get; private set; }
        public new QuestionBase Parent => null;
        public bool Contains(QuestionBase q) => Children.Contains(q);
        
    }
}
