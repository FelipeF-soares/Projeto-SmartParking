using SmartParkWeb.DataAccess.Persistence.Interfaces;
using SmartParkWeb.DataAccess.SmartParkingContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.DataAccess.Persistence;

public class GenericPersist : IGenericPersist
{
    private readonly SmartParkContext context;

    public GenericPersist(SmartParkContext context)
    {
        this.context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        context.Remove(entity);
    }
    public void Update<T>(T entity) where T : class
    {
        context.Update(entity);
    }

    public bool SaveChanger()
    {
      return (context.SaveChanges()) > 0;
    }

    
}
