// A simple type that encapsulates an Int32 value.
namespace Extensions.Convert
{
    public class Foo
    {
        private readonly int value;

        public int Value
        {
            get
            {
                return value;
            }
        }

        public Foo(int value)
        {
            this.value = value;
        }
    }
}
