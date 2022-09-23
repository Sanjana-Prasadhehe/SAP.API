using Microsoft.AspNetCore.Http;
namespace SAP.API.Repositories
{
    public interface IImageRepository
    {
        System.Threading.Tasks. Task<string> Upload(IFormFile file, string fileName);
    }
}