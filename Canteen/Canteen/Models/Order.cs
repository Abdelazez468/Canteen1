using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Canteen.Models
{
    public class Order
    {
        [Key]
        public int OrderItemId { get; set; }


        [Required]
        public DateTime OrderDateTime { get; set; }

        [Required, Range(0, 900000)]
        public int TotalPrice { get; set; }

        [Required]
        public string Status { get; set; }

        public int? StaffId { get; set; }
        [ForeignKey(nameof(StaffId))]
        public Staff? Staff { get; set; }

        public int? FoodItemId { get; set; }
        [ForeignKey(nameof(FoodItemId))]
        public FoodItem? FoodItem { get; set; }

        public int? CreatedByUserId { get; set; }
        [ForeignKey(nameof(CreatedByUserId))]
        public User? CreatedByUser { get; set; }
    }
}