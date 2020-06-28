using System;

namespace Chapter10
{
    class Program
     { 
        // Inheritance
        static void Main(string[] args)
        {
            // Extending Classes (Inheritance)
            
            Employee emp = new Employee();
            emp.IdNum = 1;
            var greeting = emp.GetGreeting();
            Console.WriteLine(greeting);


            Console.WriteLine();

            CommissionEmployee ce = new CommissionEmployee();
            ce.IdNum = 2;
            ce.CommissionRate = .20;
            var greeting2 = ce.GetGreeting();
            Console.WriteLine(greeting2);

            Console.WriteLine();

            // Protected Access

            /*
             Protected access, which provides you with an intermediate level of security between public and private access.
             A protected data field or method can be used within its own class or in any classes extended from that class, 
             but it cannot be used by “outside” classes.
             In other words, protected members can be used “within the family”—by a class and its descendants.
            */

            CommissionEmployee salesperson = new CommissionEmployee(); 
            salesperson.IdNum = 567; 
            salesperson.Salary = 20000.00; 
            salesperson.CommissionRate = 0.06; 
            Console.WriteLine(" Salesperson #{0} salary: {1} per year", salesperson.IdNum, salesperson.Salary.ToString("C"));
            Console.WriteLine("...plus {0} commission on all sales", salesperson.CommissionRate.ToString("P"));

            }


            //Overriding Base Class Members

            //Understanding Implicit Reference Conversions

            // Using the Object Class

            // Creating and Using Abstract Classes

            // Creating and Using Interfaces

            // Using Extension Methods





        }

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
       
     }
         



   