using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Pattern
{
    public class FinalizeTransfer : TransferMoney
    {
        public FinalizeTransfer(TransferMoney successor) : base(successor)
        {
        }

        public override ResponceContext Execute(RequestContext requestContext)
        {
            requestContext.From.AccountValue -= requestContext.Value;
            requestContext.To.AccountValue += requestContext.Value;

            return new ResponceContext()
            {
                Message = "Transfer Complete...."
            };
        }
    }
}