using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars += 1;
        }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
            CarLot.numberOfCars += 1;
        }

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set;}
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } = true; //default value

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine($"Car goes {EngineNoise}");
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine($"Horn goes {HonkNoise}");
        }
    }
}
