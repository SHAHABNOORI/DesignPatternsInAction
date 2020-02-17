namespace DecoratorPattern
{
    public class IceCreameWithSmartis : IceCreameDecorator
    {
        public IceCreameWithSmartis(IceCreame iceCreame) : base(iceCreame)
        {
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 200;
        }

        public override string GetName()
        {
            return $"{base.GetName()} With Smartis";
        }
    }
}