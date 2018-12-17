using System;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using GamingRegistryOfDebts.DataAccess.Database.Connection;
using GamingRegistryOfDebts.DataAccess.Database.Interface;

namespace GamingRegistryOfDebts.DataAccess.Database
{
  public class PlayerRepository : IPlayerRepository
  {
    public Guid GetPlayerId(string realm, string name)
    {
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        return conn.Query<Guid>("select id from Player.Player where realm = @realm and name = @name", new {realm, name}).FirstOrDefault();
      }
    }

    public Guid AddPlayer(string realm, string name)
    {
      var game = "WoW";

      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        return conn.ExecuteScalar<Guid>(@"
           INSERT INTO [Player].[Player]
             ([id]
             ,[name]
             ,[realm]
             ,[game])
		       OUTPUT inserted.id
           VALUES
                 (newid(),
                 @name,
                 @realm
                 ,@game)", new {name, realm, game});
      }
    }
  }
}