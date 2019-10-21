using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Animal
    {
        public string Name {get; set;}
        public int HungerLevel {get; set;}

        //Konstrouktor?
        public Animal (string name, int hungerLevel)
        {
            Name = name;
            HungerLevel = hungerLevel;
        }

        // Du skulle kunnna byta ut Content metoden med en ToString.
        public string Content()
        {
            string str =  "Djuret heter " + Name;
            return str;
        }

        
        
    }
}
