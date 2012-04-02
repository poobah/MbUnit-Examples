namespace ExternalData
{
    public class BasketDemo
    {
        public decimal TotalCost { get; private set; }
        
        public void AddItem(string item, decimal quantity, decimal unitPrice)
        {
            TotalCost += (unitPrice*quantity);
        }
    }
}
