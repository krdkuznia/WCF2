using System;
using System.Collections.Generic;
using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DataAccess.Database.Mocks
{
  public class MockDebtCollectionRepository : IDebtCollectionRepository
  {
    public IEnumerable<DebtCollectionOrder> GetAllOrders()
    {
      return new List<DebtCollectionOrder>();
    }

    public IEnumerable<DebtCollectionOrder> GetOrders(string userName)
    {
      return new List<DebtCollectionOrder>();
    }

    public DebtCollectionStatus GetOrderStatus(Guid orderId)
    {
      return new DebtCollectionStatus();
    }

    public void UpdateOrderStatus(Guid orderId, DebtCollectionStatus status)
    {
      
    }

    public void UpdateOrderAssignment(Guid orderId, string newUserName)
    {
      
    }
  }
}