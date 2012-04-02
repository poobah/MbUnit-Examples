using MbUnit.Framework;

namespace ExternalData
{
    [TestFixture]
    public class TestTextData
    {
        [Test]
        public void TestTextDataLength([TextData(ResourcePath = "Data.txt")] string text)
        {
            Assert.AreEqual(5, text.Length);
        }
    }
}
