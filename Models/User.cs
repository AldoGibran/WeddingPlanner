using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace wedding_planner.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string fname { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string lname { get; set; }

        [EmailAddress]
        [Required]
        [MinLength(2)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("password")]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string cpassword { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime updatedAt { get; set; } = DateTime.Now;

        public List<RSVP> RSVP { get; set; }
    }
}