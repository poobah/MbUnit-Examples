using System;
using MbUnit.Framework;

namespace Fixtures
{
    [TestFixture]
    public class ExceptionControl
    {
        private Foo _foo;

        [SetUp]
        public void Start()
        {
            _foo = new Foo();
        }


        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestArguementIsNull()
        {
            _foo.DoSomething(null);
        }


        [Test, ExpectedArgumentNullException]
        public void TestArgumentIsNullShorthand()
        {
            _foo.DoSomething(null);
        }

        [Test]
        public void TestAssertThrows()
        {
            Assert.Throws<ArgumentNullException>(() => _foo.DoSomething(null));
        }

    }
}
