using AutoMapper;
using Domain.Models;
using DTO.Models.Clients;

namespace Core.Mapper
{
    public class ShopAutomapperProfile : Profile
    {
        public ShopAutomapperProfile()
        {
            CreateMap<Client, ClientBirthdayModel>().ForMember(m => m.ClientId, opt => opt.MapFrom(p => p.Id));
        }
    }
}
