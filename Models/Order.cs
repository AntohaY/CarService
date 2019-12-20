using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarService.Models;

namespace CarService.Models
{
    public class Order
    {
        public long id { get; set; }
        public long car_id { get; set; }
        public bool warrant { get; set; } // if mileage < 100 000
        public string brand { get; set; }
        public string parts { get; set; } //array of ids
        public Order() { }
    }
}
