using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }


        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set;}
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public string MakeEngineNoise(string EngineNoise)
        {
            return "Vroom Vroom";
        }

        public string MakeHonkNoise(string HonkNoise)
        {
            return "Beep Beep";
        }
    }
}
