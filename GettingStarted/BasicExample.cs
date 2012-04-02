using MbUnit.Framework;

[TestFixture]
public class BasicExample
{
    private string _myvalue;

    [SetUp]
    public void Start()
    {
        _myvalue = "hello";
    }

    [Test]
    public void Example1()
    {
        Assert.AreEqual("hello", _myvalue);
    }

    [TearDown]
    public void Stop()
    {
      //do nothing
    }

}