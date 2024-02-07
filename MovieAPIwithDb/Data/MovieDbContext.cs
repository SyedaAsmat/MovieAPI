using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAPIwithDb.Models;

namespace MovieAPIwithDb.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<MovieAPIwithDb.Models.Movie> Movie { get; set; } = default!;
    }
}
