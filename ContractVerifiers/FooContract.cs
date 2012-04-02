using System;
using System.Collections.Generic;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;

namespace ContractVerifiers
{
    public class FooContract : AbstractContract
    {
        public Func<IFoo> DefaultInstance
        {
            set; get; 
        }
        
        protected override IEnumerable<Test> GetContractVerificationTests()
        {
            yield return new TestCase("SayFoo", () =>
            {
                var defaultInstance = DefaultInstance();
                Assert.AreEqual(defaultInstance.SayFoo(), "Foo");
            });
        }
    }
}