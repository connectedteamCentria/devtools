using System;

namespace Fauna
{
    public class Bird : Animal, ITame
    {
        private string name;
        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public Bird()
        {
            this.name = "";
        }

         public Bird(string name)
         {
             this.name = name;
         }

        // Animal methods
        public override void MakeSound()
        {
            System.Console.WriteLine("CooCoo");
        }        

        // ITame methods
        public string ComeHere()
        {
            if(this.name == "") this.name = this.GetType().ToString().Substring(6);
            string line = this.name + " came to the owner."; 
            return line;
        }
       public void TalkToOwner()
        {
            if(this.name == "") this.name = this.GetType().ToString().Substring(6);
            System.Console.WriteLine("{0} talk to owner", this.name);
        }
        public void GiveName(string name)
        {
            this.name = name;            
        }

    }
}