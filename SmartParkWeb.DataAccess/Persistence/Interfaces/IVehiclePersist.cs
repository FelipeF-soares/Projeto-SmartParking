using SmartParkWeb.Domain.Thing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.DataAccess.Persistence.Interfaces;

public interface IVehiclePersist:IGenericPersist
{
    Vehicle GetVehicleById(int vehicleId);
    Vehicle GetVehicleByLicensePlate(string licensePlate);
    List<Vehicle> GetAllVehicles();
}
