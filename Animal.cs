using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Animal
    {
        public string Name {get; set;}
        public string Type {get; set;}
        public int HungerLevel {get; set;}

        //Konstrouktor?
        public Animal (string name, string type, int hungerLevel)
        {
            Name = name;
            Type = type;
            HungerLevel = hungerLevel;
        }

        public string Content()
        {
            string str =  Type + "en " + Name;
            return str;
        }

        
        
    }
}
