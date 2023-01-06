using E_bike_Inventory_and_Sales.Entity;
using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Dto.Response
{
    public class DebtDtoRes : DebtDtoResponse
    {
        public int Id { get; set; }
    }
    public class DebtDtoResponse
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
    }

}
