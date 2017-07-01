using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarDemo.Models;
using CarDemo.Services;

namespace CarDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Car")]
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: api/Car
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _carService.GetAll();
        }

        // GET: api/Car/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var car = _carService.Get(id);
            if (car != null)
                return Ok(car);
            return NotFound();
        }

        // POST: api/Car
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.Add(car);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Car/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Car car)
        {
            if (id != car.CarId)
            {
                return NotFound();
            }            
            return Ok(_carService.Update(car));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _carService.Delete(id);
            return Ok(result);

        }
    }
}
