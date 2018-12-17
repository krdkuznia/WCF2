namespace GamingRegistryOfDebts.DebtCollectorClient
{
  partial class ClientForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbOrders = new System.Windows.Forms.TextBox();
      this.btnGetOrders = new System.Windows.Forms.Button();
      this.gbOrders = new System.Windows.Forms.GroupBox();
      this.gbPlayer = new System.Windows.Forms.GroupBox();
      this.lbPlayerServer = new System.Windows.Forms.Label();
      this.lbPlayerName = new System.Windows.Forms.Label();
      this.tbPlayerName = new System.Windows.Forms.TextBox();
      this.tbPlayerServer = new System.Windows.Forms.TextBox();
      this.tbPlayerInfo = new System.Windows.Forms.TextBox();
      this.btnCheckPlayer = new System.Windows.Forms.Button();
      this.gbStatus = new System.Windows.Forms.GroupBox();
      this.btnSetStatus = new System.Windows.Forms.Button();
      this.cbStatus = new System.Windows.Forms.ComboBox();
      this.lbStatus = new System.Windows.Forms.Label();
      this.tbOrderId = new System.Windows.Forms.TextBox();
      this.lbOrderId = new System.Windows.Forms.Label();
      this.gbOrders.SuspendLayout();
      this.gbPlayer.SuspendLayout();
      this.gbStatus.SuspendLayout();
      this.SuspendLayout();
      // 
      // tbOrders
      // 
      this.tbOrders.Location = new System.Drawing.Point(12, 48);
      this.tbOrders.Multiline = true;
      this.tbOrders.Name = "tbOrders";
      this.tbOrders.ReadOnly = true;
      this.tbOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbOrders.Size = new System.Drawing.Size(397, 130);
      this.tbOrders.TabIndex = 0;
      // 
      // btnGetOrders
      // 
      this.btnGetOrders.Location = new System.Drawing.Point(272, 19);
      this.btnGetOrders.Name = "btnGetOrders";
      this.btnGetOrders.Size = new System.Drawing.Size(137, 23);
      this.btnGetOrders.TabIndex = 1;
      this.btnGetOrders.Text = "Pobierz otwarte zlecenia";
      this.btnGetOrders.UseVisualStyleBackColor = true;
      this.btnGetOrders.Click += new System.EventHandler(this.OnGetOrdersButtonClicked);
      // 
      // gbOrders
      // 
      this.gbOrders.Controls.Add(this.tbOrders);
      this.gbOrders.Controls.Add(this.btnGetOrders);
      this.gbOrders.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbOrders.Location = new System.Drawing.Point(6, 6);
      this.gbOrders.Name = "gbOrders";
      this.gbOrders.Size = new System.Drawing.Size(573, 196);
      this.gbOrders.TabIndex = 2;
      this.gbOrders.TabStop = false;
      this.gbOrders.Text = "Zlecenia";
      // 
      // gbPlayer
      // 
      this.gbPlayer.Controls.Add(this.lbPlayerServer);
      this.gbPlayer.Controls.Add(this.lbPlayerName);
      this.gbPlayer.Controls.Add(this.tbPlayerName);
      this.gbPlayer.Controls.Add(this.tbPlayerServer);
      this.gbPlayer.Controls.Add(this.tbPlayerInfo);
      this.gbPlayer.Controls.Add(this.btnCheckPlayer);
      this.gbPlayer.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbPlayer.Location = new System.Drawing.Point(6, 202);
      this.gbPlayer.Name = "gbPlayer";
      this.gbPlayer.Size = new System.Drawing.Size(573, 218);
      this.gbPlayer.TabIndex = 3;
      this.gbPlayer.TabStop = false;
      this.gbPlayer.Text = "Gracz";
      // 
      // lbPlayerServer
      // 
      this.lbPlayerServer.AutoSize = true;
      this.lbPlayerServer.Location = new System.Drawing.Point(13, 51);
      this.lbPlayerServer.Name = "lbPlayerServer";
      this.lbPlayerServer.Size = new System.Drawing.Size(43, 13);
      this.lbPlayerServer.TabIndex = 5;
      this.lbPlayerServer.Text = "Serwer:";
      // 
      // lbPlayerName
      // 
      this.lbPlayerName.AutoSize = true;
      this.lbPlayerName.Location = new System.Drawing.Point(13, 25);
      this.lbPlayerName.Name = "lbPlayerName";
      this.lbPlayerName.Size = new System.Drawing.Size(43, 13);
      this.lbPlayerName.TabIndex = 4;
      this.lbPlayerName.Text = "Nazwa:";
      // 
      // tbPlayerName
      // 
      this.tbPlayerName.Location = new System.Drawing.Point(62, 22);
      this.tbPlayerName.Name = "tbPlayerName";
      this.tbPlayerName.Size = new System.Drawing.Size(155, 20);
      this.tbPlayerName.TabIndex = 3;
      // 
      // tbPlayerServer
      // 
      this.tbPlayerServer.Location = new System.Drawing.Point(62, 48);
      this.tbPlayerServer.Name = "tbPlayerServer";
      this.tbPlayerServer.Size = new System.Drawing.Size(155, 20);
      this.tbPlayerServer.TabIndex = 2;
      // 
      // tbPlayerInfo
      // 
      this.tbPlayerInfo.Location = new System.Drawing.Point(13, 77);
      this.tbPlayerInfo.Multiline = true;
      this.tbPlayerInfo.Name = "tbPlayerInfo";
      this.tbPlayerInfo.ReadOnly = true;
      this.tbPlayerInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbPlayerInfo.Size = new System.Drawing.Size(397, 130);
      this.tbPlayerInfo.TabIndex = 0;
      // 
      // btnCheckPlayer
      // 
      this.btnCheckPlayer.Location = new System.Drawing.Point(273, 48);
      this.btnCheckPlayer.Name = "btnCheckPlayer";
      this.btnCheckPlayer.Size = new System.Drawing.Size(137, 23);
      this.btnCheckPlayer.TabIndex = 1;
      this.btnCheckPlayer.Text = "Pobierz dane";
      this.btnCheckPlayer.UseVisualStyleBackColor = true;
      this.btnCheckPlayer.Click += new System.EventHandler(this.OnCheckPlayerButtonClicked);
      // 
      // gbStatus
      // 
      this.gbStatus.Controls.Add(this.btnSetStatus);
      this.gbStatus.Controls.Add(this.cbStatus);
      this.gbStatus.Controls.Add(this.lbStatus);
      this.gbStatus.Controls.Add(this.tbOrderId);
      this.gbStatus.Controls.Add(this.lbOrderId);
      this.gbStatus.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbStatus.Location = new System.Drawing.Point(6, 420);
      this.gbStatus.Name = "gbStatus";
      this.gbStatus.Size = new System.Drawing.Size(573, 100);
      this.gbStatus.TabIndex = 4;
      this.gbStatus.TabStop = false;
      this.gbStatus.Text = "Status";
      // 
      // btnSetStatus
      // 
      this.btnSetStatus.Location = new System.Drawing.Point(285, 62);
      this.btnSetStatus.Name = "btnSetStatus";
      this.btnSetStatus.Size = new System.Drawing.Size(108, 23);
      this.btnSetStatus.TabIndex = 4;
      this.btnSetStatus.Text = "Ustaw status";
      this.btnSetStatus.UseVisualStyleBackColor = true;
      this.btnSetStatus.Click += new System.EventHandler(this.OnSetStatusButtonClicked);
      // 
      // cbStatus
      // 
      this.cbStatus.FormattingEnabled = true;
      this.cbStatus.Location = new System.Drawing.Point(82, 47);
      this.cbStatus.Name = "cbStatus";
      this.cbStatus.Size = new System.Drawing.Size(160, 21);
      this.cbStatus.TabIndex = 3;
      // 
      // lbStatus
      // 
      this.lbStatus.AutoSize = true;
      this.lbStatus.Location = new System.Drawing.Point(36, 50);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(40, 13);
      this.lbStatus.TabIndex = 2;
      this.lbStatus.Text = "Status:";
      // 
      // tbOrderId
      // 
      this.tbOrderId.Location = new System.Drawing.Point(82, 21);
      this.tbOrderId.Name = "tbOrderId";
      this.tbOrderId.Size = new System.Drawing.Size(311, 20);
      this.tbOrderId.TabIndex = 1;
      // 
      // lbOrderId
      // 
      this.lbOrderId.AutoSize = true;
      this.lbOrderId.Location = new System.Drawing.Point(13, 24);
      this.lbOrderId.Name = "lbOrderId";
      this.lbOrderId.Size = new System.Drawing.Size(63, 13);
      this.lbOrderId.TabIndex = 0;
      this.lbOrderId.Text = "ID zlecenia:";
      // 
      // ClientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(430, 525);
      this.Controls.Add(this.gbStatus);
      this.Controls.Add(this.gbPlayer);
      this.Controls.Add(this.gbOrders);
      this.Name = "ClientForm";
      this.Padding = new System.Windows.Forms.Padding(6);
      this.Text = "Gamingowy Rejestr Długów";
      this.gbOrders.ResumeLayout(false);
      this.gbOrders.PerformLayout();
      this.gbPlayer.ResumeLayout(false);
      this.gbPlayer.PerformLayout();
      this.gbStatus.ResumeLayout(false);
      this.gbStatus.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox tbOrders;
    private System.Windows.Forms.Button btnGetOrders;
    private System.Windows.Forms.GroupBox gbOrders;
    private System.Windows.Forms.GroupBox gbPlayer;
    private System.Windows.Forms.Label lbPlayerServer;
    private System.Windows.Forms.Label lbPlayerName;
    private System.Windows.Forms.TextBox tbPlayerName;
    private System.Windows.Forms.TextBox tbPlayerServer;
    private System.Windows.Forms.TextBox tbPlayerInfo;
    private System.Windows.Forms.Button btnCheckPlayer;
    private System.Windows.Forms.GroupBox gbStatus;
    private System.Windows.Forms.Button btnSetStatus;
    private System.Windows.Forms.ComboBox cbStatus;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.TextBox tbOrderId;
    private System.Windows.Forms.Label lbOrderId;
  }
}

