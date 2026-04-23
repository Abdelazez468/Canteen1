using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Canteen.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        
        [Required, StringLength(100, MinimumLength = 9)]
        public string Password { get; set; }

        [Required, StringLength(11, MinimumLength = 11)]
        public string Phone { get; set; }

        public string Role { get; set; } = "User";

        public List<Staff>? Staffs { get; set; } = new List<Staff>();
        public List<FoodItem>? FoodItems { get; set; } = new List<FoodItem>();
        public List<Order>? Orders { get; set; } = new List<Order>();
    }
}
