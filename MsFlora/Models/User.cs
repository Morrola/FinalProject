namespace MsFlora.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Role { get; set; }

     
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Testiomonial> Testimonials { get; set; }

        public string ImagePath { get; set; }
    }
}
