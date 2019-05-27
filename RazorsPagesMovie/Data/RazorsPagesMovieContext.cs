using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorsPagesMovie.Models
{
    public class RazorsPagesMovieContext : DbContext
    {
        public RazorsPagesMovieContext (DbContextOptions<RazorsPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorsPagesMovie.Models.Movie> Movie { get; set; }
    }
}
