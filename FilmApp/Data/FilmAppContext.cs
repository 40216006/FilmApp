using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmApp.Models;

namespace FilmApp.Data
{
    public class FilmAppContext : DbContext
    {
        public FilmAppContext (DbContextOptions<FilmAppContext> options)
            : base(options)
        {
        }

        public DbSet<FilmApp.Models.Movie> Movie { get; set; }
    }
}
