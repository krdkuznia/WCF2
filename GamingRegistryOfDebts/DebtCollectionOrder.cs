using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingRegistryOfDebts
{
  public class DebtCollectionOrder
  {
    public Guid Id { get; set; }
    public DebtDetails DebtDetails { get; set; }
  }
}
