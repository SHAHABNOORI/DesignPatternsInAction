namespace DecoratorPattern
{
    public class IceCreameWithChocolate : IceCreameDecorator
    {
        public IceCreameWithChocolate(IceCreame iceCreame) : base(iceCreame)
        {
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 300;
        }

        public override string GetName()
        {
            return $"{base.GetName()} With Chocolate";
        }
    }
}