using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDemo.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int Year { get; set; }
        public int Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Cost { get; set; }
        public string Picture { get; set; }
    }
}
