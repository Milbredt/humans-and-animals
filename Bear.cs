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
            FoodType = "both";
        }
        //Metoden Eat(Leaf leaf). Körs om det finns blad kvar.
        override public void Eat(Leaf leaf)
        {
            HungerLevel = 0;
            leaf.Level--;
        }
        //Metoden Eat(Meat meat). Körs endast om det är slut på blad.
        override public void Eat(Meat meat)
        {
            HungerLevel = 0;
            meat.Level--;
        }
    }
}