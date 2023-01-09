using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Data
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
