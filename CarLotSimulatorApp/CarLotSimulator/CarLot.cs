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

        public static int numberOfCars;
    }
}