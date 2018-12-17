using System.ComponentModel;

namespace GamingRegistryOfDebts.Entity
{
  public enum JobStatus
  {
    [Description("Brak")]
    None = 0,
    [Description("Nie podjęto akcji")]
    Idle,
    [Description("W trakcie")]
    InProgress,
    [Description("Brak potrzeby podejmowania akcji")]
    NoActionNeeded,
    [Description("Anulowano")]
    Cancelled,
    [Description("Gotowe")]
    Done
  }
}
