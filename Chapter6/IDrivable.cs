namespace Chapter6
{
    internal interface IDrivable
    {
        // Interfaces can have properties
        int Wheels { get; set; }
        double Speed { get; set; }

        // Classes that inherit an interface
        // must fulfill the contract and 
        // implement every abstract method
        void Move();
        void Stop();

    }
}