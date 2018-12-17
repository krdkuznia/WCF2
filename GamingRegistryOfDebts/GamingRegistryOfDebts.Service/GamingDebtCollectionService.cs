using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GamingRegistryOfDebts.Contract;
using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.DataAccess.Database.Mocks;
using GamingRegistryOfDebts.DataAccess.WebAPI;
using GamingRegistryOfDebts.DataAccess.WebAPI.Interface;
using GamingRegistryOfDebts.DataAccess.WebAPI.Mocks;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.Service
{
  public class GamingDebtCollectorService : IGamingDebtCollectorService
  {
    private readonly IDebtCollectionRepository _debtCollectionRepository;
    private readonly IDebtorRepository _debtorRepository;
    private readonly IGameApiClient _gameApiClient;

    public GamingDebtCollectorService()
    {
      _debtCollectionRepository = new MockDebtCollectionRepository();
      _debtorRepository = new MockDebtorRepository();
      _gameApiClient = new MockApiClient();
    }

    public GamingDebtCollectorService(IDebtCollectionRepository debtCollectionRepository, IDebtorRepository gamingDebtorRepository, IGameApiClient gameApiClient)
    {
      _debtCollectionRepository = debtCollectionRepository;
      _debtorRepository = gamingDebtorRepository;
      _gameApiClient = gameApiClient;
    }

    public IEnumerable<DebtCollectionOrder> GetPendingOrders()
    {
      var userName = Thread.CurrentPrincipal.Identity.Name;

      return _debtCollectionRepository.GetOrders(userName);
    }

    public PlayerDetails GetPlayerDetails(string realm, string name)
    {
      var playerInfo = _gameApiClient.GetCharacterDetails(realm, name);
      var debtorStatus = _debtorRepository.GetDebtorStatus(realm, name);

      return new PlayerDetails() {DebtorStatus = debtorStatus, InGameInfo = playerInfo};
    }

    public void SetOrderStatus(Guid orderId, JobStatus status, string additionalInfo)
    {
      _debtCollectionRepository.UpdateOrderStatus(orderId,
        new DebtCollectionStatus() {AdditionalInfo = additionalInfo, Status = status});
    }
  }
}
