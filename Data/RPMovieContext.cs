using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPMovie.Models;

    public class RPMovieContext : DbContext
    {
        public RPMovieContext (DbContextOptions<RPMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RPMovie.Models.Movie> Movie { get; set; }
    }
