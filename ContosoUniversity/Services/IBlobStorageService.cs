using System.IO;
using System.Threading.Tasks;

namespace ContosoUniversity.Services
{
    public interface IBlobStorageService
    {
        Task<string> UploadAsync(Stream content, string fileName, string contentType);
        Task DeleteAsync(string blobName);
        string GetBlobUrl(string blobName);
    }
}
