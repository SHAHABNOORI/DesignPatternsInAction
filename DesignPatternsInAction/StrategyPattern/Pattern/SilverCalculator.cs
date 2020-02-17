namespace StrategyPattern.Pattern
{
    public class SilverCalculator : CalFinalPrice
    {
        public override int Calculate(int price) => price - 5;
    }
}