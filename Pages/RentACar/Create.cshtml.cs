using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using L2Ex2.Data;
using L2Ex2.Models;

namespace L2Ex2.Pages.RentACar
{
    public class CreateModel : PageModel
    {
        private readonly L2Ex2.Data.L2Ex2Context _context;

        public CreateModel(L2Ex2.Data.L2Ex2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Reservations Reservations { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Reservations == null || Reservations == null)
            {
                return Page();
            }

            _context.Reservations.Add(Reservations);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
