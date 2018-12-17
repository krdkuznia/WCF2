using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamingRegistryOfDebts.Contract;
using GamingRegistryOfDebts.Entity;

namespace GamingRegistryOfDebts.DebtClient
{
  public partial class ClientForm : Form
  {
    private GamingDebtServiceProxy _proxy = new GamingDebtServiceProxy("GamingDebtServiceEndpoint");

    public ClientForm()
    {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      var debtContexts = _proxy.GetDebtContextsDictionary();

      var bs = new BindingSource(debtContexts, null);

      cbDebtContexts.DisplayMember = "Value";
      cbDebtContexts.ValueMember = "Key";
      cbDebtContexts.DataSource = bs;
    }

    private void OnSendOrderButtonClicked(object sender, EventArgs e)
    {
      _proxy = new GamingDebtServiceProxy("GamingDebtServiceEndpoint");

      var orderId = _proxy.OrderCollection(new DebtDetails()
      {
        ClientName = tbClientName.Text,
        ClientRealm = tbServer.Text,
        DebtorName = tbDebtorName.Text,
        DebtorRealm = tbServer.Text,
        DebtAmount = nudDebtAmount.Value,
        DebtContextId = ((KeyValuePair<int, string>) cbDebtContexts.SelectedItem).Key
      });

      tbOrderResult.Text = $"Wysłano! ID zgłoszenia: {orderId}";

      _proxy.Close();
    }

    private void btnCheckStatus_Click(object sender, EventArgs e)
    {
      _proxy = new GamingDebtServiceProxy("GamingDebtServiceEndpoint");

      var status = _proxy.CheckCollectionStatus(new Guid(tbOrderId.Text));
      tbStatusCheckResult.Text = $"{status.Status.ToString()}";

      _proxy.Close();
    }

    private void btnCheckDebtor_Click(object sender, EventArgs e)
    {
      _proxy = new GamingDebtServiceProxy("GamingDebtServiceEndpoint");

      var status = _proxy.CheckDebtorStatus(tbDebtorCheckServer.Text, tbDebtorCheckName.Text);
      tbDebtorCheckResult.Text =
        $"Jest w rejestrze? {(status.IsInRegistry ? "TAK" : "NIE")} | Wysokość zobowiązania: {status.DebtAmount}";

      _proxy.Close();
    }
  }
}
