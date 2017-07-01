using CarDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDemo.Services
{
    public class CarService : ICarService
    {
        private CarContext _carContext;
        public CarService(CarContext carContext)
        {
            _carContext = carContext;
        }


        public bool Add(Car car)
        {
            try
            {
                _carContext.Cars.Add(car);
                _carContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Car> GetAll()
        {
            return _carContext.Cars.ToList();
        }

        public Car Get(int carId)
        {
            return _carContext.Cars.FirstOrDefault(x => x.CarId == carId);
        }

        public bool Delete(int carId)
        {
            try
            {
                var car = _carContext.Cars.FirstOrDefault(x => x.CarId == carId);
                if (car != null)
                {
                    _carContext.Remove(car);
                    _carContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        public Car Update(Car car)
        {
            var resultCar = _carContext.Cars.FirstOrDefault(x => x.CarId == car.CarId);
            if (car != null)
            {
                resultCar.Color = car.Color;
                resultCar.Cost = car.Cost;
                _carContext.Update(resultCar);
                _carContext.SaveChanges();
            }
            return car;
        }
    }
}
