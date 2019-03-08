using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AlexanderRolOnlineCV.Models
{
    public class CoursesContext : DbContext
    {
        public CoursesContext (DbContextOptions<CoursesContext> options)
            : base(options)
        {
        }

        public DbSet<AlexanderRolOnlineCV.Models.Courses> Courses { get; set; }
    }
}
