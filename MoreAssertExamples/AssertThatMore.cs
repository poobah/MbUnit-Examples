using MbUnit.Framework;
using NHamcrest.Core;

namespace MoreAssertExamples
{
    public class AssertThatMore
    {
        private string _TestValue;

        [SetUp]
        public void Start()
        {
            _TestValue = "hello everyone";
        }

        [Test]
        public void ThatIsSameAs()
        {
            Assert.That(_TestValue, Is.SameAs(_TestValue));
        }

        [Test]
        public void ThatIsNotSameAs()
        {
            Assert.That(_TestValue, Is.Not(Is.EqualTo("test data")));
        }

    }
}
