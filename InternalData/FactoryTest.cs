
using System.Collections;
using MbUnit.Framework;

[TestFixture]
public class FactoryTest
{
    public ArrayList ProviderArrayList
    {
        get
        {
            var list = new ArrayList { 1, 2 };
            return list;
        }
    }

    [Test]
    [Factory("ProviderArrayList")]
    public void Test (int value)
    {
        Assert.GreaterThan(value, 0);
    }
}