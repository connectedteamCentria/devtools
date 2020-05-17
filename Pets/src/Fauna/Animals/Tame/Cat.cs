using System;

namespace Fauna
{
    public class Cat : Animal, ITame
    {
        private string name;
        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public Cat()
        {
            this.name = "";
        }

         public Cat(string name)
         {
             this.name = name;
         }

        // Animal methods
        public override void MakeSound()
        {
          System.Console.WriteLine("Meow!"); ;
        }

        // ITame methods
        public string ComeHere()
        {
            if(this.name == "") this.name = this.GetType().ToString().Substring(6);
            string line = this.name + " came to the owner."; 
            
            return line; 
            
        }

        public void GiveName(string name)
        {
            this.name = name;            
        }

        public void TalkToOwner()
        {
            if(this.name =="") this.name = this.GetType().ToString().Substring(6);
            System.Console.WriteLine("{0} talk to owner", this.name);
        }
    }
}