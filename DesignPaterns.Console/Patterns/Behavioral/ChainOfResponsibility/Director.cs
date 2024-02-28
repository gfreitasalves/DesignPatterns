namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    using System;

    public class Director : Approver
    {
        protected override bool CanApprove(decimal amount)
        {
            return amount <= 5000;
        }

        protected override void Approve(PurchaseRequest request)
        {
            Console.WriteLine($"Director approved request for '{request.Description}'");
        }
    }


}
