using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Elephant : Animal
    {

        public Elephant(string name)
        {
            Name = name;
            Type = "Elefant";
            HungerLevel = 0;
            HungryAt = 10;
            IsHungry = false;
        }

        public override void Eat(Leaf leaf)
        {
            HungerLevel = 0;
            leaf.Level--;

        }
    }
}
