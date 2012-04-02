using Gallio.Model;
using MbUnit.Framework;

namespace Fixtures
{
    [TestFixture]
    public class OutcomeControl
    {
        [Test]
        [Ignore]
        public void TestIgnore()
        {
        }

        [Test]
        [Pending]
        public void TestPending()
        {
        }

        [Test]
        [Explicit]
        public void TestExplicit()
        {
        }

        [Test]
        public void TestFail()
        {
            Assert.Fail("Failing test");
        }

        [Test]
        public void TestInconclusive()
        {
            Assert.Inconclusive("Inconclusive test");
        }

        [Test]
        public void TestTerminate()
        {
           //Assert.Terminate(TestOutcome.Failed);
           Assert.Terminate(TestOutcome.Inconclusive);
        }
    }
}
