using System.Threading.Tasks;

namespace Vega.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}