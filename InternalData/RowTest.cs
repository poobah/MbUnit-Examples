using MbUnit.Framework;

[TestFixture]
public class RowTest
{
    [Test]
    [Row(1, 3)]
    [Row(2, 2)]
    public void Example1(int sum1, int sum2)
    {
        Assert.AreEqual(4, sum1 + sum2);
    }

    [Test]
    [Row(1, 3, "test")]
    [Row(2, 2, "test")]
    public void Example2(int sum1, int sum2, string value)
    {
        Assert.AreEqual(4, sum1 + sum2);
    }

    [Test]
    [Header("sum1", "sum2", "value")]
    [Row(1, 3, "test")]
    [Row(2, 2, "test")]
    public void Example3(string value, int sum1, int sum2)
    {
        Assert.AreEqual(4, sum1 + sum2);
    }
}