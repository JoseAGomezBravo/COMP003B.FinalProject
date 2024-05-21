using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

        [Required]
        public string PublisherName { get; set; }

        public virtual ICollection<Publisher>? Publishers { get; set; }
    }
}
