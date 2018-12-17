namespace GamingRegistryOfDebts.Entity
{
  public class DebtDetails
  {
    public string DebtorName { get; set; }
    public string DebtorRealm { get; set; }
    public string ClientName { get; set; }
    public string ClientRealm { get; set; }
    public int DebtContextId { get; set; }
    public decimal DebtAmount { get; set; }
  }
}
