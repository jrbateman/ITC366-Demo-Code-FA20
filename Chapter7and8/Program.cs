using System;

namespace Chapter7and8

    // Methods

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
            Console.WriteLine();

            // Creating Methods that do not return a value
            // Declaring variables in a method (scope)

            int a = 12;
            Console.WriteLine("In Main() a is {0}", a);
            MethodWithItsOwnA();
            Console.WriteLine("In Main() a is {0}", a);
            Console.WriteLine();


            // Creating Methods with a Single Input Parameter

            double salesAmount = 100.00;

            DisplaySalesTax(salesAmount);
            DisplaySalesTax(200.00);
            Console.WriteLine();


            // Creating Methods with  Multiple Input Parameters

            const double RATE = 0.07;
            DisplaySalesTax(salesAmount, RATE);


            // Returning Values from Methods

            double myHours = 37.5; 
            double myRate = 12.75; 
            double grossPay;
            
            Console.WriteLine("I worked {0} hours at {1} per hour", myHours, myRate);
            
            grossPay = CalcPay(myHours, myRate);

            Console.WriteLine("My gross pay is {0}", grossPay.ToString("C"));
            Console.WriteLine();

            // Returning boolean Values

            Console.WriteLine("TestInput(0) = {0}", TestInput(0));
            Console.WriteLine("TestInput(1) = {0}", TestInput(1));
            Console.WriteLine("TestInput(5) = {0}", TestInput(5));
            Console.WriteLine("TestInput(11) = {0}", TestInput(11));
            Console.WriteLine();
            }

        private static double CalcPay(double myHours, double myRate)
            {
                double gross; 
                gross = myHours * myRate; 
                return gross;
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
            Console.WriteLine("The tax on {0} is {1}", saleAmount, tax.ToString("C"));

            }
        private static void DisplaySalesTax(double saleAmount, double taxRate)
            {
            double tax;
            tax = saleAmount * taxRate;

            Console.WriteLine("The tax on {0} at {1} is {2}", saleAmount.ToString("C"), taxRate.ToString("P"), tax.ToString("C"));

            }
        public static Boolean TestInput(int val)
            {
            if (val < 1 || val > 10)
                return false;
            return true;
            }

        }
}
