using Microsoft.AspNetCore.Mvc;
using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.Domain.People;

namespace SmartParkWeb.Areas.Admin.Controllers;
[Area("Admin")]
public class MilitaryController : Controller
{
    private readonly IMilitaryPersist militaryPersist;

    public MilitaryController(IMilitaryPersist militaryPersist)
    {
        this.militaryPersist = militaryPersist;
    }
    public IActionResult Index()
    {
        var militaries = militaryPersist.GetAllMilitaries();
        return View(militaries);
    }
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Military military)
    {
        militaryPersist.Add(military);
        militaryPersist.SaveChanger();
        return RedirectToAction($"Add","IDdriver", new {id = military.Id});
    }
}
