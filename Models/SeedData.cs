using L2Ex2.Data;
using Microsoft.EntityFrameworkCore;



namespace L2Ex2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new L2Ex2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<L2Ex2Context>>()))
            {
                if (context == null || context.Reservations == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Reservations.Any())
                {
                    return;   // DB has been seeded
                }

                context.Reservations.AddRange(
                    new Reservations
                    {
                        ReservationDate = DateTime.Now.AddDays(-1),
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(3),
                        Name = "John",
                        Surname = "Doe",
                        PhoneNumber = "123456789",
                        Contact = "john.doe@example.com",
                        CarPlate = "ABC123",
                        VinNumber = "1234567890",
                        Brand = "Toyota",
                        Model = "Camry",
                        Describe = "Lorem ipsum dolor sit amet"
                    },
                    new Reservations
                    {
                        ReservationDate = DateTime.Now.AddDays(-2),
                        StartDate = DateTime.Now.AddDays(1),
                        EndDate = DateTime.Now.AddDays(4),
                        Name = "Jane",
                        Surname = "Smith",
                        PhoneNumber = "987654321",
                        Contact = "jane.smith@example.com",
                        CarPlate = "XYZ789",
                        VinNumber = "0987654321",
                        Brand = "Honda",
                        Model = "Civic",
                        Describe = "Consectetur adipiscing elit"
                    }
                
                );
                context.SaveChanges();
            }
        }
    }
}

