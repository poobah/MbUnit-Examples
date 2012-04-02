using MbUnit.Framework;
using NHamcrest.Core;

namespace MoreAssertExamples
{
    [TestFixture]
    public class AssertThatBasic
    {
        private string _myvalue;

        [SetUp]
        public void Start()
        {
            _myvalue = "hello";
        }

        [Test]
        public void ThatIsEqualTo()
        {
            Assert.That("hello", Is.EqualTo(_myvalue));
        }
    }
}