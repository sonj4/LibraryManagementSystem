namespace API.Models
{
    public class BookCopy
    {
        public int Id { get; set; }
        public int BookId   { get; set; }
        public int LibraryId { get; set; }
        public int PublisherId  { get; set; }
        public Book Book { get; set; }
        public Library Library { get; set; }
        public Publisher Publisher { get; set; }
    }
}
