using Microsoft.EntityFrameworkCore;
using SmartParkWeb.Domain.Events;
using SmartParkWeb.Domain.People;
using SmartParkWeb.Domain.Thing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.DataAccess.SmartParkingContext;

public class SmartParkContext : DbContext
{
    public SmartParkContext(DbContextOptions<SmartParkContext> options) : base(options)
    {
        
    }
    public DbSet<EventVehicle> EventsVehicle { get; set; }
    public DbSet<Military> Military { get; set; }
    public DbSet<IDdriver> IDsdriver { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
}
