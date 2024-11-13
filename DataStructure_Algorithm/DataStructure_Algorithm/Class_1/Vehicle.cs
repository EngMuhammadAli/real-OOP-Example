namespace DataStructure_Algorithm.Class_1
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void Start()
        {
            Console.WriteLine($"Starting the {Make} {Model}...");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopping the {Make} {Model}...");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string model, int year, int numberOfDoors)
            : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public void Honk()
        {
            Console.WriteLine("Car is honking: Beep Beep!");
        }
    }

    // Derived class Motorcycle inheriting from Vehicle
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hasSidecar)
            : base(make, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public void RevEngine()
        {
            Console.WriteLine("Motorcycle is revving: Vroom Vroom!");
        }
    }
}