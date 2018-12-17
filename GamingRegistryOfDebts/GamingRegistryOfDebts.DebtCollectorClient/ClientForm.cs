using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DebtCollectorClient
{
  public partial class ClientForm : Form
  {
    private GamingDebtCollectorProxy _proxy;
    public ClientForm()
    {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      cbStatus.DisplayMember = "Description";
      cbStatus.ValueMember = "Value";
      cbStatus.DataSource = Enum.GetValues(typeof(JobStatus))
        .Cast<Enum>()
        .Select(value => new
        {
          (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description,
          value
        })
        .OrderBy(item => item.value)
        .ToList();
    }

    private void OnGetOrdersButtonClicked(object sender, EventArgs e)
    {
      _proxy = new GamingDebtCollectorProxy("GamingDebtCollectorServiceEndpoint");

      var orders = _proxy.GetPendingOrders();

      var sb = new StringBuilder();

      foreach (var order in orders)
      {
        sb.AppendLine(
          $"ID zlecenia: {order.Id} | Klient: {order.DebtDetails.ClientName} | Serwer klienta: {order.DebtDetails.ClientRealm} | Dłużnik: {order.DebtDetails.DebtorName} | Serwer dłużnika: {order.DebtDetails.DebtorRealm} | {order.DebtDetails.DebtAmount} | Okoliczności: {order.DebtDetails.DebtContextId}");
      }

      tbOrders.Text = sb.ToString();

      _proxy.Close();
    }

    private void OnCheckPlayerButtonClicked(object sender, EventArgs e)
    {
      _proxy = new GamingDebtCollectorProxy("GamingDebtCollectorServiceEndpoint");

      var playerInfo = _proxy.GetPlayerDetails(tbPlayerServer.Text, tbPlayerName.Text);

      var sb = new StringBuilder();

      sb.AppendLine(
        $"Jest w rejestrze? {(playerInfo.DebtorStatus.IsInRegistry ? "TAK" : "NIE")} | Kwota zobowiązania: {playerInfo.DebtorStatus.DebtAmount}");

      foreach (var info in playerInfo.InGameInfo)
      {
        sb.AppendLine($"{info.Key}: {info.Value}");
      }

      _proxy.Close();

      tbPlayerInfo.Text = sb.ToString();
    }

    private void OnSetStatusButtonClicked(object sender, EventArgs e)
    {
      _proxy = new GamingDebtCollectorProxy("GamingDebtCollectorServiceEndpoint");

      _proxy.SetOrderStatus(new Guid(tbOrderId.Text), (JobStatus)cbStatus.SelectedIndex, string.Empty );

      _proxy.Close();
    }
  }
}
