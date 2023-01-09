using E_bike_Inventory_and_Sales.Data;
using System.ComponentModel.DataAnnotations;

namespace E_bike_Inventory_and_Sales.Dto.Response
{
    public class CustomerDtoRes : CustomerDtoResponse
    {
        public int Id { get; set; }
        public Debt? Debt { get; set; }
        public List<Sale> Sales { get; set; } = null!;
    }
    public class CustomerDtoResponse
    {
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
    }

}
