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
        {
            this.name = "";
        }
        
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
            if(this.name =="") this.name = this.GetType().ToString();
            string line = this.name + " came to the owner."; 
            return line;
        }
       public void TalkToOwner()
        {
            if(this.name =="") this.name = this.GetType().ToString();
            System.Console.WriteLine("{0} talk to owner", this.name);
        }
        public void GiveName(string name)
        {
            this.name = name;            
        }
        
    }
}