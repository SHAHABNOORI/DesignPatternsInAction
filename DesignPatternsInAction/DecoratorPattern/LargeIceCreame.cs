namespace DecoratorPattern
{
    public class LargeIceCreame : IceCreame
    {
        public override int GetPrice() => 200;

        public override string GetName() => "Large IceCreame";
    }
}