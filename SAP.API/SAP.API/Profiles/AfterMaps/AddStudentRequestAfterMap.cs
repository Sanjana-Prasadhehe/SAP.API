using AutoMapper;
using SAP.API.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SAP.API.Profiles.AfterMaps
{
    public class AddStudentRequestAfterMap : IMappingAction<AddStudentRequest, SAP.API.DataModels.Student>
    {
        public void Process(AddStudentRequest source, SAP.API.DataModels.Student destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
            destination.Address = new SAP.API.DataModels.Address()
            {
                Id = Guid.NewGuid(),
                PhysicalAddress = source.PhysicalAddress,
                PostalAddress = source.PostalAddress
            };
        }
    }
}