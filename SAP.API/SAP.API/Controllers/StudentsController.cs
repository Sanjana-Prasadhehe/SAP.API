using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SAP.API.DomainModels;
using SAP.API.Repositories;
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
    }
}
