using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FirtStepOfBussiness();

            ExtendBusinessWithDecoratorPattern();

            Console.ReadKey();
        }

        private static void ExtendBusinessWithDecoratorPattern()
        {
            var largeIceCreame = new LargeIceCreame();
            var iceCreameWithSmartis = new IceCreameWithSmartis(largeIceCreame);
            var iceCreamWithSmartisAndChocolate = new IceCreameWithChocolate(iceCreameWithSmartis);
            Console.WriteLine(iceCreamWithSmartisAndChocolate.GetName() + " " + iceCreamWithSmartisAndChocolate.GetPrice());
        }

        private static void FirtStepOfBussiness()
        {
            var largeIceCreame = new LargeIceCreame();
            Console.WriteLine(largeIceCreame.GetName() + " " + largeIceCreame.GetPrice());

            var mediumIceCreame = new MediumIceCream();
            Console.WriteLine(mediumIceCreame.GetName() + " " + mediumIceCreame.GetPrice());

            var smallIceCreame = new SmallIceCreame();
            Console.WriteLine(smallIceCreame.GetName() + " " + smallIceCreame.GetPrice());
        }
    }
}
