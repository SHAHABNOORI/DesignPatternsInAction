namespace DecoratorPattern
{
    public class SmallIceCreame : IceCreame
    {
        public override int GetPrice() => 100;

        public override string GetName() => "Small IceCreame";
    }
}