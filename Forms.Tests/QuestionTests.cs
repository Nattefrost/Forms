using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Forms.Models;

namespace Forms.Tests
{
    [TestFixture]
    public class QuestionTests
    {
        [Test]
        public void CreateQuestionFolders()
        {
            Form f = new Form();
            f.Questions.Title = "form1";
            Assert.AreEqual("form1", f.Title);
            QuestionBase q1 = f.Questions.AddNewQuestion("BooleanQuestion", true);
            QuestionBase q2 = f.Questions.AddNewQuestion(typeof(BooleanQuestion), true);
            Assert.AreEqual(0, q1.index);
            Assert.AreEqual(1, q2.index);
            q2.index = 0;
            Assert.AreEqual(0, q2.index);
            Assert.AreEqual(1, q1.index);
            q2.Parent = null;
            Assert.AreEqual(0, q1.index);
            q2.Parent = q1;
            Assert.IsTrue(f.Questions.Contains( q1 ));
            Assert.IsTrue(f.Questions.Contains( q2 ));
        }
    }
}
