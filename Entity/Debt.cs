using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Entity
{
    public class Debt
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
