using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Pattern
{
    public class CheckBallance : TransferMoney
    {
        public CheckBallance(TransferMoney successor) : base(successor)
        {
        }

        public override ResponceContext Execute(RequestContext requestContext)
        {
            if (requestContext.From.AccountValue >= requestContext.Value)
                return Successor.Execute(requestContext);
            return new ResponceContext()
            {
                Message = "Ballance Is not enough...."
            };
        }
    }
}