using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SAP.API.DomainModels;
using SAP.API.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SAP.API.Controllers   
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;
       public StudentsController(IStudentRepository studentRepository , IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async System.Threading.Tasks.Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await studentRepository.GetStudentsAsync();
            
            return Ok(mapper.Map<List<Student>>(students));
        }
        [HttpGet]
        [Route("[controller]/{studentId:guid}")]
        public async System.Threading.Tasks.Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
        {
            var student = await studentRepository.GetStudentAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<Student>(student));
        }

    }
}
