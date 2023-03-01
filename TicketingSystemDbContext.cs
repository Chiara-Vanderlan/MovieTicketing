using Microsoft.EntityFrameworkCore;

namespace TicketingSystem.Models
{
    public class TicketingSystemDbContext :DbContext 
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TicketingSystemDbContext(DbContextOptions<TicketingSystemDbContext> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; } 
        public DbSet<User> Users { get; set; } 
    }
}
