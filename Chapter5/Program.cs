using System;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----- WHILE LOOP -----
            // You use the while loop when you want to execute
            // as long as a condition is true

            // This while loop will print odd numbers between
            // 1 and 10
            int i = 1;


            while (i <= 10)
            {
                // % (Modulus) returns the remainder of a
                // division. If it returns 0 that means the
                // value is even
                if (i % 2 == 0)
                {
                    i++;

                    // Continue skips the rest of the code and 
                    // starts execution back at the top of the 
                    // while
                    continue;
                }

                // Break jumps completely out of the loop
                if (i == 9) break;

                Console.WriteLine(i);
                i++;
            }

            // -----For LOOP -------
            // You begin a for statement with the keyword for followed by a set of parentheses.
            // Within the parentheses are three sections separated by exactly two semicolons.
            // The three sections are usually used for: 
            //  1. Initializing the loop control variable
            //  2. Testing the loop control variable
            //  3. Updating the loop control variable


            // Declare loop control variable and limit 
            int x; 
              const int LIMIT = 10;

            // Using a for loop to display 1 through 10 

            for (x = 1; x <= LIMIT; ++x)
                Console.WriteLine(x);

            Console.WriteLine();

            // snippet for [tab] [tab]
            // pay attention to the starting index 0 or 1

            const int TIMES = 4;

            for (int y = 0; y < TIMES; y++)
            {

                Console.WriteLine("Hello"); 
                Console.WriteLine("Goodbye");
                Console.WriteLine();
            }


            Console.WriteLine();

          

            // ----- DO WHILE LOOP -----
            // Use do while when you must execute the code
            // at least once

            // Generate a random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;


            do
            {
                Console.Write("Enter a number between 1 & 10 : ");

                // Use Convert to switch the string into an int
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it is was {0}",
                secretNumber);

        }
    }
}
