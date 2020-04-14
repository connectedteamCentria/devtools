using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"Hello World!");
            Cat fluffy = new Cat();
            Console.WriteLine(fluffy.TalkToCatOwner());
        }
    }
}