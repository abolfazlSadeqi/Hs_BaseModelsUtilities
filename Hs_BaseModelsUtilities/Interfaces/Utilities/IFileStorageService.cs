
    using System.Threading.Tasks;

    namespace Hs_BaseModelsUtilities.Interfaces.Utilities
{
        public interface IFileStorageService
        {
            Task SaveAsync(string path, byte[] content);
            Task<byte[]> ReadAsync(string path);
            Task DeleteAsync(string path);
            Task<bool> ExistsAsync(string path);
            Task CopyAsync(string sourcePath, string destinationPath);
            Task MoveAsync(string sourcePath, string destinationPath);
        }


}
