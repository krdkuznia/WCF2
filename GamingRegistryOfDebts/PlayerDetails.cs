using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts
{
  public class PlayerDetails
  {
    public DebtorStatus DebtorStatus { get; set; }
    public Dictionary<string, string> InGameInfo { get; set; }
  }
}
