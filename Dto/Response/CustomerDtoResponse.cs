using E_bike_Inventory_and_Sales.Entity;
using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Dto.Response
{
    public class CustomerDto : CustomerDtoResponse
    {
        public int Id { get; set; }
    }
    public class CustomerDtoResponse
    {
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public Debt? Debt { get; set; }
        public List<Sale> Sales { get; set; } = null!;
    }

}
