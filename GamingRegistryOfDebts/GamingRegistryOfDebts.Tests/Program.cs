using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamingRegistryOfDebts.DataAccess.Database;
using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.Service;

namespace GamingRegistryOfDebts.Tests
{
  public class Program
  {
    static void Main(string[] args)
    {
      var elo = new GamingDebtCollectionRepository().GetOrders("elo");
      //var elo = new BlizzardWowApiClient();
      //Console.WriteLine(Task.Run(() => elo.GetCharacterDetails("blackrock", "77elo")).GetAwaiter().GetResult());
    }
  }
}
