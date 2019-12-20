using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models
{
    public class Car
    {
        public long id { get; set; }
        public string model { get; set; }
        public bool used { get; set; }
        public string brand { get; set; }

        public Car() { }
    }
}
