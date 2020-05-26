namespace Fauna
{
    public abstract class Animal
    {
        public int weight;

        public Animal()
        {
            weight = 0;
        }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            this.weight++;
         /*   string name = this.GetType().ToString().Substring(6);
            System.Console.WriteLine("{0} gained 1 kg, and weighs now {1} kg",
                name, this.weight);*/
        }

    }
}

