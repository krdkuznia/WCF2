using System;
using GamingRegistryOfDebts.DataAccess.Database.Interface;

namespace GamingRegistryOfDebts.DataAccess.Database.Mocks
{
  public class MockPlayerRepository : IPlayerRepository
  {
    public Guid GetPlayerId(string realm, string name)
    {
      return default(Guid);
    }

    public Guid AddPlayer(string realm, string name)
    {
      return Guid.NewGuid();
    }
  }
}