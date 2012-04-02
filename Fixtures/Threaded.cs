using MbUnit.Framework;

namespace Fixtures
{
    [TestFixture]
    public class Threaded
    {
        [Test]
        [ThreadedRepeat(5)]
        public void TestThreaded()
        {
        }
    }
}
