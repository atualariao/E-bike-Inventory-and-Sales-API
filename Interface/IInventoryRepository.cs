using E_bike_Inventory_and_Sales.Entity;

namespace E_bike_Inventory_and_Sales.Interface
{
    public interface IInventoryRepository
    {
        public Task<List<Inventory>> GetInventoryList();
        public Task<Inventory> GetSpecificInventory(int id);
        public Task<Inventory> CreateInventory(Inventory inventory);
        public Task<Inventory> UpdateInventory(Inventory inventory);
        public Task<Inventory> DeleteInventory(int id);
    }
}
