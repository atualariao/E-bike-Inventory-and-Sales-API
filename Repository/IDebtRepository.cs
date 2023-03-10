using E_bike_Inventory_and_Sales.Data;

namespace E_bike_Inventory_and_Sales.Repository
{
    public interface IDebtRepository
    {
        public Task<List<Debt>> GetDebtList();
        public Task<Debt> GetSpecificDebt(int id);
        public Task<Debt> CreateDebt(Debt debt);
        public Task<Debt> UpdateDebt(Debt debt);
        public Task<Debt> DeleteDebt(int id);
    }
}
