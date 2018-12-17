using System.Collections.Generic;

namespace GamingRegistryOfDebts.Entity
{
  public class PlayerDetails
  {
    public DebtorStatus DebtorStatus { get; set; }
    public Dictionary<string, string> InGameInfo { get; set; }
  }
}
