using Cards.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cards.API.Data
{
    public class CardsDbContext : DbContext
    {
        public CardsDbContext(DbContextOptions options): base(options)
        {
        }
        //DbSet for creating tables in Database
        public DbSet<Card> Cards { get; set; }
    }
}
