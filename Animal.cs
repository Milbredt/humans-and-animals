using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Animal
    {
        public string Name { get; set; }
        // Viktors version av ovanstående.
        // public string Name { get; private set; }
        public string Type { get; set; }
        public int HungerLevel { get; set; }
        public int HungryAt { get; set; }
        public bool IsHungry { get; set; }
        public string FoodType{ get; set;}


        public string Content()
        {
            string str = Type + "en " + Name;
            return str;
        }
        //Viktors version av ovanstående. Satte även klassen animal till abstract.
        // public override string ToString()        
        //{
        //     string str = Type + "en " + Name;
        //     return str;
        // }

        public virtual void Eat(Leaf food)
        {
        }
        public virtual void Eat(Food food)
        {
        }
        // Viktors version av ovanstående.
        // public abstract void Eat(Food food)
        // {
        // }
        public virtual void Eat(Meat food)
        {
        }
        public virtual void Eat(Leaf leaf, Meat meat)
        {
        }
        


    }
}
