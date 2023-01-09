using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Data
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public Debt? Debt { get; set; }
        public List<Sale> Sales { get; set; } = null!;
    }
}
