using MbUnit.Framework;

[TestFixture]
public class StringExamples
{
    private string _TestValue;

    [SetUp]
    public void Start()
    {
        _TestValue = "hello everyone";
    }

    [Test]
    public void ContainsExample()
    {
        Assert.Contains(_TestValue, "hello");
    }

    [Test]
    public void DoesNotContainExample()
    {
        Assert.DoesNotContain(_TestValue, "t");
    }

    [Test]
    public void StartsWithExample()
    {
        Assert.StartsWith(_TestValue, "hello");
    }

    [Test]
    public void FullMatchExample()
    {
        Assert.FullMatch("11-22-33", @"\d{2}-\d{2}-\d{2}");
    }

    [Test]
    public void AssertLikeExample()
    {
        Assert.Like(_TestValue, @"\w");
    }
}