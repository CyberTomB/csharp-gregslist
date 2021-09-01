using System;
using System.Collections.Generic;
using csharp_gregslist.Models;

namespace csharp_gregslist.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> Get()
    {
      return FakeDB.Cars;
    }

    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }
  }
}