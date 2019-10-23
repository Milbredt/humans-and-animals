using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            List<Animal> animalsList = new List<Animal>();

            // Elephant elephant = new Elephant("Dolores");
            // animalsList.Add(elephant);
            // elephant = new Elephant("Flores");
            // animalsList.Add(elephant);

            // Giraffe giraffe = new Giraffe("Charlie");
            // animalsList.Add(giraffe);

            // Coyote coyote = new Coyote("Huff");
            // animalsList.Add(coyote);
            // coyote = new Coyote("Puff");
            // animalsList.Add(coyote);

            Seal seal = new Seal("Bobby");
            animalsList.Add(seal);

            // Bear bear = new Bear("Bobo");
            // animalsList.Add(bear);




            Leaf leaf = new Leaf(50);
            Meat meat = new Meat(10);

            Console.WriteLine("Välkommen till djurparken!\nHär finns följande djur:\n");

            if (animalsList.Count != 0)
            {
                //loopar igenom listan animallist. 
                // Indexerar listan och kör metoden content på varje element i listan. 
                // Metoden content ligger i varje klass.  
                for (int i = 0; i < animalsList.Count; i++)
                {
                    Console.WriteLine(animalsList[i].Content());
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
                if (leaf.Level == 0)
                {
                    Console.WriteLine("Det är slut på blad. Alla växtätare kommer nu att dö. Köttätarna kan dock äta upp deras lik och leva ett tag till...");
                    Console.WriteLine("Programmet avslutas");
                    Console.ReadKey();
                    break;
                }
                if (meat.Level == 0)
                {
                    Console.WriteLine("Det är slut på kött. Alla köttätare komer nu att dö.");
                    Console.WriteLine("Programmet avslutas");
                    break;
                }



                foreach (Animal animal in animalsList)
                {
                    animal.HungerLevel++;

                    if (animal.HungryAt == animal.HungerLevel)
                    {
                        animal.IsHungry = true;
                    }
                }

                foreach (Animal animal in animalsList)
                {
                    if (animal.HungryAt != animal.HungerLevel)
                        Console.WriteLine(animal.Type + "en " + animal.Name + " behöver inte äta.");
                }

                foreach (Animal animal in animalsList)
                {
                    if (animal.IsHungry == true)
                    {

                        animal.Eat();
                        Console.WriteLine(animal.Type + "en " + animal.Name + " var hungrig och åt ett blad." + leaf);
                        animal.IsHungry = false;
                    }
                }



                Console.ReadKey();
            }






        }
    }
}
