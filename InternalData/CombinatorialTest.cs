using System.Collections.Generic;
using MbUnit.Framework;

[TestFixture]
    public class CombinatorialTest
    {

    public IEnumerable<IAlphaString> GetInstances()
    {
        yield return new AlphaString();
    }
    
    [Test]
    [Row("aaaa", true)]
    [Row("111", false)]
    public void Test(string value, bool isValid, [Factory("GetInstances")] IAlphaString alphaString)
    {
        Assert.AreEqual(isValid, alphaString.ValidString(value));
    }

}



