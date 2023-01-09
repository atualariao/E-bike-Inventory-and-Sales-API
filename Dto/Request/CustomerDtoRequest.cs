using E_bike_Inventory_and_Sales.Data;
using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Dto.Request
{
    public class CustomerDtoReq : CustomerDtoRequest
    {
        public int Id { get; set; }
        public Debt? Debt { get; set; }
        public List<Sale> Sales { get; set; } = null!;
    }
    public class CustomerDtoRequest
    {
        [Required]
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        [Required]
        public string Phone { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
    }

}
