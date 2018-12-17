using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using GamingRegistryOfDebts.DataAccess.Database.Connection;
using GamingRegistryOfDebts.DataAccess.Database.Interface;

namespace GamingRegistryOfDebts.DataAccess.Database
{
  public class DebtRepository : IDebtRepository
  {
    public Guid AddDebt(Guid debtorId, Guid clientId, int debtContextId, decimal debtAmount)
    {
      var game = "WoW";

      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        return conn.ExecuteScalar<Guid>(@"
           declare @debtId uniqueidentifier = newid()

            INSERT INTO [Debt].[Debt]
                       ([id]
                       ,[debtorId]
                       ,[debtAmount]
                       ,[debtContextId])
                 VALUES
                       (@debtId
                       ,@debtorId
                       ,@debtAmount
                       ,@debtContextId)

            INSERT INTO [Job].[DebtCollectionOrder]
                       ([id]
                       ,[debtId]
                       ,[stateId]
                       ,[stateDescription]
                       ,[additionalInformation]
                       ,[clientId]
                       ,[assignedPerson])
		               output inserted.id
                 VALUES
                       (newid()
                       ,@debtId
                       ,1
                       ,'Nie podjęto akcji'
                       ,null
                       ,@clientId
                       ,null)
            ", new {debtorId, debtAmount, debtContextId, clientId});
      }
    }

    public Dictionary<int, string> GetDebtContexts()
    {
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        return conn.Query<KeyValuePair<int, string>>("select [key] = id, [value] = description from Debt.D_DebtContext")
          .ToDictionary(p => p.Key, p => p.Value);
      }
    }
  }
}