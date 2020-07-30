using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;
namespace UnderWater
{
    public class Creature
    {
        public string Name;
        public string Description;
        public string Sound;
        int Size;
        string Defense;
        string Diet;
        string Gender;

        public Creature()
        {

        }
        public Creature(string name, string description, string sound,
                        int size, string defense, string diet, string gender)
        {
            Name = name;
            Description = description;
            Sound = sound;
            Size = size;
            Defense = defense;
            Diet = diet;
            Gender = gender;

        }

        public void Eat(Item item)
        {
 //Eat - method should accept an item as an argument, and a response should be written to the screen
//TODO: Add conditional code
           //If the item is food the critter can eat it
            //If the item is not food, the critter will not eat it
            //How do you know if an object is a specific type? See assignment page for links!

           





        }
         public string Talk()
         {
            return $"{Name} comunicates with {Sound}.";
         }
          public void Sleep()
        { 
        }

     }

    public class Shrimp : Creature
    {
     

        public Shrimp() { }
        public Shrimp (string name, string description, string sound,
                        int size, string defense, string diet, string gender): base(name, description, sound, size, defense, diet, gender)
        {
            Name = name;
            Description = description;
        }
    }
    public class Starfish : Creature
    {
        public Starfish() { }
        public Starfish(string name, string description, string sound,
                        int size, string defense, string diet, string gender): base(name, description, sound, size, defense, diet, gender)
        {
            Name = name;
            Description = description;
        }

    }
    public class Angelfish : Creature
    {
        public Angelfish() { }
        public Angelfish(string name, string description, string sound,
                        int size, string defense, string diet, string gender) : base(name, description, sound, size, defense, diet, gender)
        {
            Name = name;
            Description = description;
        }

    }   
    public class SeaSlug : Creature
    {
        public SeaSlug() { }
        public SeaSlug(string name, string description, string sound,
                        int size, string defense, string diet, string gender) : base(name, description, sound, size, defense, diet, gender)
        {
            Name = name;
            Description = description;
        }

    }
    public class Gooseneck : Creature
    {//type of barnical
        public Gooseneck() { }
        public Gooseneck(string name, string description, string sound,
                        int size, string defense, string diet, string gender) : base(name, description, sound, size, defense, diet, gender)
        {
            Name = name;
            Description = description;
        }

    }
    public class Sculpin : Creature {
        public Sculpin() { }
        public Sculpin(string name, string description, string sound,
                        int size, string defense, string diet, string gender) : base(name, description, sound, size, defense, diet, gender)
        {
            Name = name;
            Description = description;
        }
    }

    


   }

