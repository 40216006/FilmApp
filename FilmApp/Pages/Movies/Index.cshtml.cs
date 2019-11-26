﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmApp.Data;
using FilmApp.Models;

namespace FilmApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FilmApp.Data.FilmAppContext _context;

        public IndexModel(FilmApp.Data.FilmAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
