using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts.DataAccess.Database.Interface
{
  public interface IDebtRepository
  {
    Guid AddDebt(Guid debtorId, Guid clientId, int debtContextId, decimal debtAmount);
    Dictionary<int, string> GetDebtContexts();
  }
}
