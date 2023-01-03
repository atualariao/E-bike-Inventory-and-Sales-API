using E_bike_Inventory_and_Sales.Entity;
using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Dto.Response
{
    public class DebtDtoRes : DebtDtoResponse
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
    public class DebtDtoResponse
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }

}
