using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;

//Player interaction / Menu

//Show all creatures in the world
    //use a foreach loop to call their Communicate methods
//Choose a creature
    //Search the list/array of creature instances for a specific creature
//With the chosen creature, communicate or talk
    //Use Random to pass a random item from the food/item list to critter's Eat method
//Add Item/Food
    //Allow the player to add an item or food(ask for the information to fill in properties)
//Add Creature Instance
//Allow the player to add an instance(pick from available critter types)
//Ask for the information to fill in properties(for example, name or color)


namespace UnderWater
{
    public class TidePool
    {
        List<Creature> Creatures = new List<Creature>
        {
            new Starfish("Gloria" , "Has 5 arms that can regenerate ", "Chirp", 3, "covered in pedicellaria spikes", "oysters", "Female"),
            new Angelfish ("Alistair", "Is diamond shaped with vertial stripes", "Harp Strings", 3, "Poisonous", "worms", "Male" ),
            new Shrimp ("Wilmer", "Has a long fanshaped tail", "Clicking", 1 ,"Speed", "Algae", "Male" ),
            new SeaSlug ("Reuben", "Is a long wormlike gastropods", "Screeching", 6, "Projectile","decaying matter", "Male" ),
            new Gooseneck ("Gem", "Has a chalky white shell, anchored with a black stalk", "Snapping", 1, "Sturdy Shell", "Filter Feeder", "Female" ),
            new Sculpin ("Marina ", "Has a wide, heavy head and spiky fins", "Tuba sounds", 7,"razor sharp fins", "everything", "Female")
        };
        List<Item> Items = new List<Item> { new Food(), new Item() };

        public TidePool()
        {
            Menu();

        }
        private void Menu()
        { string input;

            WriteLine("1) See all things living in the Tide Pool ");
            WriteLine("2) ??????");
            WriteLine("3) ?????");
            WriteLine("4) ?????");
            WriteLine("5) Exit Application");

            WriteLine("Please enter the coresponding number of your choice: ");
            input = ReadLine();


            switch (input)
            {
                case "1":
                    ShowAllCreatures();//
                    break;


                case "2":
                    break;


                case "3":
                    break;


                case "4":
                    break;


                case "5":
                    Environment.Exit(0);
                    break;


                default:
                    WriteLine("Please chose a valid option. Press enter to continue");
                    ReadKey();
                    Menu();
                    break;
            }




            ReadKey();
            Menu();
        }
        private void ShowAllCreatures()
        {
            foreach (Creature creature in Creatures)
            {
                WriteLine(creature.Name + " : " + creature.Description);
                WriteLine (creature.Talk());
                WriteLine("");
            }
            WriteLine("Press 'Enter' to continue");
            ReadKey();
        }
            
    }
 
}

