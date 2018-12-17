namespace GamingRegistryOfDebts.DebtClient
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
      this.cbDebtContexts = new System.Windows.Forms.ComboBox();
      this.lbDebtContexts = new System.Windows.Forms.Label();
      this.lbClientName = new System.Windows.Forms.Label();
      this.lbServer = new System.Windows.Forms.Label();
      this.lbDebtorName = new System.Windows.Forms.Label();
      this.tbClientName = new System.Windows.Forms.TextBox();
      this.tbDebtorName = new System.Windows.Forms.TextBox();
      this.tbServer = new System.Windows.Forms.TextBox();
      this.nudDebtAmount = new System.Windows.Forms.NumericUpDown();
      this.lbDebtAmount = new System.Windows.Forms.Label();
      this.btnSendOrder = new System.Windows.Forms.Button();
      this.lbOrder = new System.Windows.Forms.Label();
      this.tbOrderId = new System.Windows.Forms.TextBox();
      this.btnCheckStatus = new System.Windows.Forms.Button();
      this.gbOrder = new System.Windows.Forms.GroupBox();
      this.tbOrderResult = new System.Windows.Forms.TextBox();
      this.gbStatus = new System.Windows.Forms.GroupBox();
      this.tbStatusCheckResult = new System.Windows.Forms.TextBox();
      this.gbDebtorCheck = new System.Windows.Forms.GroupBox();
      this.tbDebtorCheckResult = new System.Windows.Forms.TextBox();
      this.btnCheckDebtor = new System.Windows.Forms.Button();
      this.lbDebtorCheckServer = new System.Windows.Forms.Label();
      this.lbDebtorCheckName = new System.Windows.Forms.Label();
      this.tbDebtorCheckName = new System.Windows.Forms.TextBox();
      this.tbDebtorCheckServer = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.nudDebtAmount)).BeginInit();
      this.gbOrder.SuspendLayout();
      this.gbStatus.SuspendLayout();
      this.gbDebtorCheck.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbDebtContexts
      // 
      this.cbDebtContexts.FormattingEnabled = true;
      this.cbDebtContexts.Location = new System.Drawing.Point(156, 130);
      this.cbDebtContexts.Name = "cbDebtContexts";
      this.cbDebtContexts.Size = new System.Drawing.Size(201, 21);
      this.cbDebtContexts.TabIndex = 0;
      // 
      // lbDebtContexts
      // 
      this.lbDebtContexts.AutoSize = true;
      this.lbDebtContexts.Location = new System.Drawing.Point(49, 133);
      this.lbDebtContexts.Name = "lbDebtContexts";
      this.lbDebtContexts.Size = new System.Drawing.Size(101, 13);
      this.lbDebtContexts.TabIndex = 1;
      this.lbDebtContexts.Text = "Okoliczności długu:";
      // 
      // lbClientName
      // 
      this.lbClientName.AutoSize = true;
      this.lbClientName.Location = new System.Drawing.Point(36, 29);
      this.lbClientName.Name = "lbClientName";
      this.lbClientName.Size = new System.Drawing.Size(114, 13);
      this.lbClientName.TabIndex = 2;
      this.lbClientName.Text = "Nazwa Twojej postaci:";
      // 
      // lbServer
      // 
      this.lbServer.AutoSize = true;
      this.lbServer.Location = new System.Drawing.Point(107, 81);
      this.lbServer.Name = "lbServer";
      this.lbServer.Size = new System.Drawing.Size(43, 13);
      this.lbServer.TabIndex = 3;
      this.lbServer.Text = "Serwer:";
      // 
      // lbDebtorName
      // 
      this.lbDebtorName.AutoSize = true;
      this.lbDebtorName.Location = new System.Drawing.Point(26, 55);
      this.lbDebtorName.Name = "lbDebtorName";
      this.lbDebtorName.Size = new System.Drawing.Size(124, 13);
      this.lbDebtorName.TabIndex = 4;
      this.lbDebtorName.Text = "Nazwa postaci dłużnika:";
      // 
      // tbClientName
      // 
      this.tbClientName.Location = new System.Drawing.Point(156, 26);
      this.tbClientName.Name = "tbClientName";
      this.tbClientName.Size = new System.Drawing.Size(201, 20);
      this.tbClientName.TabIndex = 5;
      // 
      // tbDebtorName
      // 
      this.tbDebtorName.Location = new System.Drawing.Point(156, 52);
      this.tbDebtorName.Name = "tbDebtorName";
      this.tbDebtorName.Size = new System.Drawing.Size(201, 20);
      this.tbDebtorName.TabIndex = 6;
      // 
      // tbServer
      // 
      this.tbServer.Location = new System.Drawing.Point(156, 78);
      this.tbServer.Name = "tbServer";
      this.tbServer.Size = new System.Drawing.Size(201, 20);
      this.tbServer.TabIndex = 7;
      // 
      // nudDebtAmount
      // 
      this.nudDebtAmount.DecimalPlaces = 2;
      this.nudDebtAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nudDebtAmount.Location = new System.Drawing.Point(156, 104);
      this.nudDebtAmount.Name = "nudDebtAmount";
      this.nudDebtAmount.Size = new System.Drawing.Size(120, 20);
      this.nudDebtAmount.TabIndex = 8;
      // 
      // lbDebtAmount
      // 
      this.lbDebtAmount.AutoSize = true;
      this.lbDebtAmount.Location = new System.Drawing.Point(59, 106);
      this.lbDebtAmount.Name = "lbDebtAmount";
      this.lbDebtAmount.Size = new System.Drawing.Size(91, 13);
      this.lbDebtAmount.TabIndex = 9;
      this.lbDebtAmount.Text = "Wysokość długu:";
      // 
      // btnSendOrder
      // 
      this.btnSendOrder.Location = new System.Drawing.Point(248, 167);
      this.btnSendOrder.Name = "btnSendOrder";
      this.btnSendOrder.Size = new System.Drawing.Size(109, 23);
      this.btnSendOrder.TabIndex = 10;
      this.btnSendOrder.Text = "Wyślij zgłoszenie";
      this.btnSendOrder.UseVisualStyleBackColor = true;
      this.btnSendOrder.Click += new System.EventHandler(this.OnSendOrderButtonClicked);
      // 
      // lbOrder
      // 
      this.lbOrder.AutoSize = true;
      this.lbOrder.Location = new System.Drawing.Point(40, 26);
      this.lbOrder.Name = "lbOrder";
      this.lbOrder.Size = new System.Drawing.Size(75, 13);
      this.lbOrder.TabIndex = 11;
      this.lbOrder.Text = "ID zgłoszenia:";
      // 
      // tbOrderId
      // 
      this.tbOrderId.Location = new System.Drawing.Point(121, 23);
      this.tbOrderId.Name = "tbOrderId";
      this.tbOrderId.Size = new System.Drawing.Size(236, 20);
      this.tbOrderId.TabIndex = 12;
      // 
      // btnCheckStatus
      // 
      this.btnCheckStatus.Location = new System.Drawing.Point(249, 49);
      this.btnCheckStatus.Name = "btnCheckStatus";
      this.btnCheckStatus.Size = new System.Drawing.Size(108, 23);
      this.btnCheckStatus.TabIndex = 13;
      this.btnCheckStatus.Text = "Sprawdź status";
      this.btnCheckStatus.UseVisualStyleBackColor = true;
      this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
      // 
      // gbOrder
      // 
      this.gbOrder.Controls.Add(this.tbOrderResult);
      this.gbOrder.Controls.Add(this.lbClientName);
      this.gbOrder.Controls.Add(this.cbDebtContexts);
      this.gbOrder.Controls.Add(this.lbDebtContexts);
      this.gbOrder.Controls.Add(this.lbServer);
      this.gbOrder.Controls.Add(this.btnSendOrder);
      this.gbOrder.Controls.Add(this.lbDebtorName);
      this.gbOrder.Controls.Add(this.lbDebtAmount);
      this.gbOrder.Controls.Add(this.tbClientName);
      this.gbOrder.Controls.Add(this.nudDebtAmount);
      this.gbOrder.Controls.Add(this.tbDebtorName);
      this.gbOrder.Controls.Add(this.tbServer);
      this.gbOrder.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbOrder.Location = new System.Drawing.Point(6, 6);
      this.gbOrder.Name = "gbOrder";
      this.gbOrder.Size = new System.Drawing.Size(383, 210);
      this.gbOrder.TabIndex = 14;
      this.gbOrder.TabStop = false;
      this.gbOrder.Text = "Zgłoszenie";
      // 
      // tbOrderResult
      // 
      this.tbOrderResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbOrderResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbOrderResult.Location = new System.Drawing.Point(6, 168);
      this.tbOrderResult.Name = "tbOrderResult";
      this.tbOrderResult.ReadOnly = true;
      this.tbOrderResult.Size = new System.Drawing.Size(232, 20);
      this.tbOrderResult.TabIndex = 11;
      // 
      // gbStatus
      // 
      this.gbStatus.Controls.Add(this.tbStatusCheckResult);
      this.gbStatus.Controls.Add(this.lbOrder);
      this.gbStatus.Controls.Add(this.tbOrderId);
      this.gbStatus.Controls.Add(this.btnCheckStatus);
      this.gbStatus.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbStatus.Location = new System.Drawing.Point(6, 216);
      this.gbStatus.Name = "gbStatus";
      this.gbStatus.Size = new System.Drawing.Size(383, 81);
      this.gbStatus.TabIndex = 15;
      this.gbStatus.TabStop = false;
      this.gbStatus.Text = "Status";
      // 
      // tbStatusCheckResult
      // 
      this.tbStatusCheckResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbStatusCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbStatusCheckResult.Location = new System.Drawing.Point(6, 50);
      this.tbStatusCheckResult.Name = "tbStatusCheckResult";
      this.tbStatusCheckResult.ReadOnly = true;
      this.tbStatusCheckResult.Size = new System.Drawing.Size(232, 20);
      this.tbStatusCheckResult.TabIndex = 14;
      // 
      // gbDebtorCheck
      // 
      this.gbDebtorCheck.Controls.Add(this.tbDebtorCheckResult);
      this.gbDebtorCheck.Controls.Add(this.btnCheckDebtor);
      this.gbDebtorCheck.Controls.Add(this.lbDebtorCheckServer);
      this.gbDebtorCheck.Controls.Add(this.lbDebtorCheckName);
      this.gbDebtorCheck.Controls.Add(this.tbDebtorCheckName);
      this.gbDebtorCheck.Controls.Add(this.tbDebtorCheckServer);
      this.gbDebtorCheck.Dock = System.Windows.Forms.DockStyle.Top;
      this.gbDebtorCheck.Location = new System.Drawing.Point(6, 297);
      this.gbDebtorCheck.Name = "gbDebtorCheck";
      this.gbDebtorCheck.Size = new System.Drawing.Size(383, 117);
      this.gbDebtorCheck.TabIndex = 16;
      this.gbDebtorCheck.TabStop = false;
      this.gbDebtorCheck.Text = "Sprawdź dłużnika";
      // 
      // tbDebtorCheckResult
      // 
      this.tbDebtorCheckResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbDebtorCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbDebtorCheckResult.Location = new System.Drawing.Point(6, 82);
      this.tbDebtorCheckResult.Name = "tbDebtorCheckResult";
      this.tbDebtorCheckResult.ReadOnly = true;
      this.tbDebtorCheckResult.Size = new System.Drawing.Size(232, 20);
      this.tbDebtorCheckResult.TabIndex = 15;
      // 
      // btnCheckDebtor
      // 
      this.btnCheckDebtor.Location = new System.Drawing.Point(249, 81);
      this.btnCheckDebtor.Name = "btnCheckDebtor";
      this.btnCheckDebtor.Size = new System.Drawing.Size(108, 23);
      this.btnCheckDebtor.TabIndex = 14;
      this.btnCheckDebtor.Text = "Sprawdź gracza";
      this.btnCheckDebtor.UseVisualStyleBackColor = true;
      this.btnCheckDebtor.Click += new System.EventHandler(this.btnCheckDebtor_Click);
      // 
      // lbDebtorCheckServer
      // 
      this.lbDebtorCheckServer.AutoSize = true;
      this.lbDebtorCheckServer.Location = new System.Drawing.Point(107, 53);
      this.lbDebtorCheckServer.Name = "lbDebtorCheckServer";
      this.lbDebtorCheckServer.Size = new System.Drawing.Size(43, 13);
      this.lbDebtorCheckServer.TabIndex = 8;
      this.lbDebtorCheckServer.Text = "Serwer:";
      // 
      // lbDebtorCheckName
      // 
      this.lbDebtorCheckName.AutoSize = true;
      this.lbDebtorCheckName.Location = new System.Drawing.Point(26, 27);
      this.lbDebtorCheckName.Name = "lbDebtorCheckName";
      this.lbDebtorCheckName.Size = new System.Drawing.Size(124, 13);
      this.lbDebtorCheckName.TabIndex = 9;
      this.lbDebtorCheckName.Text = "Nazwa postaci dłużnika:";
      // 
      // tbDebtorCheckName
      // 
      this.tbDebtorCheckName.Location = new System.Drawing.Point(156, 24);
      this.tbDebtorCheckName.Name = "tbDebtorCheckName";
      this.tbDebtorCheckName.Size = new System.Drawing.Size(201, 20);
      this.tbDebtorCheckName.TabIndex = 10;
      // 
      // tbDebtorCheckServer
      // 
      this.tbDebtorCheckServer.Location = new System.Drawing.Point(156, 50);
      this.tbDebtorCheckServer.Name = "tbDebtorCheckServer";
      this.tbDebtorCheckServer.Size = new System.Drawing.Size(201, 20);
      this.tbDebtorCheckServer.TabIndex = 11;
      // 
      // ClientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(395, 417);
      this.Controls.Add(this.gbDebtorCheck);
      this.Controls.Add(this.gbStatus);
      this.Controls.Add(this.gbOrder);
      this.Name = "ClientForm";
      this.Padding = new System.Windows.Forms.Padding(6);
      this.Text = "Gamingowy Rejestr Długów";
      ((System.ComponentModel.ISupportInitialize)(this.nudDebtAmount)).EndInit();
      this.gbOrder.ResumeLayout(false);
      this.gbOrder.PerformLayout();
      this.gbStatus.ResumeLayout(false);
      this.gbStatus.PerformLayout();
      this.gbDebtorCheck.ResumeLayout(false);
      this.gbDebtorCheck.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbDebtContexts;
    private System.Windows.Forms.Label lbDebtContexts;
    private System.Windows.Forms.Label lbClientName;
    private System.Windows.Forms.Label lbServer;
    private System.Windows.Forms.Label lbDebtorName;
    private System.Windows.Forms.TextBox tbClientName;
    private System.Windows.Forms.TextBox tbDebtorName;
    private System.Windows.Forms.TextBox tbServer;
    private System.Windows.Forms.NumericUpDown nudDebtAmount;
    private System.Windows.Forms.Label lbDebtAmount;
    private System.Windows.Forms.Button btnSendOrder;
    private System.Windows.Forms.Label lbOrder;
    private System.Windows.Forms.TextBox tbOrderId;
    private System.Windows.Forms.Button btnCheckStatus;
    private System.Windows.Forms.GroupBox gbOrder;
    private System.Windows.Forms.TextBox tbOrderResult;
    private System.Windows.Forms.GroupBox gbStatus;
    private System.Windows.Forms.TextBox tbStatusCheckResult;
    private System.Windows.Forms.GroupBox gbDebtorCheck;
    private System.Windows.Forms.TextBox tbDebtorCheckResult;
    private System.Windows.Forms.Button btnCheckDebtor;
    private System.Windows.Forms.Label lbDebtorCheckServer;
    private System.Windows.Forms.Label lbDebtorCheckName;
    private System.Windows.Forms.TextBox tbDebtorCheckName;
    private System.Windows.Forms.TextBox tbDebtorCheckServer;
  }
}

