using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models
{
    public class Part
    {
        public long id { get; set; }
        public long car_id { get; set; }
        public string name { get; set; }
        public bool available { get; set; }

        public Part() { }
    }
}
