
namespace TicketingSystem.Models
{

    public class Ticket
    {
       
        public int TicketId { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        public string? Screen_name  { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
