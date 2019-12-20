using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarService.Models
{
    public class PartContext : DbContext
    {
        public PartContext(DbContextOptions<PartContext> options)
            : base(options)
        { }

        public DbSet<Part> Parts { get; set; }
    }
}
