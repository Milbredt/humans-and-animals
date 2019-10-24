using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Coyote : Animal
    {

        public Coyote(string name)
        {
            Name = name;
            Type = "Prärievarg";
            HungerLevel = 0;
            HungryAt = 15;
            IsHungry = false;
            FoodType = "meat";
        }

        public override void Eat(Meat meat)
        {
            HungerLevel = 0;
            meat.Level--;
        }
    }
}
