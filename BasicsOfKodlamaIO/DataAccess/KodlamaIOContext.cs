using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class KodlamaIOContext : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("");
            }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Category> Categories { get; set; }

    }
}
