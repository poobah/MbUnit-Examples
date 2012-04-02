using System;

namespace Fixtures
{
    public class Foo
    {
        public void DoSomething(string test)
        {
            if(test == null)
            {
                throw new ArgumentNullException("test", "is null");
            }
        }
    }
}
