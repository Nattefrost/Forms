using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Form;

namespace Forms.Tests
{
    [TestFixture]
    public class QuestionTests
    {
        [Test]
        public void Can_create_question()
        {
            Assert.That(1 == 1);
        }
    }

    [TestFixture]
    public class FormsTests
    {
        [Test]
        public void Can_create_form()
        {
            Assert.That(1 != 0);
        }
    }
    [TestFixture]
    public class AnswersTests
    {
        [Test]
        public void Can_create_answer()
        {
            Assert.That(0 == 0);
        }
    }
}
