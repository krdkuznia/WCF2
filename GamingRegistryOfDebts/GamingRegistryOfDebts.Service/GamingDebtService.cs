using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.ServiceModel;
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
  public class GamingDebtService : IGamingDebtService
  {
    private readonly IDebtCollectionRepository _debtCollectionRepository;
    private readonly IDebtorRepository _debtorRepository;
    private readonly IDebtRepository _debtRepository;
    private readonly IPlayerRepository _playerRepository;
    private readonly IGameApiClient _gameApiClient;

    public GamingDebtService()
    {
      _debtCollectionRepository = new MockDebtCollectionRepository();
      _debtorRepository = new MockDebtorRepository();
      _debtRepository = new MockDebtRepository();
      _playerRepository = new MockPlayerRepository();
      _gameApiClient = new MockApiClient();
    }

    public GamingDebtService(IDebtCollectionRepository debtCollectionRepository, IDebtorRepository debtorRepository, IDebtRepository debtRepository, IPlayerRepository playerRepository, IGameApiClient gameApiClient)
    {
      _debtCollectionRepository = debtCollectionRepository;
      _debtorRepository = debtorRepository;
      _debtRepository = debtRepository;
      _playerRepository = playerRepository;
      _gameApiClient = gameApiClient;
    }

    public DebtorStatus CheckDebtorStatus(string realm, string name)
    {
      return _debtorRepository.GetDebtorStatus(realm, name);
    }

    public Dictionary<int, string> GetDebtContextsDictionary()
    {
      return _debtRepository.GetDebtContexts();
    }

    public Guid OrderCollection(DebtDetails debtDetails)
    {
      var clientId = _playerRepository.GetPlayerId(debtDetails.ClientRealm, debtDetails.ClientName);

      if (clientId == default(Guid))
      {
        var clientApiResult = _gameApiClient.GetCharacterDetails(debtDetails.ClientRealm, debtDetails.ClientName);
        if (clientApiResult == null)
        {
          throw new ArgumentOutOfRangeException(nameof(debtDetails.ClientName), "Could not find specified character");
        }

        clientId = _playerRepository.AddPlayer(debtDetails.ClientRealm, debtDetails.ClientName);
      }

      var debtorId = _playerRepository.GetPlayerId(debtDetails.DebtorRealm, debtDetails.DebtorName);

      if (debtorId == default(Guid))
      {
        var debtorApiResult = _gameApiClient.GetCharacterDetails(debtDetails.DebtorRealm, debtDetails.DebtorName);
        if (debtorApiResult == null)
        {
          throw new ArgumentOutOfRangeException(nameof(debtDetails.DebtorName), "Could not find specified character");
        }

        debtorId = _playerRepository.AddPlayer(debtDetails.DebtorRealm, debtDetails.DebtorName);
      }

      var orderId = _debtRepository.AddDebt(debtorId, clientId, debtDetails.DebtContextId, debtDetails.DebtAmount);

      var userName = WindowsIdentity.GetCurrent().Name;

      _debtCollectionRepository.UpdateOrderAssignment(orderId, userName);

      return orderId;
    }

    public DebtCollectionStatus CheckCollectionStatus(Guid orderId)
    {
      return _debtCollectionRepository.GetOrderStatus(orderId);
    }
  }
}
