using System;

namespace Pets
{
    public abstract class MakeSound
    {
        public string name { get; }

        public MakeSound(string name)
        {
            this.name = name;
        }

        public abstract void Execute();
    }
}

