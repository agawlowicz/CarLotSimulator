using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }

        public List<Car> carList = new List<Car>(); //literally just a list doesn't need to be a property
    }
}

//Create a CarLot class - DONE
//It should have at least one member: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console