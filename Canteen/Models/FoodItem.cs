using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Canteen.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }

        [Required]
        public string FoodName { get; set; }

        [Required, Range(0, 900000)]
        public int Price { get; set; }

        [Required]
        public string Category { get; set; }

        public int? CreatedByUserId { get; set; }

        [ForeignKey(nameof(CreatedByUserId))]
        public User? CreatedByUser { get; set; }

        public List<Order>? Orders { get; set; } = new List<Order>();
    }
}
