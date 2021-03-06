﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DForm;

namespace DForm.Tests
{
    [TestFixture]
    public class QuestionTests
    {
        [Test]
        public void CreateQuestionFolders()
        {
            Form f = new Form();
            f.Questions.Title = "FORM1";
            Assert.AreEqual( "FORM1", f.Title );
            QuestionBase q1 = f.Questions.AddNewQuestion( "DForm.BooleanQuestion,DForm", true );
            QuestionBase q2 = f.Questions.AddNewQuestion( typeof( BooleanQuestion ), true );
            q1.Title = "T1";
            q2.Title = "T2";
            Assert.AreEqual( 0, q1.Index );
            Assert.AreEqual( 1, q2.Index );
            q2.Index = 0;
            Assert.AreEqual( 0, q2.Index );
            Assert.AreEqual( 1, q1.Index );
            q2.Parent = null;
            Assert.AreEqual( 0, q1.Index );
            q2.Parent = q1;
            Assert.IsTrue( f.Questions.Children.Contains( q1 ) );
            Assert.IsTrue( f.Questions.Children.Contains( q2 ) );
        }
    }
}
