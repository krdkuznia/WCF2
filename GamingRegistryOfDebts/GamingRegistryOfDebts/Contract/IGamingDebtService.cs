using System;
using System.Collections.Generic;
using System.ServiceModel;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.Contract
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
