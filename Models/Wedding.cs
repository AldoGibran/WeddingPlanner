using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace wedding_planner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Bride's Name")]
        public string bride { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Groom's Name")]
        public string groom { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public DateTime date { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Wedding Address")]
        public string address { get; set; }

        public DateTime createdAt { get; set; } = DateTime.Now;

        public DateTime updatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public User Creator { get; set; }

        public List<RSVP> RSVP { get; set; }
    }
}