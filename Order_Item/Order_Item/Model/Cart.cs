using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Item.Model
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int userId { get; set; }
        public int menuItemId { get; set; }
        [Required]
        public string menuItemName { get; set; }
    }
}
