using System;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;

namespace ContractVerifiers
{
    [TestFixture]
    public class VeriferTest
    {
        [VerifyContract] 
        public readonly IContract CollectionTests = new CollectionContract<ListClass<int>, int>
        {
            IsReadOnly = false,
            DistinctInstances = {1, 2, 3}
        };

        [VerifyContract] 
        public readonly IContract ListTests = new ListContract<ListClass<int>, int>
        {
            IsReadOnly = false,
            DistinctInstances = {1, 2, 3}
        };

        [VerifyContract] 
        public readonly IContract FooContract = new FooContract
        {
            DefaultInstance = () => new Foo()
        };



    }
}