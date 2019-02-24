using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VI.Models
{
    public class Employee
    {
        public Employee()
        {
            this.PayMaster = new List<PayMaster>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int StateId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Zip { get; set; }

        public virtual ICollection<PayMaster> PayMaster { get; set; }
    }
}