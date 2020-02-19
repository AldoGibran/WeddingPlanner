using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace wedding_planner.Models
{
    public class successModel
    {
        [NotMapped]
        public List<Wedding> allW { get; set; }

        public User userLogged { get; set; }

        public Wedding wedding { get; set; }
    }
}