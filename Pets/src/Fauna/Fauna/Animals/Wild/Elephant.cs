using System;

namespace Fauna
{
    public class Elephant : Animal, IWild
    {
      
        public Elephant()
        {}

        // Animal methods
        public override void MakeSound()
        {
          System.Console.WriteLine("Pawoooo!");
        }
                
        // IWild Methods
        public string Hunt()
        {          
          return this.GetType() + " says 'I do not hunt'";
        }
    }
}
    
