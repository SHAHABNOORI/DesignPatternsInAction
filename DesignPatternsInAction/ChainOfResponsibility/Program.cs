using System;
using ChainOfResponsibility.Models;
using ChainOfResponsibility.Pattern;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = new Customer()
            {
                AccountValue = 1000,
                Active = true,
                MaxDateValue = 100,
                Password = "1234"
            };

            var to = new Customer()
            {
                AccountValue = 10000,
                Active = true,
                MaxDateValue = 2000,
                Password = "1234"
            };

            var transferPathOne = new CheckPassword(new CheckBallance(new CheckCustomerActiveState(new FinalizeTransfer(null))));

            var result = transferPathOne.Execute(new RequestContext()
            {
                From = from,
                Password = "1234",
                Value = 50,
                To = to
            });

            Console.WriteLine("Result :: " + result.Message);

            Console.ReadKey();
        }
    }
}
