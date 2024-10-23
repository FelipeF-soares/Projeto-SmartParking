using Microsoft.EntityFrameworkCore;
using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.DataAccess.SmartParkingContext;
using SmartParkWeb.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.DataAccess.Persistence;

public class MilitaryPersist : GenericPersist, IMilitaryPersist
{
    private readonly SmartParkContext context;

    public MilitaryPersist(SmartParkContext context) : base(context)
    {
        this.context = context;
    }

    public List<Military> GetAllMilitaries()
    {
        var militaries = context.Military
                                .Include(military => military.Vehicles)
                                .Include(military => military.IDdriver)
                                .AsNoTracking()
                                .ToList();
        return militaries;
    }

    public Military GetMilitaryForId(int id)
    {
        var militaries = context.Military
                               .Include(military => military.Vehicles)
                               .Include(military => military.IDdriver)
                               .FirstOrDefault(military => military.Id == id);

        return militaries;
    }

    public Military GetMilitaryForRe(string Re)
    {
        var militaries = context.Military
                               .Include(military => military.Vehicles)
                               .Include(military => military.IDdriver)
                               .FirstOrDefault(military => military.Re == Re);
        return militaries;
    }
}
