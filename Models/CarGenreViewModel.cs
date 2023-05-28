using Microsoft.AspNetCore.Mvc.Rendering;

namespace L2Ex2.Models
{
    public class CarGenreViewModel
    {
        public List<Reservations>? Reservations { get; set; }
        public SelectList? Brand { get; set; }
        public string? CarBrand { get; set; }
        public string? SearchString { get; set; }
    }
}
