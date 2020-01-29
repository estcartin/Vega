using System.Threading.Tasks;
using Vega.Core.Models;

namespace Vega.Core.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);

        void AddVehicle(Vehicle vehicle);

        void RemoveVehicle(Vehicle vehicle);
    }
}