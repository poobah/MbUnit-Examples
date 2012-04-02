using System;
using System.Collections;
using System.Collections.Generic;
using MbUnit.Framework;

public class TypeFixtureExample
{
    public static IEnumerable<IEnumerable> GetInstances()
    {
        yield return new ArrayList();
        yield return new ArrayList { 0, 1 };
    }

    [Factory("GetInstances")]
    public IEnumerable Instance;

    [Test]
    [ExpectedException(typeof(InvalidOperationException))]
    public void CurrentCalledBeforeMoveNext()
    {
        var er = Instance.GetEnumerator();
        var p = er.Current;
    }

    [Test]
    [ExpectedException(typeof(InvalidOperationException))]
    public void CurrentCalledAfterFinishedMoveNext()
    {
        var er = Instance.GetEnumerator();
        while (er.MoveNext())
        {
        }
        var p = er.Current;
    }
} 


