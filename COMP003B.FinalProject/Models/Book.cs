using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public int AuthorId { get; set; }

        [Required]
       public string Title { get; set; }

        public string Language {  get; set; }

        public string Description { get; set; }

        public virtual ICollection<Author>? Authors { get; set; }

    }
}
