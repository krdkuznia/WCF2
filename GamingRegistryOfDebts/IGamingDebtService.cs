using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts
{
  [ServiceContract]
  public interface IGamingDebtService
  {
    [OperationContract]
    DebtorStatus CheckDebtorStatus(string realm, string name);

    [OperationContract]
    Dictionary<int, string> GetDebtContextsDictionary();

    [OperationContract]
    Guid OrderCollection(DebtDetails debtDetails);

    [OperationContract]
    DebtCollectionStatus CheckCollectionStatus(Guid orderId);
  }
}
