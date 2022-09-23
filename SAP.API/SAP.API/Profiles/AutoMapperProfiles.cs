using AutoMapper;
using SAP.API.DomainModels;
using SAP.API.Profiles.AfterMaps;
using DataModels = SAP.API.DataModels;

namespace SAP.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, SAP.API.DomainModels.Student>()
                .ReverseMap();

            CreateMap<DataModels.Gender, SAP.API.DomainModels.Gender>()
                .ReverseMap();

            CreateMap<DataModels.Address, SAP.API.DomainModels.Address>()
                .ReverseMap();

            CreateMap<UpdateStudentRequest, DataModels.Student>()
                .AfterMap<UpdateStudentRequestAfterMap>();

            CreateMap<AddStudentRequest, DataModels.Student>()
                .AfterMap<AddStudentRequestAfterMap>();
        }
    }
}