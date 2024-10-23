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

public class DdriverPersist : GenericPersist, IIDdriverPersist
{
    private readonly SmartParkContext context;

    public DdriverPersist(SmartParkContext context) : base(context)
    {
        this.context = context;
    }

    public IDdriver GetIDdriverForId(int id)
    {
         var idDriver = context.IDsdriver.Include(idDrive => idDrive.Military).FirstOrDefault(idDrive => idDrive.Id == id);

        return idDriver;

    }
}
