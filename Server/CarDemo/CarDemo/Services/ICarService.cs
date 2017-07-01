using CarDemo.Models;
using System.Collections.Generic;

namespace CarDemo.Services
{
    public interface ICarService
    {
        bool Add(Car car);
        List<Car> GetAll();
        Car Get(int carId);
        bool Delete(int carId);
        Car Update(Car car);
    }
}
