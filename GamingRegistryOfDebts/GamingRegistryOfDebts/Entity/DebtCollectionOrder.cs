using System;

namespace GamingRegistryOfDebts.Entity
{
  public class DebtCollectionOrder
  {
    public Guid Id { get; set; }
    public DebtDetails DebtDetails { get; set; }
  }
}
