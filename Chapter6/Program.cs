using System;
using System.Collections.Generic;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {


            // ----- ARRAYS -----
            // Arrays are just boxes inside of a bigger box
            // that can contain many values of the same
            // data type
            // Each item is assigned a key starting at 0
            // and incrementing up from there

            // Define an array which holds 3 values
            // Arrays have fixed sizes
            int[] favNums = new int[3];

            // Add a value to the array
            favNums[0] = 23;

            // Retrieve a value 
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // Create and fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the 
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };

            Vehicle[] vehicleArray = new Vehicle[100];

            vehicleArray[0] = new Vehicle();
            vehicleArray[0].Speed = 125.2;
            vehicleArray[0].Wheels = 4;

            // GetType knows its true type

            Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());
            Console.WriteLine("vehicle wheels at  0: {0}", vehicleArray[0].Wheels.GetType());

            // Get number of items in array
            Console.WriteLine("Array Size : {0}",
                    randomArray.Length);

            // Use for loop to cycle through the array
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                i, randomArray[i]);
            }

            foreach (var num in randomArray)
            {
                Console.WriteLine("Array Element  : Value : {0}",
                   num);
            }

            Console.ReadLine();

            // List verses Arrays
            // Do not have to be initialized with at length
            // Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.


            List<Vehicle> listOfVechVehicles = new List<Vehicle>();
            List<Vehicle> listOfVechVehicles2 = new List<Vehicle>
            {

                new Vehicle() {Brand = "Ford", Speed = 50, Wheels = 4},
                new Vehicle() {Brand = "Chevy", Speed = 50, Wheels = 4},
                new Vehicle() {Brand = "Dodge", Speed = 50, Wheels = 4},

            };
            foreach (var vehicle in listOfVechVehicles2)
            {
                Console.WriteLine(vehicle.Brand);
                Console.WriteLine(vehicle.Wheels);
                Console.WriteLine();
            }

            {

            }

            Console.WriteLine(listOfVechVehicles2.Count.ToString());
            // Multidimensional arrays
            // When you define an array like arrName[5] you
            // are saying you want to create boxes stacked 
            // vertically

            // If you define arrName[2,2] you are saying
            // you want to have 2 rows high and 2 across
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } };

            // Get value in MD array
            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 1));

            // Cycle through the multidimensional array
            // Get length of multidimensional array column
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                // Get length of multidimensional array row
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0} ", custNames[i, j]);
                }
                Console.WriteLine();
            }

            // An array like arrName[2,2,3] would be like a 
            // stack of 3 spread sheets with 2 rows and 2
            // columns worth of data on each page

            // foreach can be used to cycle through an array
            int[] randNums = { 1, 4, 9, 2 };

            // You can pass an array to a function
            PrintArray(randNums, "ForEach");

            // Sort array
            Array.Sort(randNums);

            // Reverse array
            Array.Reverse(randNums);

            // Get index of match or return -1
            Console.WriteLine("1 at index : {0} ",
                Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);

            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray,
                startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

            // Search for an element that matches the conditions
            // defined by the specified predicate
            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));

        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }
    }
}
