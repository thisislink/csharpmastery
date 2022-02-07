using System;

namespace ShirtPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            LongSleeveTShirt longSleeveTShirt = new LongSleeveTShirt();
            ShortSleeveTShirt shortSleeveTShirt = new ShortSleeveTShirt();
            ShortSleevePolo shortSleevePolo = new ShortSleevePolo();

            Clothing[] clothes = { longSleeveTShirt, shortSleeveTShirt, shortSleevePolo };

            foreach(Clothing item in clothes)
            {
                item.Color();
            }
            
            Console.ReadKey();
        }
    }
}
