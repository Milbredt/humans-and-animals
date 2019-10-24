using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Skapar listan animalsList av klassen Animal.
            List<Animal> animalsList = new List<Animal>();

            //Skapar ett antal djur av olka klasser och lägger in dom i listan animalsList.
            Elephant elephant = new Elephant("Dolores");
            animalsList.Add(elephant);
            elephant = new Elephant("Flores");
            animalsList.Add(elephant);
            Giraffe giraffe = new Giraffe("Charlie");
            animalsList.Add(giraffe);
            Coyote coyote = new Coyote("Huff");
            animalsList.Add(coyote);
            coyote = new Coyote("Puff");
            animalsList.Add(coyote);
            Seal seal = new Seal("Bobby");
            animalsList.Add(seal);
            Bear bear = new Bear("Bobo");
            animalsList.Add(bear);

            //Skapar ett objekt av klassen Leaf respektive Meat med vardera värdet 50.
            Leaf leaf = new Leaf(50);
            Meat meat = new Meat(50);

            Console.WriteLine("Välkommen till djurparken!\nHär finns följande djur:\n");

            if (animalsList.Count != 0)
            {
                //loopar igenom listan animallist. 
                // Indexerar listan och kör metoden content på varje element i listan. 
                // Metoden content ligger i varje klass.  
                for (int i = 0; i < animalsList.Count; i++)
                {
                    Console.WriteLine(animalsList[i].Content());
                    // Viktors version av ovanstående.
                    // Console.WriteLine(animalsList[i].ToString());
                }
            }
            Console.ReadKey();

            // Day loop
            int day = 0;
            while (true)
            {
                Console.Clear();
                day++;
                Console.WriteLine("Det är dag " + day + ":");
                //Kontrollerar om det finns några blad kvar.
                if (leaf.Level == 0)
                {
                    Console.WriteLine("Det är slut på blad. Alla växtätare kommer nu att dö. Köttätarna kan dock äta de döda växtätarna och klara sig ett tag till...");
                    Console.WriteLine("Programmet avslutas");
                    Console.ReadKey();
                    break;
                }
                //Kontrollerar om det finns några köttbitar kvar.
                if (meat.Level == 0)
                {
                    Console.WriteLine("Det är slut på kött. Alla köttätare komer nu att dö.");
                    Console.WriteLine("Programmet avslutas");
                    break;
                }

                //Går igenom animalsList och ökar hungernivån på samtliga djur med 1. 
                foreach (Animal animal in animalsList)
                {
                    animal.HungerLevel++;

                    //Om djurens hungernivå och nivån då dom är hungriga är lika så ändras djurens (objektets) bool Is.Hungry till "true".
                    if (animal.HungryAt == animal.HungerLevel)
                    {
                        animal.IsHungry = true;
                    }
                }

                //Går igenom animalsList och jämför vilka djur vars hunger nivå INTE är lika stor som om dom är hungriga.
                //Text skrivs ut om att dessa inte behöver äta.
                foreach (Animal animal in animalsList)
                {
                    if (animal.HungryAt != animal.HungerLevel)
                        Console.WriteLine(animal.Type + "en " + animal.Name + " behöver inte äta.");
                }

                //loopar anialsList.
                foreach (Animal animal in animalsList)
                {
                    //Om djurens bool IsHungry är true (djuren måste äta).
                    if (animal.IsHungry == true)
                    {   
                        //Om djuret i fråga äter kött.
                        if (animal.FoodType == "meat")
                        {
                            //Kör metoder Eat(meat) samt skriver ut djurets typ, namne, att den åt en bit kött samt hur mycket kött som finns kvar.
                            animal.Eat(meat);
                            Console.WriteLine(animal.Type + "en " + animal.Name + " var hungrig och åt en köttbit." + meat);
                        }
                        //Om djuret i fråga äter blad.
                        else if (animal.FoodType == "leaf")
                        {
                            //Kör metoder Eat(leaf) samt skriver ut djurets typ, namne, att den åt ett blad samt hur många blad som finns kvar.
                            animal.Eat(leaf);
                            Console.WriteLine(animal.Type + "en " + animal.Name + " var hungrig och åt ett löv." + leaf);
                        }
                        //Om djuret i fråga äter både kött och blad (björn).
                        else
                        {
                            //Om antalet kvarvarande blad är högre än 0.
                            if (leaf.Level > 0)
                            {
                                //Funktionen Eat(leaf) körs. Skriver ut djurets typ, namne, att den åt ett blad samt hur många blad som finns kvar.
                                animal.Eat(leaf);
                                Console.WriteLine(animal.Type + "en " + animal.Name + " var hungrig och åt ett blad." + leaf);
                            }
                            else
                            {
                                //Funktionen Eat(meat) körs. Skriver ut djurets typ, namne, att den åt en bit kött samt hur mycket kött som finns kvar.
                                animal.Eat(meat);
                                Console.WriteLine(animal.Type + "en " + animal.Name + " var hungrig och åt en köttbit." + meat);
                            }
                        }
                        //Efter att djuret har ätit sätts djurets bool IsHungry till false.
                        animal.IsHungry = false;
                    }
                }



                Console.ReadKey();
            }






        }
    }
}
