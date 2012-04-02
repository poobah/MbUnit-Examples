using System;
using Gallio.Framework;
using MbUnit.Framework;

namespace Extensions.Convert
{
    public class FooExtensionPoints
    {
        // A custom converter that specify how 
        // to convert an Int32 into a Foo instance.
        [Converter]
        public static Foo Int32ToFoo(int value)
        {
            TestLog.WriteLine("Convert '{0}' (int) into Foo", value);
            return new Foo(value);
        }

        // A custom converter that specify how 
        // to convert a string into a Foo instance.
        [Converter]
        public static Foo StringToFoo(string value)
        {
            TestLog.WriteLine("Convert '{0}' (string) into Foo", value);
            return new Foo(Int32.Parse(value));
        }

    }
}