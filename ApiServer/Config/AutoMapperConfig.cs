using ApiServer.Model;
using ApiServer.Model.DTO;
using AutoMapper;

namespace ApiServer.Config
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Account, LoginResponseDTO>();
        }
    }
}
