using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Bear : Animal
    {

        public Bear(string name)
        {
            Name = name;
            Type = "Björn";
            HungerLevel = 0;
            HungryAt = 3;
            IsHungry = false;
        }

        override public void Eat(Leaf leaf, Meat meat)
        {
            HungerLevel = 0;
            if (leaf.Level != 0)
            {
                leaf.Level--;
            }
            else
            {
                meat.Level--;
            }
        }
    }
}