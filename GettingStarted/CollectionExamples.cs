using System.Collections.Generic;
using MbUnit.Framework;


[TestFixture]
public class CollectionExamples
{
    private List<string> _testCollectionExpected;
    private List<string> _testCollectionActual;
    
    [SetUp]
    public void Start()
    {
        _testCollectionExpected = new List<string>();
        _testCollectionActual = new List<string>();
        _testCollectionExpected.Add("hello everyone");
    }

    [Test]
    public void AreEquelExample()
    {
        _testCollectionActual.Add("hello everyone");
        Assert.AreElementsEqual(_testCollectionExpected, _testCollectionActual);
    }

    [Test]
    public void AreCountEquelExample()
    {
        _testCollectionActual.Add("some data");
       // _testCollectionActual.Add("some more data");
        Assert.Count(1, _testCollectionActual);
    }

    [Test]
    public void UniqueItemsExample()
    {
        _testCollectionActual.Add("hello everyone");
        Assert.AreElementsSame(_testCollectionExpected, _testCollectionActual);
    }

}