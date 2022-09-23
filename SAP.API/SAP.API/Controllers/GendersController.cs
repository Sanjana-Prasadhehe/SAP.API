using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SAP.API.DomainModels;
using SAP.API.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SAP.API.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }


        [HttpGet]
        [Route("[controller]")]
        public async System.Threading.Tasks.Task <IActionResult> GetAllGenders()
        {
            var genderList = await studentRepository.GetGendersAsync();
            if(genderList==null || !genderList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Gender>>(genderList));

        }
    }
}
