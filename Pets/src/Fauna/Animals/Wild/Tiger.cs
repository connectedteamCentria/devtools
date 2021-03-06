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
          string result;    
          Random random = new Random();
          int rnd = random.Next(0, 100);
          if(rnd<60) 
          {
            this.Eat();
            result = this.GetType().ToString().Substring(6) + " finds food, gains 1 kg and weighs now " + this.weight; 
          }
          else result = this.GetType().ToString().Substring(6) + " does not find food and weights " + this.weight;
          return result;
        }
    }
}