using System;

namespace Chapter7and8
{
    class Program
    {
        static void Main(string[] args)
        {
            //A method is an encapsulated series of statements that carry out a task. 
            //Any class can contain an unlimited number of methods. 

            // DRY = Don't Repeat Yourself


            // Creating and Calling Simple Methods

            ShowWelcomeMessage();
            Console.WriteLine("Hello");


            // Creating Methods that do not return a value
            // Declaring variables in a method (scope)

            int a = 12; 
            Console.WriteLine("In Main() a is {0}", a); 
            MethodWithItsOwnA();
            Console.WriteLine("In Main() a is {0}", a);


            // Creating Methods with a Single Input Parameter

            double salesAmount = 100.00;

            DisplaySalesTax(salesAmount);
            DisplaySalesTax(200.00);


            // Creating Methods with  Multiple Input Parameters

            // Returning Values from Methods
            }

        private static void ShowWelcomeMessage()
            {

            Console.WriteLine("Welcome To Intro to C#"); 
            Console.WriteLine("Have fun!"); 
            Console.WriteLine("Enjoy the class!");

            }
        private static void MethodWithItsOwnA()
            {
            int a = 354; 
            Console.WriteLine("In method a is {0}", a);

            }
        private static void DisplaySalesTax(double saleAmount)
            {
            double tax;
            const double RATE = 0.07;
            tax = saleAmount * RATE;
            Console.WriteLine("The tax on {0} is {1}",saleAmount, tax.ToString("C"));

            }


        }
}
