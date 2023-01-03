﻿using Dapper;
using E_bike_Inventory_and_Sales.Data;
using E_bike_Inventory_and_Sales.Entity;
using E_bike_Inventory_and_Sales.Interface;
using Microsoft.EntityFrameworkCore;

namespace E_bike_Inventory_and_Sales.Repository
{
    public class DebtRepository : IDebtRepository
    {
        private readonly MyDbContext _context;

        public DebtRepository(MyDbContext context) => _context = context;

        public async Task<List<Debt>> GetDebtList()
        {
            var query = "SELECT * FROM Debts";
            try
            {
                using (var connection = _context.Database.GetDbConnection())
                {
                    var debtList = await connection.QueryAsync<Debt>(query);
                    return debtList.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Debt> GetSpecificDebt(int id)
        {
            var query = "SELECT * FROM Debts WHERE Id = @id";

            try
            {
                using (var connection = _context.Database.GetDbConnection())
                {
                    var debt = await connection.QuerySingleOrDefaultAsync<Debt>(query, new { id });

                    return debt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Debt> CreateDebt(Debt debt)
        {
            try
            {
                var newDebt = new Debt()
                {
                    Id = debt.Id,
                    CustomerId = debt.CustomerId,
                    Customer = debt.Customer,
                    Amount = debt.Amount,
                    Date = debt.Date

                };

                _context.Add(newDebt);
                await _context.SaveChangesAsync();

                return newDebt;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
