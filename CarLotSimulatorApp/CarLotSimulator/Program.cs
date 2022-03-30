using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE

            var carLot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars - DONE
            var car1 = new Car(2013, "BMW", "1 Series");
            car1.EngineNoise = "Vroom Vroom";
            car1.HonkNoise = "Honk";
            car1.IsDriveable = "??";
            carLot.carList.Add(car1);

            var car2 = new Car() { Year = 2019, Make = "FIAT", Model = "124 Spider" };
            car2.EngineNoise = "Vrooom";
            car2.HonkNoise = "Bum Bumm";
            car2.IsDriveable = "??";
            carLot.carList.Add(car2);

            var car3 = new Car();
            car3.Year = 1995;
            car3.Make = "GMC";
            car3.Model = "1500 Club Coupe";
            car3.EngineNoise = "Zoom";
            car3.HonkNoise = "Beep Beep";
            car3.IsDriveable = "??";
            carLot.carList.Add(car3);

            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car - DONE

            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            foreach (var item in carLot.carList)
            {
                Console.WriteLine($"The car is a { item.Year} {item.Make} {item.Model}.");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - DONE

            //*************BONUS X 2*************//

            //Create a CarLot class - DONE
            //It should have at least one property: a List of cars - DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - DONE
        }
    }
}
