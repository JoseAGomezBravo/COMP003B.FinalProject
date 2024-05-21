using System.ComponentModel.DataAnnotations;

namespace COMP003B.FinalProject.Models
{
    public class Distributor
    {
        public int DistributorID { get; set; }
        [Required]
        public string DistributorName { get; set; }

        public string DistributorDescription { get; set; }

        public virtual ICollection<Distributor>? Distributors { get; set; }

    }
}
