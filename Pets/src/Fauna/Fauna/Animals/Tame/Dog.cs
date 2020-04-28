using System;

namespace Fauna
{
    public class Dog  : Animal, ITame
    {
        private string name;
        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public Dog()
        {}
        
         public Dog(string name)
         {
             this.name = name;
         }        

         // Animal methods
         public override void MakeSound()
        {
            System.Console.WriteLine("Wowwow}");
        }  

        // ITame methods
        public string ComeHere()
        {
            string line = this.name + " came to the owner."; 
            return line;
        }
       public void TalkToOwner()
        {
            System.Console.WriteLine("{0} talk to owner", this.name);
        }
    }
}