namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    using System;

    public class CEO : Approver
    {
        protected override bool CanApprove(decimal amount)
        {
            return true;
        }

        protected override void Approve(PurchaseRequest request)
        {
            Console.WriteLine($"CEO approved request for '{request.Description}'");
        }
    }


}
