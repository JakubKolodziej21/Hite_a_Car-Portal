using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using L2Ex2.Data;
using L2Ex2.Models;


namespace L2Ex2.Pages.RentACar
{
    public class IndexModel : PageModel
    {
        private readonly L2Ex2.Data.L2Ex2Context _context;

        public IndexModel(L2Ex2.Data.L2Ex2Context context)
        {
            _context = context;
        }

        public IList<Reservations> Reservations { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        //public async Task OnGetAsync()
        //{
        //    // Use LINQ to get list of genres.
        //    IQueryable<string> genreQuery = from m in _context.Reservations
        //                                    orderby m.Genre
        //                                    select m.Genres;

        //    var movies = from m in _context.Reservations
        //                 select m;
        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        movies = movies.Where(s => s.Model.Contains(SearchString));
        //    }

        //    if (!string.IsNullOrEmpty(CarGenre))
        //    {
        //        movies = movies.Where(x => x.Genre == MovieGenre);
        //    }

        //    Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

        //    Reservations = await movies.ToListAsync();
        //}

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Reservations
                                            orderby m.Brand
                                            select m.Brand;

            var movies = from m in _context.Reservations
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Model.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Brand == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Reservations = await movies.ToListAsync();
        }
    }
}
