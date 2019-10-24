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
            FoodType = "leaf";
        }
        //Metoden Eat. Tar in antalet kvarvarande blad. Nollställer HungerLevel samt drar bort ett blad från antalet blad.
        public override void Eat(Leaf leaf)
        {
            HungerLevel = 0;
            leaf.Level--;

        }
        // Viktors version av ovanstående.
        // public override void Eat(Leaf leaf)
        // {
        //     HungerLevel = 0;
        //     leaf.RemoveOne();
        //}
    }
}
