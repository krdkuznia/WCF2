using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.DataAccess.Database;
using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.DataAccess.WebAPI;
using GamingRegistryOfDebts.DataAccess.WebAPI.Interface;
using Ninject.Modules;

namespace GamingRegistryOfDebts.ConsoleHost
{
  public class DefaultModule : NinjectModule
  {
    public override void Load()
    {
      Bind<IDebtCollectionRepository>() // Tam gdzie potrzeba takiego interfejsu...
        .To<DebtCollectionRepository>() // ...Wstrzyknij taką jego implementację...
        .InSingletonScope();            // ...jedną na całą aplikację.

      Bind<IDebtorRepository>()
        .To<DebtorRepository>()
        .InSingletonScope();

      Bind<IDebtRepository>()
        .To<DebtRepository>()
        .InSingletonScope();

      Bind<IPlayerRepository>()
        .To<PlayerRepository>()
        .InSingletonScope();

      Bind<IGameApiClient>()
        .To<BlizzardWowApiClient>()
        .InSingletonScope();
    }
  }
}
