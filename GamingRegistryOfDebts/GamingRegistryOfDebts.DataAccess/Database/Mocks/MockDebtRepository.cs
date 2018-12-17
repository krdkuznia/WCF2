using System;
using System.Collections.Generic;
using GamingRegistryOfDebts.DataAccess.Database.Interface;

namespace GamingRegistryOfDebts.DataAccess.Database.Mocks
{
  public class MockDebtRepository : IDebtRepository
  {
    public Guid AddDebt(Guid debtorId, Guid clientId, int debtContextId, decimal debtAmount)
    {
      return Guid.NewGuid();
    }

    public Dictionary<int, string> GetDebtContexts()
    {
      return new Dictionary<int, string>()
      {
        {1, "Pożyczka"},
        {2, "Pobrał wpłatę, a nie wykonał usługi"}
      };
    }
  }
}