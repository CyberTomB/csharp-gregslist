using System;
using System.Collections.Generic;
using csharp_gregslist.Models;
using csharp_gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_gregslist.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _carsService;
    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get(){
      try
      {
        IEnumerable<Car> cars =  _carsService.Get();
        return Ok(cars);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _carsService.Create(newCar);
        return Ok(car);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}