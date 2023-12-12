using Microsoft.EntityFrameworkCore;
using VehiclesWebAppliction.Models;

namespace VehiclesWebAppliction.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly DB _connectionclass;
        public VehicleService(DB connectionclass)
        {
            _connectionclass = connectionclass;
        }
        public async Task<string> AddVehicle(VehiclesModel model)
        {
            var Model = new VehiclesModel()
            {
                make = model.make,
                model = model.model,
                thumbnail_url = model.thumbnail_url,
                vin = model.vin,
                year = model.year,
            };
            _connectionclass.vehiclesModels.Add(Model);
            await _connectionclass.SaveChangesAsync();
            return Model.vehicle_id;
        }
        public async Task<List<VehiclesModel>> VehicleList()
        {
            var result = await _connectionclass.vehiclesModels.ToListAsync();
            return result;
        }
    }
}
