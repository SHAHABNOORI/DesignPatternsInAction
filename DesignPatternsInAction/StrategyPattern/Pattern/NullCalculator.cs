namespace StrategyPattern.Pattern
{
    public class NullCalculator : CalFinalPrice
    {
        public override int Calculate(int price) => price;
    }
}