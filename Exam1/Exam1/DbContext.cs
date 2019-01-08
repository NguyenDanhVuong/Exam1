using Exam1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        { }

        public DbSet<Exam1.Models.Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = "USD", Ratio = 23260 },
                new Movie { Id = "EUR", Ratio = 27061 },
                new Movie { Id = "AUD", Ratio = 16798 },
                new Movie { Id = "JPY", Ratio = 20704 }
            );
        }
    }
} 

