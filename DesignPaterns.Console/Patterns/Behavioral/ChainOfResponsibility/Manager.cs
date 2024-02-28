namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    using System;

    // Concrete handlers
    public class Manager : Approver
    {
        protected override bool CanApprove(decimal amount)
        {
            return amount <= 1000;
        }

        protected override void Approve(PurchaseRequest request)
        {
            Console.WriteLine($"Manager approved request for '{request.Description}'");
        }
    }


}
