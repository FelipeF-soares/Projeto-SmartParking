using Microsoft.AspNetCore.Mvc;
using SmartParkWeb.DataAccess.Persistence;
using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.Domain.People;
using SmartParkWeb.Domain.Thing;

namespace SmartParkWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class IDdriverController : Controller
{
    private readonly IIDdriverPersist ddriverPersist;

    public IDdriverController(IIDdriverPersist ddriverPersist)
    {
        this.ddriverPersist = ddriverPersist;
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Add(int id)
    {
        IDdriver ddriver = new IDdriver();
        ddriver.MilitaryId = id;
        ddriver.Validity = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day);
        return View(ddriver);
    }
    [HttpPost]
    public IActionResult Add(IDdriver idDriver)
    {
        ddriverPersist.Add(idDriver);
        ddriverPersist.SaveChanger();
        return RedirectToAction($"Add", "Vehicle",new {Id = idDriver.MilitaryId});
    }
}
