using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int HungerLevel { get; set; }
        public int HungryAt { get; set; }
        public bool IsHungry { get; set; }


        public string Content()
        {
            string str = Type + "en " + Name;
            return str;
        }

        public virtual void Eat(Leaf food)
        {
        

        }
        public virtual void Eat(Meat food)
        {
        

        }
        public virtual void Eat(Leaf leaf, Meat meat)
        {

        }
        


    }
}
