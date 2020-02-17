namespace DecoratorPattern
{
    public abstract class IceCreameDecorator : IceCreame
    {
        private readonly IceCreame _iceCreame;

        protected IceCreameDecorator(IceCreame iceCreame)
        {
            _iceCreame = iceCreame;
        }

        public override string GetName() => _iceCreame.GetName();

        public override int GetPrice() => _iceCreame.GetPrice();

    }
}