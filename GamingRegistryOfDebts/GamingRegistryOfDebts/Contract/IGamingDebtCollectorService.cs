using System;
using System.Collections.Generic;
using System.ServiceModel;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.Contract
{
  [ServiceContract]
  public interface IGamingDebtCollectorService
  {
    [OperationContract]
    IEnumerable<DebtCollectionOrder> GetPendingOrders();

    [OperationContract]
    PlayerDetails GetPlayerDetails(string realm, string name);

    [OperationContract]
    void SetOrderStatus(Guid orderId, JobStatus status, string additionalInfo);
  }
}
