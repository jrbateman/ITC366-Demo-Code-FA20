using System;
using System.Numerics;

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
            Console.WriteLine();

            //*******************************************************************************************


            // Integral Data Types
                // INTEGERS
                // Integers are 32-bit signed integers. Signed Ints can be negative. Unsigned cannot be negative
                    Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
                    Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
                // Longs are 64-bit signed integers
                Console.WriteLine("Biggest Long : {0}", long.MaxValue);
                Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // BIGINTEGER
                // Used to store very large numbers
                // Select Project -> Add Reference
                // Select Assemblies -> System.Numerics.dll click Ok
                // Add this line using System.Numerics; at the top
                // Define the value using a text literal
                BigInteger bigNum = BigInteger.Parse("12345123451234512345");
                Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);
                Console.WriteLine();
                
                // Other Integral Data Types
                // short : 16-bit signed int -32,768 to 32,767
                // uint : 32-bit unsigned int 0 to 4,294,967,295
                // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
                // ushort : 16-bit unsigned int 0 to 65,535


            // Floating Point Data Types
                // C# supports three floating-point data types: float, double, and decimal

            // FLOATS
                // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

                // It is precise to 7 digits
                float fltPiVal = 3.141592F;
                float fltBigNum = 3.000002F;
                Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);
                Console.WriteLine();
            
            // DOUBLES
                // Doubles are 64-bit float types
                // A double data type can hold 15 or 16 significant digits of accuracy.
                // A double given the value 123456789.987654321 will appear as 123456789.987654
                double dblNumber = 123456789.987654321D;
                Console.WriteLine($"The double 123456789.987654321 will appear as {dblNumber}");
                Console.WriteLine();

            // DECIMALS
                // Decimals store 128-bit precise decimal values
                // It is accurate to 28 digits
                decimal decPiVal = 3.1415926535897932384626433832M;
                decimal decBigNum = 3.00000000000000000000000000011M;
                Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

                Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
                Console.WriteLine();

                float flt = 1F / 3;
                double dbl = 1D / 3;
                decimal dcm = 1M / 3;
                Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);

            // Formatting Floating Point Numbers
                double myMoney = 14.00;
                Console.WriteLine("14.00 prints as {0}", myMoney);
                Console.WriteLine("The two zeros to the right of the decimal point in the assigned value will not appear in the output because they add no mathematical information. ");
                Console.WriteLine();

                double someMoney2 = 123; 
                string moneyString; 
                moneyString = someMoney2.ToString("F");
                Console.WriteLine($"The double 123 prints like this using the F string formatter {moneyString}");
                moneyString = someMoney2.ToString("F3");
                Console.WriteLine($"The double 123 prints like this using the F3 string formatter {moneyString}");
                Console.WriteLine();
            
            // *****************************************************************************************************

            // Using Arithmetic Operators

            // bool Data Type

            // Numeric Type Conversion

            // char Data Type

            // Named Constants

            //Accepting Console Input









        }
    }
}
