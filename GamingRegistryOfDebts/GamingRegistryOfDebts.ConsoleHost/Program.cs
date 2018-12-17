using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.Service;
using Ninject;
using Ninject.Extensions.Wcf;
using Ninject.Extensions.Wcf.SelfHost;
using Ninject.Web.Common.SelfHost;

namespace GamingRegistryOfDebts.ConsoleHost
{
  public class Program
  {
    // 
    //// Ninject
    //
    // Jest to kontener IoC (inwersja kontroli). Do swojego Kernela wczytuje moduły z zależnościami, i tam gdzie są potrzebne to je
    // wstrzykuje (np. do konstruktorów). Dzięki czemu nasze klasy są bardziej testowalne i "reusable". Ustalamy "zasady" tworzenia
    // danego obiektu, Ninject będzie się martwił za nas o instancjonowanie :)
    // Zajrzyj do DefaultModule, żeby zobaczyć przykłady definiowania zależności

    //private static readonly IKernel Kernel = ConfigureKernel();

    //private static IKernel ConfigureKernel()
    //{
    //  var kernel = new StandardKernel();
    //  kernel.Load(new DefaultModule());

    //  return kernel;
    //}

    static void Main(string[] args)
    {
      // 
      //// Ninject + WCF
      //

      //var debtService = NinjectWcfConfiguration.Create<GamingDebtService, NinjectServiceSelfHostFactory>();
      //var debtCollectorService = NinjectWcfConfiguration.Create<GamingDebtCollectorService, NinjectServiceSelfHostFactory>();

      //var host = new NinjectSelfHostBootstrapper(() => Kernel, debtService, debtCollectorService);

      //try
      //{
      //  host.Start();

      //  Console.WriteLine($"{nameof(GamingDebtService)} and {nameof(GamingDebtCollectorService)} started");

      //  Console.WriteLine("Press any key to exit");
      //  Console.ReadLine();
      //}
      //finally
      //{
      //  host.Dispose();
      //}

      var debtHost = new ServiceHost(typeof(GamingDebtService));
      var debtCollectorHost = new ServiceHost(typeof(GamingDebtCollectorService));

      debtHost.Open();

      Console.WriteLine($"{nameof(GamingDebtService)} started");

      debtCollectorHost.Open();

      Console.WriteLine($"{nameof(GamingDebtCollectorService)} started");

      Console.WriteLine("Press any key to exit");
      Console.ReadLine();

      debtHost.Close();
      debtCollectorHost.Close();
    }
  }
}
