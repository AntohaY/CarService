using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models
{
    public class Report
    {
        public long id { get; set; }
        public long car_id { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        public int mileage { get; set; }
        public string comments { get; set; }

        public Report() { }
    }
}
