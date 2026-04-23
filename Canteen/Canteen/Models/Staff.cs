using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Canteen.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required]
        public string StaffName { get; set; }

        public string JobTitle { get; set; }

        public string Status { get; set; }

        [Required, StringLength(11, MinimumLength = 11)]
        public string Phone { get; set; }

        public int? CreatedByUserId { get; set; }

        [ForeignKey(nameof(CreatedByUserId))]
        public User? CreatedByUser { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
