namespace Librery.Models
{
    public class Member
    {
        public string nameMember { get; set; }
        public string idMember { get; set; }
        public string address { get; set; }
        public Book[] bookBorrow { get; set; } = new Book[5];
    }
}
