using MbUnit.Framework;

namespace SampleVStest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Sample()
        {
            Assert.AreEqual(1, 1);
        }
    }
}