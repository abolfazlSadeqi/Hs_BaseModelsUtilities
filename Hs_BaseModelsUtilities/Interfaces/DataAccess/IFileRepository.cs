
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    public interface IFileRepository
    {
        Task SaveFileAsync(string path, byte[] content);
        Task<byte[]> ReadFileAsync(string path);
        Task DeleteFileAsync(string path);
        Task<bool> ExistsAsync(string path);
        Task CopyFileAsync(string sourcePath, string destinationPath);
    }



}
