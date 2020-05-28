using System;

namespace Chapter_2

{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variables
            int Age;
            int myAge = 25;
            int yourAge = 19;

            int myAge2 = 25, yourAge2 = 19;


            // Displaying Variable Values
            double someMoney = 39.45;
            Console.WriteLine(someMoney);

            double someMoreMoney = 39.45;
            Console.Write("The money is $");
            Console.WriteLine(someMoreMoney);


            Console.WriteLine("The money is $" + someMoney);

            // Placeholder
            string mySentence = String.Format("The money is ${0} exactly", someMoney);
            Console.WriteLine(mySentence);

            // String Interpolation
            string yourSentence = $"The money is ${someMoney} exactly";
            Console.WriteLine(yourSentence);

            // shortcut with the Write() and WriteLine() methods.
            Console.WriteLine("The money is ${0} exactly", someMoney);
            Console.WriteLine($"The money is ${someMoney} exactly");
            Console.WriteLine($"The money is {someMoney} exactly");
            Console.WriteLine($"The money is {someMoney.ToString("c")} exactly");
            Console.WriteLine($"The money is {someMoney:c} exactly");

            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            //Display two Variable within a single call
            Console.WriteLine("The money is {0} and my age is {1}", someMoney, myAge);
            Console.WriteLine($"The Money is {someMoney} and my age is {myAge}");


            //*******************************************************************************************


            // Integral Data Types
            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);


            // Floating Point Data Types

            // Using Arithmetic Operators

            // bool Data Type

            // Numeric Type Conversion

            // char Data Type

            // Named Constants

            //Accepting Console Input









        }
    }
}
