using VehiclesWebAppliction.Models;

namespace VehiclesWebAppliction.Services
{
    public interface IVehicleService
    {
        Task<string> AddVehicle(VehiclesModel model);
        Task<List<VehiclesModel>> VehicleList();
    }
}