using Microsoft.EntityFrameworkCore;
using SAP.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SAP.API.Repositories
   
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public async System.Threading.Tasks.Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
