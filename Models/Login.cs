using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace wedding_planner.Models
{
    [NotMapped]
    public class Login
    {
        [EmailAddress]
        [Required]
        [MinLength(2)]
        [Display(Name = "Email")]
        public string lemail { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string lpassword { get; set; }
    }
}