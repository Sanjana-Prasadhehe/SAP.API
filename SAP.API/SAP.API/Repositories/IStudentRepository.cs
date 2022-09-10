﻿using SAP.API.DataModels;
using System;
using System.Collections.Generic;

namespace SAP.API.Repositories
{
    public interface IStudentRepository
    {
        System.Threading.Tasks.Task<List<Student>> GetStudentsAsync();
        Task <Student>GetStudentAsync(Guid studentId);
    }
}


   
