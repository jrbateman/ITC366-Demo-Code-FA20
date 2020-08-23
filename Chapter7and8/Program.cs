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


            // ************************************ {Part 2 )

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

            // Passing Array Values to a Method
            // Passing by reference vs value (Reference change in the method)

            int[] someNums = { 10, 12, 22, 35 };
            int x;

            Console.Write("\nAt beginning of Main() method...   ");
            for (x = 0; x < someNums.Length; ++x)
                Console.Write("{0, 6}", someNums[x]);
            Console.WriteLine();
            Console.WriteLine();

            MethodGetsArray(someNums);
            Console.WriteLine();

            Console.Write("At end of Main() method..........");
            for (x = 0; x < someNums.Length; ++x)
                Console.Write("{0, 6}", someNums[x]);

            Console.WriteLine();


            // ************************************ {Part 3 )


            // Passing Parameters by Reference

            int xx = 4;
            Console.WriteLine();
            Console.WriteLine("Pass by Reference");
            Console.WriteLine("In Main x is {0}", xx);
            DisplayReferenceParameter(ref xx);
            Console.WriteLine("In Main x is {0}", xx);
            Console.WriteLine();

            // Returning a Reference from a Method

            int xxx = 4;
            Console.WriteLine();
            Console.WriteLine("Pass by Value");
            Console.WriteLine("In Main x is {0}", xxx);
            DisplayValueParameter(xxx);
            Console.WriteLine("In Main x is {0}", xxx);


            // ************************************ Part 4 )


            // Overloading Methods


            //Overloading involves the ability to write multiple versions of a method using the same method name. 
            //When you make a purchase at a store, you might use one of a variety of “pay” methods they accept, for example, cash, a credit card, or a check.The “pay” method works differently depending on the type of currency sent to it, but all of the transactions are called “pay.” 
            //When you overload a C# method, you write multiple method implementations with the same name but different parameter lists. 
            //A method’s name and parameter list constitute the method’s signature.

            //Press Ctrl + Shift + Space to see the list of overloads and arguments

            Console.WriteLine();
            DisplayWithBorder("Ed");
            DisplayWithBorder(3);
            DisplayWithBorder(456);
            DisplayWithBorder(897654);
            DisplayWithBorder("Veronica");
          

            }
        private static void DisplayValueParameter(int number)
            {

            number = 888;
            Console.WriteLine("In method, number is {0}", number);
            }
        private static void DisplayReferenceParameter(ref int number)
            {

            number = 888;
            Console.WriteLine("In method, number is {0}", number);

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
        private static void MethodGetsArray(int[] vals)
            {

            int x;

            Console.Write("In MethodGetsArray() ");

            for (x = 0; x < vals.Length; ++x)
                Console.Write(" {0}", vals[x]);
            Console.WriteLine();

            for (x = 0; x < vals.Length; ++x)
                vals[x] = 888;
            Console.Write("After change");

            for (x = 0; x < vals.Length; ++x)
                Console.Write(" {0}", vals[x]);
            Console.WriteLine();


            }
        private static void DisplayWithBorder(string word)
            {

            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x; 
            
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine("\n\n");
            }
        private static void DisplayWithBorder(int number)
            {

            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = EXTRA_STARS + 1;
            int leftOver = number;
            int x;

            while (leftOver >= 10)
                {
                leftOver = leftOver / 10; ++size;
                }
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + number + " " + SYMBOL);

            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);

            Console.WriteLine("\n\n");

            }
        }
    }