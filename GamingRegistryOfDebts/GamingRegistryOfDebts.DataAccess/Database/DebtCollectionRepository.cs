using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using GamingRegistryOfDebts.DataAccess.Database.Connection;
using GamingRegistryOfDebts.DataAccess.Database.Interface;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DataAccess.Database
{
  public class DebtCollectionRepository : IDebtCollectionRepository
  {
    public IEnumerable<DebtCollectionOrder> GetAllOrders()
    {
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        return conn.Query<Guid, string, string, string, string, int, decimal, DebtCollectionOrder>(@"select dco.id, 
	                    debtorName = p_d.name,
	                    debtorRealm = p_d.realm,
	                    clientName = p_c.name,
	                    clientRealm = p_c.realm,
	                    d.debtContextId,
	                    d.debtAmount
                    from Job.DebtCollectionOrder dco
                    join Debt.Debt d on d.id = dco.debtId
                    join Player.Player p_d on p_d.id = d.debtorId
                    join Player.Player p_c on p_c.id = dco.clientId",
          (id, debtorName, debtorRealm, clientName, clientRealm, debtContextId, debtAmount) => new DebtCollectionOrder()
          {
            DebtDetails = new DebtDetails()
            {
              ClientName = clientName,
              ClientRealm = clientRealm,
              DebtAmount = debtAmount,
              DebtContextId = debtContextId,
              DebtorName = debtorName,
              DebtorRealm = debtorRealm
            },
            Id = id
          }, splitOn: "id, debtorName, debtorRealm, clientName, clientRealm, debtContextId, debtAmount");
      }
    }

    public IEnumerable<DebtCollectionOrder> GetOrders(string userName)
    {
      // Otwieramy połączenie z bazą (connection string jako połączenie)
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        //                Typy danych (po kolei) zwracanych z zapytania...    i na co ma się złożyć na docelowy typ
        return conn.Query<Guid, string, string, string, string, int, decimal, DebtCollectionOrder>(@"
          select dco.id, 
	          debtorName = p_d.name,
	          debtorRealm = p_d.realm,
	          clientName = p_c.name,
	          clientRealm = p_c.realm,
	          d.debtContextId,
	          d.debtAmount
          from Job.DebtCollectionOrder dco
          join Debt.Debt d on d.id = dco.debtId
          join Player.Player p_d on p_d.id = d.debtorId
          join Player.Player p_c on p_c.id = dco.clientId
          where dco.assignedPerson = @userName",
          (id, debtorName, debtorRealm, clientName, clientRealm, debtContextId, debtAmount) => new DebtCollectionOrder() //Mapowanie pojedyńczych kolumn z zapytania na DebtCollectionOrder. Bardzo ważne, by nazwy w tym delegacie były takie same jak w zapytaniu
          {
            DebtDetails = new DebtDetails()
            {
              ClientName = clientName, ClientRealm = clientRealm, DebtAmount = debtAmount,
              DebtContextId = debtContextId,
              DebtorName = debtorName, DebtorRealm = debtorRealm
            },
            Id = id
          }, new {userName}, // parametry tutaj - nazwa musi pasować temu co w zapytaniach, można podać więcej - new {A,B,C,...}
          splitOn: "id, debtorName, debtorRealm, clientName, clientRealm, debtContextId, debtAmount"); // Czasami wyskakuje błąd dot. splitOn, ja rozwiązuję to tak, że wpisuję wszystkie kolumny z zapytania...
      }
    }

    public DebtCollectionStatus GetOrderStatus(Guid orderId)
    {
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        return conn.Query<int, string, DebtCollectionStatus>(@"
          select stateId, additionalInformation 
          from Job.DebtCollectionOrder
          where id = @orderId",
          (stateId, additionalInformation) => new DebtCollectionStatus()
          { AdditionalInfo = additionalInformation, Status = (JobStatus)stateId }, new { orderId }, splitOn: "stateId, additionalInformation").FirstOrDefault();
      }
    }

    public void UpdateOrderStatus(Guid orderId, DebtCollectionStatus status)
    {
      var stateId = (int) status.Status;
      var stateDescription = status.Status.ToString();
      var additionalInformation = status.AdditionalInfo;

      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        conn.Execute(@"
          update Job.DebtCollectionOrder
          set stateId = @stateId,
          stateDescription = @stateDescription,
          additionalInformation = @additionalInformation
          where id = @orderId", new {stateId, stateDescription, additionalInformation, orderId});
      }
    }

    public void UpdateOrderAssignment(Guid orderId, string userName)
    {
      using (var conn = new SqlConnection(GrdDb.ConnectionKey))
      {
        conn.Execute(@"
          update Job.DebtCollectionOrder
          set assignedPerson = @userName
          where id = @orderId", new {userName, orderId});
      }
    }
  }
}