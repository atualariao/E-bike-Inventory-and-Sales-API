using E_bike_Inventory_and_Sales.Entity;

namespace E_bike_Inventory_and_Sales.Repository
{
    public interface ISaleRepository
    {
        public Task<List<Sale>> GetSaleList();
        public Task<Sale> GetSpecificSale(int id);
        public Task<Sale> CreateSale(Sale sale);
        public Task<Sale> UpdateSale(Sale sale);
        public Task<Sale> DeleteSale(int id);
    }
}
