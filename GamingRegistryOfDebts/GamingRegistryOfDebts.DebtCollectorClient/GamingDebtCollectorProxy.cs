using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.Contract;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DebtCollectorClient
{
  public class GamingDebtCollectorProxy : ClientBase<IGamingDebtCollectorService>, IGamingDebtCollectorService
  {
    public GamingDebtCollectorProxy(string endpointConfigurationName) : base(endpointConfigurationName)
    { }

    public IEnumerable<DebtCollectionOrder> GetPendingOrders()
    {
      return Channel.GetPendingOrders();
    }

    public PlayerDetails GetPlayerDetails(string realm, string name)
    {
      return Channel.GetPlayerDetails(realm, name);
    }

    public void SetOrderStatus(Guid orderId, JobStatus status, string additionalInfo)
    {
      Channel.SetOrderStatus(orderId, status, additionalInfo);
    }
  }
}
