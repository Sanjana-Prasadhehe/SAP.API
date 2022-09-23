using Microsoft.AspNetCore.Http;
using System.IO;
namespace SAP.API.Repositories
{
    public class LocalStorageImageRepository : IImageRepository
    {
        public async System.Threading.Tasks.Task<string> Upload(IFormFile file, string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Images", fileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            return GetServerRelativePath(fileName);
        }

        private string GetServerRelativePath(string fileName)
        {
            return Path.Combine(@"Resources\Images", fileName);
        }
    }
}