using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts
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
