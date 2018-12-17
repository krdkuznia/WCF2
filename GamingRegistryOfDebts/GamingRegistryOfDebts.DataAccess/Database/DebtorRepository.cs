using System.Data.SqlClient;
using Dapper;
using GamingRegistryOfDebts.DataAccess.Database.Connection;
using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DataAccess.Database
{
  public class DebtorRepository : IDebtorRepository
  {
    public DebtorStatus GetDebtorStatus(string realm, string name)
    {
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        var result = conn.QuerySingleOrDefault<decimal>(@"
          select sum(d.debtAmount) 
          from Debt.Debt d
          join Player.Player p on p.id = d.debtorId
          where p.name = @name and p.realm = @realm
          group by p.id", new { name, realm });

        return new DebtorStatus() {DebtAmount = result, IsInRegistry = result != default(decimal)};

      }
    }
  }
}