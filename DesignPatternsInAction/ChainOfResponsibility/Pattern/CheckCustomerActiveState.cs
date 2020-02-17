using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Pattern
{
    public class CheckCustomerActiveState : TransferMoney
    {
        public CheckCustomerActiveState(TransferMoney successor) : base(successor)
        {
        }

        public override ResponceContext Execute(RequestContext requestContext)
        {
            if (requestContext.From.Active)
                return Successor.Execute(requestContext);
            return new ResponceContext()
            {
                Message = "Customer is not active...."
            };
        }
    }
}