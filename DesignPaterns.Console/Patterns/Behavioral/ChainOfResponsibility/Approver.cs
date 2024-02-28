namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    using System;

    // Abstract handler
    public abstract class Approver : IApprover
    {
        private IApprover? _nextApprover;

        public void SetNext(IApprover approver)
        {
            _nextApprover = approver;
        }

        public void ProcessRequest(PurchaseRequest request)
        {
            if (CanApprove(request.Amount))
            {
                Approve(request);
            }
            else if (_nextApprover != null)
            {
                _nextApprover.ProcessRequest(request);
            }
            else
            {
                Console.WriteLine("No one can approve this request.");
            }
        }

        protected abstract bool CanApprove(decimal amount);
        protected abstract void Approve(PurchaseRequest request);
    }


}
