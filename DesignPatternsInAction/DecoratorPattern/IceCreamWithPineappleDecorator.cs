namespace DecoratorPattern
{
    public class IceCreamWithPineappleDecorator : IceCreameDecorator
    {
        public IceCreamWithPineappleDecorator(IceCreame iceCreame) : base(iceCreame)
        {
        }

        public override string GetName() => base.GetName() + " With Pineapple";

        public override int GetPrice() => base.GetPrice() + 250;
    }
}