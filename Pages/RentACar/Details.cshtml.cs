using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using L2Ex2.Data;
using L2Ex2.Models;

namespace L2Ex2.Pages.RentACar
{
    public class DetailsModel : PageModel
    {
        private readonly L2Ex2.Data.L2Ex2Context _context;

        public DetailsModel(L2Ex2.Data.L2Ex2Context context)
        {
            _context = context;
        }

      public Reservations Reservations { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Reservations == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations.FirstOrDefaultAsync(m => m.Id == id);
            if (reservations == null)
            {
                return NotFound();
            }
            else 
            {
                Reservations = reservations;
            }
            return Page();
        }
    }
}
