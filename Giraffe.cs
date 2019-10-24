using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Giraffe : Animal
    {

        public Giraffe(string name)
        {
            Name = name;
            Type = "Giraff";
            HungerLevel = 0;
            HungryAt = 7;
            IsHungry = false;
            FoodType = "leaf";
        }

        public override void Eat(Leaf leaf)
        {
            HungerLevel = 0;
            leaf.Level--;
        }

    }
}
