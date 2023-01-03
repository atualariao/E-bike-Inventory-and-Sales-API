using AutoMapper;
using E_bike_Inventory_and_Sales.Dto.Request;
using E_bike_Inventory_and_Sales.Dto.Response;
using E_bike_Inventory_and_Sales.Entity;

namespace E_bike_Inventory_and_Sales.Configurations
{
    public class AutoMapperInitializer : Profile
    {
        public AutoMapperInitializer()
        {
            CreateMap<Customer, CustomerDtoRequest>().ReverseMap();
            CreateMap<Customer, CustomerDtoReq>().ReverseMap();
            CreateMap<Customer, CustomerDtoResponse>().ReverseMap();
            CreateMap<Customer, CustomerDtoRes>().ReverseMap();

            CreateMap<Debt, DebtDtoRequest>().ReverseMap();
            CreateMap<Debt, DebtDtoReq>().ReverseMap();
            CreateMap<Debt, DebtDtoResponse>().ReverseMap();
            CreateMap<Debt, DebtDtoRes>().ReverseMap();
        }
    }
}
