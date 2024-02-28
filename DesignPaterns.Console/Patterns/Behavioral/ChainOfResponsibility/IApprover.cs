namespace DesignPaterns.Console.Patterns.Behavioral.ChainOfResponsibility
{
    // Handler interface
    public interface IApprover
    {
        void SetNext(IApprover approver);
        void ProcessRequest(PurchaseRequest request);
    }


}
