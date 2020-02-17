namespace StrategyPattern.Pattern
{
    public class GoldCalculator : CalFinalPrice
    {
        public override int Calculate(int price) => price - 20;
    }
}