
using System.Threading.Tasks;

namespace Hs_BaseModelsUtilities.Interfaces.DataAccess
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task RollbackAsync();
        Task BeginTransactionAsync();
    }



}
