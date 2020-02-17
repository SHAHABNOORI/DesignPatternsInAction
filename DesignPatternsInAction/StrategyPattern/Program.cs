using System;
using StrategyPattern.Pattern;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LegacyWay();

            UsingStrategyPattern();

            Console.ReadKey();
        }

        private static void UsingStrategyPattern()
        {
            var mina = new Customer()
            {
                CustomerType = CustomerType.Gold,
                FirstName = "Mina",
                LastName = "Zarnaqi"
            };

            var order = new Order(150, mina, new GoldCalculator());
            Console.WriteLine(order.GetFinalPriceByStrategyPattern());
        }

        private static void LegacyWay()
        {
            var shahab = new Customer()
            {
                CustomerType = CustomerType.Gold,
                FirstName = "Shahab",
                LastName = "Noori Goodarzi"
            };

            var order = new Order(150, shahab);
            Console.WriteLine(order.GetFinalPriceInLegacyWay());
        }
    }
}
