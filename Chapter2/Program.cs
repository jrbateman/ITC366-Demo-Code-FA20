﻿using System;
using System.Numerics;

namespace Chapter_2

{
    class Program
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            // Declaring Variables
            /*
                Variable -  A named location in computer memory that can hold different values at different points in time
                Data type - Describes the format and size of(amount of memory occupied by) a data item

                A declaration includes the following:
                        The data type that the variable will store
                        The variable’s name (its identifier)
                        An optional assignment operator and assigned value when you want a variable to contain an initial value
                        An ending semicolon

            */

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
            //Types that store whole numbers
            //     byte, sbyte, short, ushort, int, uint, long, ulong, and char

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



            //*******************************************************************************************


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
            Console.WriteLine(
                "The two zeros to the right of the decimal point in the assigned value will not appear in the output because they add no mathematical information. ");
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
            // + addition
            // - subtraction
            // * multiplication
            // / division
            // % modulus (remainder)

            int i = 1;
            int j = 2;
            int result = i + j;
            Console.WriteLine($"i + j = {result}");
            Console.WriteLine();

            int result2 = i - j;
            Console.WriteLine($"i - j = {result2}");
            Console.WriteLine();

            int result3 = i * j;
            Console.WriteLine($"i * j = {result3}");
            Console.WriteLine();

            int result4 = i / j;
            Console.WriteLine($"i / j = {result4}");
            Console.WriteLine();


            i = i + 5;
            Console.WriteLine($"i + 5 = {i}");
            Console.WriteLine();
            i += 5;
            Console.WriteLine($"i += 5 = {i}");
            Console.WriteLine();
            i++;
            Console.WriteLine($"i++ = {i}");
            Console.WriteLine();
            i--;
            Console.WriteLine($"i--= {i}");
            Console.WriteLine();


            int myInteger = (5 + 1) * 7;
            Console.WriteLine(myInteger.ToString());
            Console.WriteLine();

            double myDouble = 5.5;
            myInteger = 7;
            int myOtherInteger = 4;

            Console.WriteLine("myDouble = 5.5, myInteger = 7, myOtherInteger = 4");
            Console.WriteLine();

            double myResult = myDouble + myInteger;
            Console.WriteLine($"mDouble + myInteger = {myResult}");
            Console.WriteLine();

            int myResult2 = (int) myDouble + myInteger;
            Console.WriteLine($"(int) mDouble + myInteger = {myResult2}");
            Console.WriteLine();

            int myResult3 = myInteger / myOtherInteger;
            Console.WriteLine($"myInteger/myOtherInteger = {myResult3}");
            Console.WriteLine();

            double myResult4 = (double) myInteger / (double) myOtherInteger;
            Console.WriteLine($"(double)myInteger / (double)myOtherInteger = {myResult4}");
            Console.WriteLine();

            var mod = myInteger % myOtherInteger;
            Console.WriteLine($"myInteger % myOtherInteger = {mod}");
            Console.WriteLine();

            //*******************************************************************************


            // bool Data Type
            // Bools store true or false
            bool canIlegallyDrink = true;
            Console.WriteLine(canIlegallyDrink);

            bool b = false;
            Console.WriteLine(b);

            // WriteLine automatically converts the value of b to text.
            Console.WriteLine(b);

            bool isBigger = 6 > 5; // Value stored would be true
            bool isSmallerOrEqual = 7 <= 4; // Value stored would be false

            int hoursWorked = 50;
            int annualIncome = 90000;
            bool doesEmployeeReceiveOvertime = hoursWorked > 40;
            bool isHighTaxBracket = annualIncome > 100000;


            // Numeric Type Conversion

            /*       
                int i;
                i = "3";
            */

            /*
                int i = 2000000000;
                long j = i;
            */

            /*    
                long i = 2000000000;
                int j = (int)i;
            */

            /*

                double kk = 2.5;
                int jj = (int)kk;


                int j = int.Parse(i);
                int k = j + 1;

            */

            // char Data Type
            // use the char data type to hold any single character. 
            char initial = 'D';
            char aCharValue = '9';

            // non printing characters
            // use a "\" or escape sequence for these chars
            char aBackspaceChar = '\b';
            char aTabChar = '\t';

            Console.WriteLine("This line\tcontains two\ttabs");
            Console.WriteLine("This statement\ncontains a new line");
            Console.WriteLine("This statement sounds an alert \a");
            Console.WriteLine();


            //https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019


            // Named Constants
                //By definition, a variable’s value can vary or change.
                //Sometimes you want to create a named constant,
                //an identifier for a memory location whose contents cannot change
                

                const int INCHES_IN_A_FOOT = 12;

                int lengthInFeet = 2;
                int lengthInInches;

                lengthInInches = lengthInFeet * INCHES_IN_A_FOOT;

                Console.WriteLine(lengthInInches);
                Console.WriteLine();

            // Working with Enumerations (enums)
                // Define above the Main();
                // By default, enumeration values are integers.
                //When you do not supply values for the items in an enum list,
                    //they start with 0 and are automatically increased by 1.
                /*
                  public enum Season
                    {
                        Spring,
                        Summer,
                        Autumn,
                        Winter
                    }
                 */

                Season a = Season.Autumn;
                Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

                var bb= (Season)1;
                Console.WriteLine(bb);  // output: Summer

                var cc = (Season)3;
                Console.WriteLine(cc);  // output: Winter

            //Accepting Console Input
                //The Read() method is similar to the ReadLine() method.
                //Read() reads just one character from the input stream, 
                //ReadLine() reads every character in the input stream until the user presses Enter.

                // Using Convert Class
                string myString = Console.ReadLine();

                const double TAX_RATE = 0.06; 
                string itemPriceAsString; 
                double itemPrice; 
                double total; 

                Console.Write("Enter the price of an item >> "); 
                itemPriceAsString = Console.ReadLine(); 
                itemPrice = Convert.ToDouble(itemPriceAsString); 
                total = itemPrice * TAX_RATE; 
                Console.WriteLine("With a tax rate of {0}, a {1} item 1 costs {2} more.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));
                Console.WriteLine();

                // Using Parse Methods    <-- preferred way
                Console.Write("Enter the price of an item >> ");
                itemPriceAsString = Console.ReadLine();
                itemPrice = double.Parse(itemPriceAsString);
                total = itemPrice * TAX_RATE;
                Console.WriteLine("With a tax rate of {0}, a {1} item 1 costs {2} more.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));



        }

    }

}


