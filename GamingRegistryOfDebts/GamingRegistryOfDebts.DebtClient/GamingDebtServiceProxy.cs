using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.Contract;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DebtClient
{
  public class GamingDebtServiceProxy : ClientBase<IGamingDebtService>, IGamingDebtService
  {
    public GamingDebtServiceProxy(string endpointConfigurationName) : base(endpointConfigurationName)
    { }

    public DebtCollectionStatus CheckCollectionStatus(Guid orderId)
    {
      return Channel.CheckCollectionStatus(orderId);
    }

    public DebtorStatus CheckDebtorStatus(string realm, string name)
    {
      return Channel.CheckDebtorStatus(realm, name);
    }

    public Dictionary<int, string> GetDebtContextsDictionary()
    {
      return Channel.GetDebtContextsDictionary();
    }

    public Guid OrderCollection(DebtDetails debtDetails)
    {
      return Channel.OrderCollection(debtDetails);
    }
  }
}
