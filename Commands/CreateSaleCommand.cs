﻿using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands
{
    public record CreateSaleCommand(Sale Sale) : IRequest<Sale>;
}