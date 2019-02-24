using System.ComponentModel.DataAnnotations;

namespace VI.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "State")]
        public int StateId { get; set; }

        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Zip { get; set; }

        [Required]
        public double Basic { get; set; }

        [Required]
        public double HRA { get; set; }

        [Required]
        public double DA { get; set; }
    }
}