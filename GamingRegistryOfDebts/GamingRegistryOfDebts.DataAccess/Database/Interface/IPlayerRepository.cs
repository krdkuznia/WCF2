using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts.DataAccess.Database.Interface
{
  public interface IPlayerRepository
  {
    Guid GetPlayerId(string realm, string name);
    Guid AddPlayer(string realm, string name);
  }
}
