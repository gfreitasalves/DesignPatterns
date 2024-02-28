namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    /// <summary>
    /// Chain of Responsibility Pattern: This pattern allows an object to pass a request along a chain of handlers. Each handler decides either to process the request or to pass it along the chain.
    /// </summary>
    public static class ChainOfResponsibility
    {
        public static void Start()
        {
            Manager manager = BuildChain();

            // Send purchase requests
            var request1 = new PurchaseRequest("Laptop", 800);
            var request2 = new PurchaseRequest("Conference Table", 3000);
            var request3 = new PurchaseRequest("New Office Building", 100000);

            manager.ProcessRequest(request1);
            manager.ProcessRequest(request2);
            manager.ProcessRequest(request3);
        }

        private static Manager BuildChain()
        {
            // Build the chain
            var manager = new Manager();
            var director = new Director();
            var ceo = new CEO();

            manager.SetNext(director);
            director.SetNext(ceo);
            return manager;
        }
    }


}
