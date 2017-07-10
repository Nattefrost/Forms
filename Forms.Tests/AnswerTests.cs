using NUnit.Framework;
using Forms.Models;

namespace Forms.Tests
{
    [TestFixture]
    public class AnswerTests
    {
        [Test]
        public void CreateAnswers()
        {
            Form f = new Form();
            Assert.IsNull(f.Title);
            f.Title = "jj";
            Assert.AreEqual("jj", f.Title);
            FormAnswer a = f.FindOrCreateAnswer("Emilie");
            Assert.IsNotNull(a);
            FormAnswer b = f.FindOrCreateAnswer("Emilie");
            Assert.AreSame(a, b);
            Assert.AreEqual(f.Answers.Count, 1);
            FormAnswer c = f.FindOrCreateAnswer("Robert");
            Assert.AreNotSame(a, c);
            Assert.AreEqual("Emilie", a.UniqueName);
            Assert.AreEqual("Robert", c.UniqueName);
            Assert.AreEqual(f.Answers.Count, 2);


        }
    }
}
