using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DataAccess.Database.Interface
{
  public interface IDebtCollectionRepository
  {
    IEnumerable<DebtCollectionOrder> GetAllOrders();
    IEnumerable<DebtCollectionOrder> GetOrders(string userName);
    DebtCollectionStatus GetOrderStatus(Guid orderId);
    void UpdateOrderStatus(Guid orderId, DebtCollectionStatus status);
    void UpdateOrderAssignment(Guid orderId, string newUserName);
  }
}
