using SmartParkWeb.Domain.Thing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.Domain.Events;

public class EventVehicle
{
    public int Id { get; set; }
    public DateTime Entry { get; set; }
    public DateTime? Exit { get; set; }
    public Vehicle Vehicle { get; set; }
}
