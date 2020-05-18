namespace Fauna
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {  
            TextInterface testinteface = new TextInterface();

           // Cat fluffy = new Cat(); 
           // testinteface.AddAnimal(fluffy);
            //testinteface.GetAnimal(0);


          //  Dog spotty = new Dog();
         //   testinteface.AddAnimal(spotty);
          //  testinteface.GetAnimal(1);

            testinteface.Start();
            /*
            testinteface.PrintAnimals();
            testinteface.PrintList("Cat");
            testinteface.PrintList("Tiger");*/

             /*        
            Cat fluffy = new Cat();
            fluffy.TalkToOwner();
            fluffy.Eat();   
            fluffy.GiveName("Puffy");                 
            Bird stuffy = new Bird();
            stuffy.MakeSound();
            Dog grumpy = new Dog("Pip");
            System.Console.WriteLine(grumpy.ComeHere());
            Bear pooh = new Bear();
            pooh.MakeSound();
            pooh.Hunt();
            Wolf wooh = new Wolf();
            System.Console.WriteLine(wooh.Hunt());
            Tiger tooh = new Tiger();
            tooh.MakeSound();
            Elephant buh = new Elephant();
            buh.MakeSound();
            System.Console.WriteLine(buh.Hunt());
*/
        }
    }
}
