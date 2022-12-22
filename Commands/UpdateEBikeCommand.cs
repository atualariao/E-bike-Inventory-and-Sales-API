﻿using E_bike_Inventory_and_Sales.Entity;
using MediatR;

namespace E_bike_Inventory_and_Sales.Commands
{
    public record UpdateEBikeCommand(EBike EBike) : IRequest<EBike>;
}