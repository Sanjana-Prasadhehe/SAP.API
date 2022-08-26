using AutoMapper;
using SAP.API.DomainModels;
using DataModels= SAP.API.DataModels;

namespace SAP.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>().ReverseMap();
            CreateMap<DataModels.Gender, Gender>().ReverseMap();
            CreateMap<DataModels.Address,Address>().ReverseMap();
        }
    }
}
