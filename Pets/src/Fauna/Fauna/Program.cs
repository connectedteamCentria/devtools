using System;

namespace Fauna
{
    class Program
    {
        static void Main(string[] args)
        {            
            Cat fluffy = new Cat();
            fluffy.TalkToOwner();
            Bird stuffy = new Bird();
            stuffy.MakeSound();
            Dog grumpy = new Dog("Pip");
            System.Console.WriteLine(grumpy.ComeHere());
            Bear pooh = new Bear();
            pooh.MakeSound();
            Wolf wooh = new Wolf();
            System.Console.WriteLine(wooh.Hunt());
            Tiger tooh = new Tiger();
            tooh.MakeSound();
            Elephant buh = new Elephant();
            buh.MakeSound();
            System.Console.WriteLine(buh.Hunt());

        }
    }
}
