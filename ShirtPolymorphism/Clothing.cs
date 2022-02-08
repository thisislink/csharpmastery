using System;
using System.Collections.Generic;
using System.Text;

namespace ShirtPolymorphism
{
    class Clothing
    {
        public virtual void Color()
        {
            Console.WriteLine("This piece of clothing is white.");
        }
    }

    class LongSleeveTShirt : Clothing
    {
        public override void Color()
        {
            Console.WriteLine("The long sleeve tshirt is black.");
        }

    }

    class ShortSleeveTShirt : Clothing 
    {
        public override void Color()
        {
            Console.WriteLine("The short sleeve tshirt is green.");
        }
    }

    class ShortSleevePolo : Clothing
    {
    }

}
