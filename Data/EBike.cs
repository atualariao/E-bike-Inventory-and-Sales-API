using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Data
{
    public class EBike
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Inventory Inventory { get; set; } = null!;
    }
}
