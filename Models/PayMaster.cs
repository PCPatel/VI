using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VI.Models
{
    public class PayMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public double Basic { get; set; }

        [Required]
        public double HRA { get; set; }

        [Required]
        public double DA { get; set; }

        public virtual Employee Employee { get; set; }
    }
}