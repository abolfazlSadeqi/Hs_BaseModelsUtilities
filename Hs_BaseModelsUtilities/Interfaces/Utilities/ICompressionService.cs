
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.Utilities
{
    public interface ICompressionService
    {
        byte[] Compress(byte[] data);
        byte[] Decompress(byte[] data);
        Task CompressFileAsync(string inputPath, string outputPath);
        Task DecompressFileAsync(string inputPath, string outputPath);
    }


}
