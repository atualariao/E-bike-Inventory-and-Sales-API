using E_bike_Inventory_and_Sales.Data;
using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Dto.Request
{
    public class DebtDtoReq : DebtDtoRequest
    {
        public int Id { get; set; }
    }
    public class DebtDtoRequest
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
    }
}
