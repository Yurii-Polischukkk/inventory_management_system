using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBuisness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        [Required]
        public string? InventoryName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage ="Quantity must be smaller or bigger 0")]
        public int Quantity { get; set;}
        [Range(0, int.MaxValue, ErrorMessage = "Price must be smaller or bigger 0")]
        public double Price { get; set; }
    }
}