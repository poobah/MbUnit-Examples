using MbUnit.Framework;

namespace Extensions
{
    [TestFixture]
    public class MilageTest
    {
        [Test]
        public void CompareMileages_pass()
        {
            var low = new Mileage(12);
            var high = new Mileage(896);
            Assert.GreaterThan(high, low);
            //Assert.LessThan(5, 1);
        }

        [Test]
        public void CompareMileages_fail()
        {
            var low = new Mileage(12);
            var high = new Mileage(896);
            Assert.LessThan(high, low);
        }
    }
}
