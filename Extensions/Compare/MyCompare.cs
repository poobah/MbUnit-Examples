using Gallio.Framework;
using MbUnit.Framework;

namespace Extensions
{
    public class MyCompare
    {
        [Comparer]
        public static int CompareMileages(Mileage left, Mileage right)
        {
            // Null reference handling is not necessary: 'left' and 'right' are never null.  
            TestLog.WriteLine("Comparing Mileage '{0}' with '{1}'.", left.Value, right.Value);
            return left.Value.CompareTo(right.Value);
        }
    }
}