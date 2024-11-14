namespace MsFlora.Models
{
    public class Testiomonial
    {
        public int Id { get; set; }
        public string Message { get; set; }

       
        public int UserId { get; set; }
        public User User { get; set; }

        public bool Status { get; set; }
    }
}
