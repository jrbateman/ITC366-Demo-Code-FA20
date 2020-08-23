using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter9
    {
    class Animal
        {

        // Attributes (fields/properties) that all Animals have
        // public means can be directly changed
        // after an object has been created
        public string name;
        public string sound;


        // A constructor sets default values for 
        // fields when an object is created
        // This is the default constructor if no
        // parameters are sent
        public Animal()
            {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;
            }

        // You can create additonal constructors
        // but since we are definig defaults you
        // don't have to

        //Discuss change name to _name
        // and why you use this
        public Animal(string name)
            {
            // This refers to this objects name
            // instead of the name passed into
            // the constructor
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
            }

        public Animal(string name = "No Name", string sound = "No Sound")
            {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;

            }

        // Capabilities/Behaviors (methods) that all Animals have
        public void MakeSound()
            {
            Console.WriteLine("{0} says {1}",
                name, sound);
            GetNumAnimals();
            }

        // static fields and methods belong to the class
        // A static field has the same value for all
        // objects of the Animal type

        static int numOfAnimals = 0;


        public static int GetNumAnimals()
            {
            return numOfAnimals;

            }

        public override string ToString()
        {


            return string.Format($"This animal's name is {name} and it's sounds is {sound}");
           

        }
    }
    }
