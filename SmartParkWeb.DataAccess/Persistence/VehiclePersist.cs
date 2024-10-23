using Microsoft.EntityFrameworkCore;
using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.DataAccess.SmartParkingContext;
using SmartParkWeb.Domain.Thing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.DataAccess.Persistence;

public class VehiclePersist : GenericPersist, IVehiclePersist
{
    private readonly SmartParkContext context;

    public VehiclePersist(SmartParkContext context) : base(context)
    {
        this.context = context;
    }

    public List<Vehicle> GetAllVehicles()
    {
        var vehicles = context.Vehicles
                              .Include(vehicle => vehicle.Military)
                              .AsNoTracking()
                              .ToList();
        return vehicles;
    }

    public Vehicle GetVehicleById(int vehicleId)
    {
        var vehicles = context.Vehicles
                               .Include(vehicle => vehicle.Military)
                               .FirstOrDefault(vehicle => vehicle.Id == vehicleId);
        return vehicles;
    }

    public Vehicle GetVehicleByLicensePlate(string licensePlate)
    {
        var vehicles = context.Vehicles
                               .Include(vehicle => vehicle.Military)
                               .FirstOrDefault(vehicle => vehicle.LicensePlate == licensePlate);
        return vehicles;
    }
}
