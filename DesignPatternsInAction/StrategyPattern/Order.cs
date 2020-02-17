using StrategyPattern.Pattern;

namespace StrategyPattern
{
    public class Order
    {
        public Order(int price, Customer customer)
        {
            Price = price;
            Customer = customer;
        }

        public Order(int price, Customer customer, CalFinalPrice calFinalPrice)
        {
            Price = price;
            Customer = customer;
            CalFinalPrice = calFinalPrice;
        }

        public int Price { get; set; }

        public Customer Customer { get; set; }

        public CalFinalPrice CalFinalPrice { get; set; }

        public int GetFinalPriceInLegacyWay()
        {
            switch (Customer.CustomerType)
            {
                case CustomerType.Gold:
                    return Price - 20;

                case CustomerType.Bronze:
                    return Price - 10;

                case CustomerType.Silver:
                    return Price - 5;

                case CustomerType.Platinium:
                    return Price - 2;

                default:
                    return Price;
            }
        }

        public int GetFinalPriceByStrategyPattern()
        {
            return CalFinalPrice.Calculate(Price);
        }
    }
}