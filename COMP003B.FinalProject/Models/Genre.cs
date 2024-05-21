namespace COMP003B.FinalProject.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        public string GenreName { get; set; }

        public string GenreDescription { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}
