using System;

namespace Fauna
{
    public class Bear : Animal, IWild
    {
        public Bear()
        {}

        // Animal methods
        public override void MakeSound()
        {
           System.Console.WriteLine("Broar!");
        }

        // IWild Methods
        public string Hunt()
        {          
          return this.GetType() + " hunts";
        }
    }
}