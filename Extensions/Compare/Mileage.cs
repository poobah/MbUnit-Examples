namespace Extensions
{
    public class Mileage
    {
        private readonly double value;

        public Mileage(double value)
        {
            this.value = value;
        }

        public double Value
        {
            get { return value; }
        }
    }
}