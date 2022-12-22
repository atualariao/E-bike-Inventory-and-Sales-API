using E_bike_Inventory_and_Sales.Entity;

namespace E_bike_Inventory_and_Sales.IRepository
{
    public interface IEBikeRepository
    {
        public Task<List<EBike>> GetEBikeList();
        public Task<EBike> GetSpecificEBike(int id);
        public Task<EBike> CreateEBike(EBike eBike);
        public Task<EBike> UpdateEBike(EBike eBike);
        public Task<EBike> DeleteEBike(int id);
    }
}
