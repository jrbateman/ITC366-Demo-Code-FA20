using System;

namespace Chapter10
{
    class Program
     { 
        // Inheritance
        static void Main(string[] args)
        {
            // Extending Classes (Inheritance)

            var employee = new Employee();
            employee.DoWork();
            Console.WriteLine("");

            var dev = new SoftwareDeveloper();
            dev.DoWork();
            dev.WriteCode();
            Console.WriteLine("");

            Console.ReadLine();

        }

    }


        //Overriding Base Class Members

        //Understanding Implicit Reference Conversions

        // Using the Object Class

        // Creating and Using Abstract Classes

        /*
         Virtual methods have an implementation and provide the derived classes with the option of overriding it. 
         Abstract methods do not provide an implementation and force the derived classes to override the method.
         So, abstract methods have no actual code in them, and subclasses HAVE TO override the method. 
         Virtual methods can have code, which is usually a default implementation of something, 
         and any subclasses CAN override the method using the override modifier and provide a custom implementation.
         
         */

        // Creating and Using Interfaces

        // Using Extension Methods





    }

    class Employee
    {

        //don't make virtual the first time
        // make virtual to make availble to Software Developer

        public void DoWork()
        {
            Console.Write("Working");
        }
    }

    class SoftwareDeveloper : Employee
    {
       /* public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("... on software development.");
        }

        */

       public void WriteCode()
            {
                Console.WriteLine("Writing C# code.....");

            }

    /*
    class Employee
        {
        //private double salary;
        protected double salary;
        public int IdNum { get; set; }
        public double Salary
            {
            get
                {
                return salary;
                }

            set
                {
                const double MIN = 15_000;
                if (value < MIN)
                    salary = MIN;
                else salary = value;
                }
            }
        public string GetGreeting()
            {
            string greeting = "Hello. I am employee #" + IdNum;
            return greeting;
            }
        }
    class CommissionEmployee : Employee
        {
        //public double CommissionRate { get; set; }
        private double commissionRate;
        public double CommissionRate
            {
            get
                {
                return commissionRate;
                }

            set
                {
                commissionRate = value;
                salary = 0;

                }
            }
        }

    */


}
         



   