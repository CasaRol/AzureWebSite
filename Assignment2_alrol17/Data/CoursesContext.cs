using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_alrol17.Models
{
    public class CoursesContext : DbContext
    {
        public CoursesContext (DbContextOptions<CoursesContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment2_alrol17.Models.Courses> Courses { get; set; }
    }
}
