using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace SAP.API.Repositories
{
    public interface IImageRepository
    {
         Task<string> Upload(IFormFile file, string fileName);
    }
}