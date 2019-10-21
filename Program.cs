using System;
using System.Collections.Generic;


namespace humans_and_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            // Gör en klass som heter Elephant som ärver ifrån Animal.
            // Gör likadant med en Lion som äter kött.
                        
            Animal elephantOne = new Animal("Dolores", "Elephant", 0);

            //Lista med samtiliga djur.
            List<Animal> animalsList = new List<Animal>();
            //Lista med hungriga växtätare.
            List<Animal> hungryVeggies = new List<Animal>();
            //Lista med hungriga köttätare.
            List<Animal> hungryMeaties = new List<Animal>();

            animalsList.Add(elephantOne);

            Console.WriteLine("Välkommen till djurparken!\nHär finns följande djur:");

            if (animalsList.Count != 0)
            {
                //loopar igenom listan animallist. 
                // Indexerar listan och kör metoden content på varje element i listan. 
                // Metoden content ligger i varje klass.  

                for (int i = 0; i < animalsList.Count; i++)
                {
                    // Det hade då räckt med att skriva ut objektet utan metodanrop.
                    // Om du hade en ToString().
                    // Console.WriteLine(animalsList[i]);

                    Console.WriteLine(animalsList[i].Content());
                }
            }
            Console.ReadKey();

            // Day loop
            int nrOfMeatLeft = 50;
            int nrOfVeggiesLeft = 5;
            int day = 0;
            bool loopOne = true;
            do
            {
                Console.Clear();
                day++;
                Console.WriteLine("Det är dag " + day + ":");

                elephantOne.HungerLevel++;

                //Om elefantens hungernivå nått upp till 3 läggs elefanten till i listan över växtätare
                //som behöver äta och dess hungernivå nollställs.
                if (elephantOne.HungerLevel == 3)
                {
                    hungryVeggies.Add(elephantOne);
                    elephantOne.HungerLevel = 0;
                }
                else
                {
                    Console.WriteLine("Inget djur är hungrigt.");
                }

                //Kör metoder Hungry som tar in listorna med hungriga växtätare och hungriga köttätare
                Hungry(hungryVeggies, hungryMeaties);


                //Animal.HungerLevel ++;
                //Kan man göra så?

                // if (elephantOne.HungerLevel == 3)
                // {
                //    elephantOne.HungerLevel = 0;

                //    if (nrOfVeggiesLeft > 0)
                //    {
                //        //Giraffen Pelle fick äta blad, det finns 49 blad kvar.
                //         Console.WriteLine(elephantOne.Type + "en " + elephantOne.Name + " äter ett blad.");
                //         nrOfVeggiesLeft --;
                //         Console.WriteLine("Det finns " + nrOfVeggiesLeft + " blad kvar.");
                //    }

                // }
                // else
                // {
                //     Console.WriteLine("Inget djur är hungrigt.");
                //     Console.WriteLine("Det finns " + nrOfVeggiesLeft + " blad och " + nrOfMeatLeft + " köttbitar kvar.");
                // }
                // LÄGG TILL DIN NYA KOD HÄR

                // Wait for the next day

                //Console.WriteLine("TEST TEST TEST!");
                //Console.WriteLine(elephantOne.ToString());
                Console.ReadKey();
            }while (loopOne);

            //Metoder Hungry. Tar emot två listor. Om listan veggies innehåller något så går den igenom den och skriver ut innehållet
            //samt drar av ett blad från variablen nrOfVeggiesLef.
            void Hungry(List<Animal> veggies, List<Animal> meaties)
            {
                if (veggies.Count != 0)
                {
                    for (int i = 0; i < veggies.Count; i++)
                    {
                        if (nrOfVeggiesLeft > 0)
                        {

                            Console.Write(veggies[i].Content());
                            Console.WriteLine(" äter ett blad.");
                            nrOfVeggiesLeft--;
                            Console.WriteLine("Det finns " + nrOfVeggiesLeft + " blad kvar.");
                        }
                        else
                        {
                            Console.WriteLine("Det är slut på blad. Djuren dör och programmet avslutas...");
                            loopOne = false;
                            break;
                            
                        }
                    }
                }
                hungryVeggies.Clear();
            }


        }
    }
}
