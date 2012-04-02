using MbUnit.Framework;

namespace ExternalData
{
    [TestFixture]
    public class TestCsvData
    {
        private BasketDemo _basketDemo;

        [SetUp]
        public void SetUp()
        {
            _basketDemo = new BasketDemo();
        }

        [Test, CsvData(ResourcePath = "Data.csv")]
        public void TestCsvBasketExample(string item, decimal quantity, decimal unitPrice)
        {
            _basketDemo.AddItem(item, quantity, unitPrice);

            Assert.AreEqual(unitPrice*quantity, _basketDemo.TotalCost);
        }
    }
}
