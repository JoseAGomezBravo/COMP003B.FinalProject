using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        public int DistributorID { get; set; }

        [Required]
        public string PublisherName { get; set; }


        public virtual ICollection<Distributor>? Distributors { get; set; }
    }
    
}
