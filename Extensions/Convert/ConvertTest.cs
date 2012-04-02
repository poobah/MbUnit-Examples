using Gallio.Framework;
using MbUnit.Framework;

namespace Extensions.Convert
{
    [TestFixture]
    public class ConvertTest
    {
        [Test]
        [Row(12)]
        [Row(34)]
        [Row("56")]
        [Row("78")]
        public void TestConvertData(Foo foo) 
        {
            TestLog.WriteLine("Foo value = {0}", foo.Value);
        }
    }
}
