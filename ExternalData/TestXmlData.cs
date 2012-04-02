using MbUnit.Framework;

namespace ExternalData
{
    [TestFixture]
    public class TestXmlData
    {
        private BasketDemo _basketDemo;

        [SetUp]
        public void SetUp()
        {
            _basketDemo = new BasketDemo();
        }

        [Test, XmlData("//item", ResourcePath = "Data.xml")]
        public void TestXmlBasketExample([Bind("price")] decimal price, [Bind("quantity")] int quantity, [Bind("@name")] string item)
        {
            _basketDemo.AddItem(item, quantity, price);

            Assert.AreEqual(price * quantity, _basketDemo.TotalCost);
        }
    }
}
