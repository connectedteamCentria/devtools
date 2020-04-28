using System;

namespace Fauna
{
    public class Tiger : Animal, IWild
    {        
        public Tiger()
        {}

        // Animal methods
        public override void MakeSound()
        {
           System.Console.WriteLine("Roar!");
        }        
        
        // IWild Methods
        public string Hunt()
        {          
          return this.GetType() + " hunts";
        }
    }
}