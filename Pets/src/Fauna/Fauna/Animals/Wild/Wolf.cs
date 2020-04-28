using System;

namespace Fauna
{
    public class Wolf : Animal, IWild
    {
        public Wolf()
        {}

        // Animal methods
        public override void MakeSound()
        {
           System.Console.WriteLine("Groar!");
        }

        // IWild Methods
        public string Hunt()
        {          
          return this.GetType() + " hunts";
        }
    }
}