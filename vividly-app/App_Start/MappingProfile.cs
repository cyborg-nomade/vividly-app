using AutoMapper;
using vividly_app.DTOs;
using vividly_app.Models;

namespace vividly_app
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}