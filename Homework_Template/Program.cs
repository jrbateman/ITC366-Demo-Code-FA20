using System;

namespace Homework_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }
        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework ?");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }
        private static void DoExe1()
        {
            // Add code for Exercise 1 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }
        private static void DoExe2()
        {
            // Add code for Exercise 2 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }
        private static void DoExe3()
        {
            // Add code for Exercise 3 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }
        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }
        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }
    }
}
