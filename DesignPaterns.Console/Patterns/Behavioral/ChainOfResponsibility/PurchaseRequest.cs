namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    // Request class
    public class PurchaseRequest
    {
        public string Description { get; }
        public decimal Amount { get; }

        public PurchaseRequest(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }
    }


}
