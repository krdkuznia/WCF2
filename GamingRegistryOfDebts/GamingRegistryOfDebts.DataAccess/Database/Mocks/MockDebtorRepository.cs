using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DataAccess.Database.Mocks
{
  public class MockDebtorRepository : IDebtorRepository
  {
    public DebtorStatus GetDebtorStatus(string realm, string name)
    {
      return new DebtorStatus();
    }
  }
}