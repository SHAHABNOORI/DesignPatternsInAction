namespace DecoratorPattern
{
    public class MediumIceCream : IceCreame
    {
        public override int GetPrice() => 150;

        public override string GetName() => "Medium IceCreame";
    }
}