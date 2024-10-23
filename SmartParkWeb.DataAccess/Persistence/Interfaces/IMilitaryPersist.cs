using SmartParkWeb.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkWeb.DataAccess.Persistence.Interfaces;

public interface IMilitaryPersist
{
    Military GetMilitaryForId(int id);
    Military GetMilitaryForRe(string Re);
    List<Military> GetAllMilitaries();
}
