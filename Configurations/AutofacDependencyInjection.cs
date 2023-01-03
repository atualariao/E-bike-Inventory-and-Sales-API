using Autofac;
using E_bike_Inventory_and_Sales.Interface;
using E_bike_Inventory_and_Sales.Repository;
using MediatR.Extensions.Autofac.DependencyInjection;

namespace E_bike_Inventory_and_Sales.Configurations
{
    public class AutofacDependencyInjection : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Repositories
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DebtRepository>().As<IDebtRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<EBikeRepository>().As<IEBikeRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<InventoryRepository>().As<IInventoryRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<SaleRepository>().As<ISaleRepository>().InstancePerLifetimeScope();

            // MediatR
            builder.RegisterMediatR(typeof(CustomerRepository).Assembly);
            builder.RegisterMediatR(typeof(DebtRepository).Assembly);
            //builder.RegisterMediatR(typeof(EBikeRepository).Assembly);
            //builder.RegisterMediatR(typeof(InventoryRepository).Assembly);
            //builder.RegisterMediatR(typeof(SaleRepository).Assembly);
        }
    }
}
