using SmartParkWeb.Domain.Thing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.Domain.People;

public class Military : Person
{
    public string Re { get; set; }
    public IDdriver? IDdriver { get; set; }
    public IEnumerable<Vehicle> Vehicles { get; set; }

}
