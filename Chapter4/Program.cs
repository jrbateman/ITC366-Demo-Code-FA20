using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Chapter4
{
    class Program
    {

        public enum Color { Red, Green, Blue }
        public enum Directions
        {
            Up,
            Down,
            Right,
            Left
        }
        public enum Orientation
        {
            North,
            South,
            East,
            West
        }

        static void Main(string[] args)
        {
            /*
            -----CONDITIONALS---- -
            -----IF / ELSE / -----
            Relational Operators: > < >= <= == !=
            Logical Operators: && || !
            */


         int age = 17;


            if (age >= 5 && age <= 7)
                Console.WriteLine("Go to elementary school");
            else if (age > 7 && age < 13)
                Console.WriteLine("Go to middle school");
            else if (age > 13 && age < 19)
                Console.WriteLine("Go to high school");
            else
                Console.WriteLine("Go to college");

            //add watch and change value

            if (age < 14 || age > 67)
                Console.WriteLine("You shouldn't work");

            Console.WriteLine("! true = " + (!true));

            // The Conditional or Ternary Operator
            // Assigns the 1st value if true and otherwise 
            // the 2nd

            bool canDrive = age >= 16 ? true : false;

            Console.WriteLine();

            /*
            Switch is a selection statement that chooses a single switch section to execute from a 
                list of candidates based on a pattern match with the match expression.
            The switch statement is often used as an alternative to an if-else construct 
                if a single expression is tested against three or more conditions. 
            For example, the following switch statement determines whether a variable of type Color has one of three values:
            */

            Color c = (Color)(new Random()).Next(0, 3);
            Console.WriteLine("Swich Statement");
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }

            Console.WriteLine();

            // Same thing using if-else

            Color c2 = (Color)(new Random()).Next(0, 3);
            Console.WriteLine("Same Comparison as Swich Statement but using If-Else");

            if (c2 == Color.Red)
                Console.WriteLine("The color is red");
            else if (c2 == Color.Green)
                Console.WriteLine("The color is green");
            else if (c2 == Color.Blue)
                Console.WriteLine("The color is blue");
            else
                Console.WriteLine("The color is unknown.");

            Console.WriteLine();

            // The match expression provides the value to match against the patterns in case labels. Its syntax is:
            //  switch (expr)

            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"An unexpected value ({caseSwitch})");
                    break;
            }


            /*
             Only one switch section in a switch statement executes. 
                C# doesn't allow execution to continue from one switch section to the next. 
                Because of this, the following code generates a compiler error, 
                CS0163: "Control cannot fall through from one case label (<case label>) to another."
             */


          /*
                switch (caseSwitch)
                {
                    // The following switch section causes an error.
                    case 1:
                        Console.WriteLine("Case 1...");
                    // Add a break or other jump statement here.
                    case 2:
                        Console.WriteLine("... and/or Case 2");
                        break;
                };
          */
           

            /*
             
            This requirement is usually met by explicitly exiting the switch section by using 
                a break, goto, or return statement. 
                However, the following code is also valid, 
                because it ensures that program control can't fall through to the default switch section. 
           
             */

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1...");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("... and/or Case 2");
                    break;
                case 4:
                    while (true)
                        Console.WriteLine("Endless looping. . . .");
                default:
                    Console.WriteLine("Default value...");
                    break;
            }

            Console.WriteLine();
            /*
            
            The default case
                The default case specifies the switch section to execute if the match expression doesn't match any other case label. 
                If a default case is not present and the match expression doesn't match any other case label, 
                program flow falls through the switch statement.

                The default case can appear in any order in the switch statement. 
                Regardless of its order in the source code, it's always evaluated last, after all case labels have been evaluated.

             */

            /*
                Switch features introduced in C# 8.0
                https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression
                The following example shows the structure of a switch expression. 
                It translates values from an enum representing visual directions in an online map to the corresponding cardinal direction:

            */

            var direction = Directions.Right;
            Console.WriteLine($"Map view direction is {direction}");

            var orientation = direction switch
            {
                Directions.Up => Orientation.North,
                Directions.Right => Orientation.East,
                Directions.Down => Orientation.South,
                Directions.Left => Orientation.West,
            };
            Console.WriteLine($"Cardinal orientation is {orientation}");
            Console.WriteLine();


            // Using the NOT operator
            // You use the NOT operator, which is written as an exclamation point ( ! ), 
            // to negate the result of any Boolean expression.

            age = 20;
            int premium;

            if (age < 26) premium = 200; 
            else premium = 125; 
            
            if (!(age < 26)) premium = 125; 
            else premium = 200; 
            
            if (age >= 26) premium = 125; 
            else premium = 200; 
            
            if (!(age >= 26)) premium = 200; 
            else premium = 125;

            Console.WriteLine($" Premium = {premium}");


            // Avoiding Common Errors When Making Decisions

            //	Using the assignment operator ( = ) instead of the comparison operator ( == ) when testing for equality

            int x = 5;

            if (x == 5)
               Console.WriteLine($" x =  {x}");

            // 	Failing to block a set of statements with curly braces when several statements depend on the if or the else statement


            if (x == 5)
                Console.WriteLine($" x =  {x}");
                Console.WriteLine("This will not execture in the If statement");

            if (x == 5)
            {
                Console.WriteLine($" x =  {x}");
                Console.WriteLine("This will not execture in the If statement");
            }

            Console.WriteLine();

            //  Performing Accurate and Efficient Range Checks
            int saleAmount = 1100;
            double commissionRate;

            if (saleAmount >= 1000)
                { commissionRate = 0.08; 
                  Console.WriteLine($"commission rate = {commissionRate}"); 
                }
            if (saleAmount >= 500)
                {
                commissionRate = 0.06;
                Console.WriteLine($"commission rate = {commissionRate}");
                }
            if (saleAmount <= 499)
                {
                commissionRate = 0.05;
                Console.WriteLine($"commission rate = {commissionRate}");
                }
        }
    }
}
