using MbUnit.Framework;

namespace MoreAssertExamples
{
    [TestFixture]
    public class AssertExBasic
    {
        [Test]
        public void Test()
        {
            int x = 2;
            AssertEx.That(() => x == 2);
        }
    }
}
