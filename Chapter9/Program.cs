using System;

namespace Chapter9
    {
    class Program

        {
        static void Main(string[] args)
            {
            /*
             ----- OBJECT ORIENTED PROGRAMMING -----
             A class models real world objects by
             defining their attributes (fields) and
             capabilities (methods)
           
             Add a class Project -> Add Class

             Create an Animal object
             You could also assign values like
             fox.name = "Red"

            */

            Animal fox = new Animal()
                {
                name = "Red",
                sound = "Raaaw"
                };

            Console.WriteLine(fox.ToString());

            Animal dog = new Animal();
            dog.name = "Bowser";
            dog.sound = "Ruff";


            Animal cow = new Animal("Betsy", "Moo");

            // Different way to instantiate a class and pass parameters
            Animal fox2 = new Animal("Red2", "Raaw2");

            // Call the static method
            Console.WriteLine("# of Animals {0}",
                Animal.GetNumAnimals());

            //Call instance methods
            // Show what happens when method is not public
            fox.MakeSound();
            fox2.MakeSound();

            Console.ReadLine();


            //*********************************************************************

            // Understanding Constructors
            // A constructor is a method that instantiates (creates an instance of ) an object. 
            //If you do not write a constructor for a class, then each class you create is automatically supplied with a public constructor with no parameters


            BankAccount myAccount = new BankAccount(25.00);


            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            myAccount.Deposit(700.00);

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(300.00) < 0)
                Console.WriteLine("Insufficient funds");

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            if (myAccount.Withdraw(450.00) < 0)
                Console.WriteLine("Insufficient funds");

            Console.WriteLine("My balance = {0:C}", myAccount.GetBalance());

            BankAccount yourAccount = new BankAccount();
            yourAccount.Deposit(1234.56);

            Console.WriteLine("Your balance = {0:C}", yourAccount.GetBalance());

            Console.ReadLine();


            }
        }
    }



