using Microsoft.AspNetCore.Mvc;
using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.Domain.Thing;

namespace SmartParkWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class VehicleController : Controller
{
    private readonly IVehiclePersist vehiclePersist;

    public VehicleController(IVehiclePersist vehiclePersist)
    {
        this.vehiclePersist = vehiclePersist;
    }
    public IActionResult Index()
    {
        var vehicles = vehiclePersist.GetAllVehicles();
        return View(vehicles);
    }
    [HttpGet]
    public IActionResult Add(int id)
    {
        Vehicle vehicle = new Vehicle();
        vehicle.MilitaryId = id;
        return View(vehicle);
    }
    [HttpPost]
    public IActionResult Add(Vehicle vehicle)
    {
        vehiclePersist.Add(vehicle);
        vehiclePersist.SaveChanger();
        return RedirectToAction("Index", "Military");
        
    }
}
