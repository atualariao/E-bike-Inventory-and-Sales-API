using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_bike_Inventory_and_Sales.Entity
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
    }
}
