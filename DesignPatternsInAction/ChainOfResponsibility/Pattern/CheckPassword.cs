using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Pattern
{
    public class CheckPassword : TransferMoney
    {
        public CheckPassword(TransferMoney successor) : base(successor)
        {
        }

        public override ResponceContext Execute(RequestContext requestContext)
        {
            if (requestContext.From.Password == requestContext.Password)
                return Successor.Execute(requestContext);
            return new ResponceContext()
            {
                Message = "Incorrect password"
            };
        }
    }
}