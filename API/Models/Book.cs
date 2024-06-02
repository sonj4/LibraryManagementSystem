namespace API.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords  { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();    
        public ICollection<BookCopy> BookCopys { get; set; }
    }
}
