using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Seal : Animal
    {

        public Seal(string name)
        {
            Name = name;
            Type = "Säl";
            HungerLevel = 0;
            HungryAt = 13;
            IsHungry = false;
        }

        public override void Eat(Meat meat)
        {
            HungerLevel = 0;
            meat.Level--;
        }
    }
}