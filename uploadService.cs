// Decompiled with JetBrains decompiler
// Type: s2fit.uploadService
// Assembly: s2fit, Version=2013.3.18.9, Culture=neutral, PublicKeyToken=null
// MVID: 2E7A4E2C-2CBB-4E29-BE48-9870B53D7378
// Assembly location: C:\Users\JoséMaríaFloresZazo\Downloads\SCALE2FIT\s2fit.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace s2fit
{
  [DesignerGenerated]
  public class uploadService : Form
  {
    private IContainer components;
    [AccessedThroughProperty("cmdUS_Enable")]
    private Button _cmdUS_Enable;
    [AccessedThroughProperty("cmdUS_Disable")]
    private Button _cmdUS_Disable;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("txtUS_Pwd")]
    private TextBox _txtUS_Pwd;
    [AccessedThroughProperty("txtUS_UserID")]
    private TextBox _txtUS_UserID;
    [AccessedThroughProperty("lblUS_Pwd")]
    private Label _lblUS_Pwd;
    [AccessedThroughProperty("lblUS_Usr")]
    private Label _lblUS_Usr;
    [AccessedThroughProperty("RichTextBox1")]
    private RichTextBox _RichTextBox1;
    public string xmlConfigFile;

    public uploadService()
    {
      this.Load += new EventHandler(this.uploadService_Load);
      this.xmlConfigFile = string.Empty;
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (uploadService));
      this.cmdUS_Enable = new Button();
      this.cmdUS_Disable = new Button();
      this.GroupBox1 = new GroupBox();
      this.txtUS_Pwd = new TextBox();
      this.txtUS_UserID = new TextBox();
      this.lblUS_Pwd = new Label();
      this.lblUS_Usr = new Label();
      this.RichTextBox1 = new RichTextBox();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      Button cmdUsEnable1 = this.cmdUS_Enable;
      Point point1 = new Point(236, 155);
      Point point2 = point1;
      cmdUsEnable1.Location = point2;
      this.cmdUS_Enable.Name = "cmdUS_Enable";
      Button cmdUsEnable2 = this.cmdUS_Enable;
      Size size1 = new Size(145, 25);
      Size size2 = size1;
      cmdUsEnable2.Size = size2;
      this.cmdUS_Enable.TabIndex = 0;
      this.cmdUS_Enable.Text = "Enable Upload";
      this.cmdUS_Enable.UseVisualStyleBackColor = true;
      Button cmdUsDisable1 = this.cmdUS_Disable;
      point1 = new Point(387, 155);
      Point point3 = point1;
      cmdUsDisable1.Location = point3;
      this.cmdUS_Disable.Name = "cmdUS_Disable";
      Button cmdUsDisable2 = this.cmdUS_Disable;
      size1 = new Size(145, 25);
      Size size3 = size1;
      cmdUsDisable2.Size = size3;
      this.cmdUS_Disable.TabIndex = 1;
      this.cmdUS_Disable.Text = "Disable Upload";
      this.cmdUS_Disable.UseVisualStyleBackColor = true;
      this.GroupBox1.Controls.Add((Control) this.RichTextBox1);
      this.GroupBox1.Controls.Add((Control) this.txtUS_Pwd);
      this.GroupBox1.Controls.Add((Control) this.txtUS_UserID);
      this.GroupBox1.Controls.Add((Control) this.lblUS_Pwd);
      this.GroupBox1.Controls.Add((Control) this.lblUS_Usr);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(12, 9);
      Point point4 = point1;
      groupBox1_1.Location = point4;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(520, 137);
      Size size4 = size1;
      groupBox1_2.Size = size4;
      this.GroupBox1.TabIndex = 2;
      this.GroupBox1.TabStop = false;
      TextBox txtUsPwd1 = this.txtUS_Pwd;
      point1 = new Point(101, 49);
      Point point5 = point1;
      txtUsPwd1.Location = point5;
      this.txtUS_Pwd.Name = "txtUS_Pwd";
      TextBox txtUsPwd2 = this.txtUS_Pwd;
      size1 = new Size(385, 20);
      Size size5 = size1;
      txtUsPwd2.Size = size5;
      this.txtUS_Pwd.TabIndex = 3;
      TextBox txtUsUserId1 = this.txtUS_UserID;
      point1 = new Point(101, 23);
      Point point6 = point1;
      txtUsUserId1.Location = point6;
      this.txtUS_UserID.Name = "txtUS_UserID";
      TextBox txtUsUserId2 = this.txtUS_UserID;
      size1 = new Size(385, 20);
      Size size6 = size1;
      txtUsUserId2.Size = size6;
      this.txtUS_UserID.TabIndex = 2;
      this.lblUS_Pwd.AutoSize = true;
      Label lblUsPwd1 = this.lblUS_Pwd;
      point1 = new Point(28, 52);
      Point point7 = point1;
      lblUsPwd1.Location = point7;
      this.lblUS_Pwd.Name = "lblUS_Pwd";
      Label lblUsPwd2 = this.lblUS_Pwd;
      size1 = new Size(53, 13);
      Size size7 = size1;
      lblUsPwd2.Size = size7;
      this.lblUS_Pwd.TabIndex = 1;
      this.lblUS_Pwd.Text = "Password";
      this.lblUS_Usr.AutoSize = true;
      Label lblUsUsr1 = this.lblUS_Usr;
      point1 = new Point(28, 26);
      Point point8 = point1;
      lblUsUsr1.Location = point8;
      this.lblUS_Usr.Name = "lblUS_Usr";
      Label lblUsUsr2 = this.lblUS_Usr;
      size1 = new Size(60, 13);
      Size size8 = size1;
      lblUsUsr2.Size = size8;
      this.lblUS_Usr.TabIndex = 0;
      this.lblUS_Usr.Text = "User Name";
      this.RichTextBox1.BackColor = SystemColors.HighlightText;
      this.RichTextBox1.BorderStyle = BorderStyle.FixedSingle;
      RichTextBox richTextBox1_1 = this.RichTextBox1;
      point1 = new Point(101, 75);
      Point point9 = point1;
      richTextBox1_1.Location = point9;
      this.RichTextBox1.Name = "RichTextBox1";
      RichTextBox richTextBox1_2 = this.RichTextBox1;
      size1 = new Size(385, 45);
      Size size9 = size1;
      richTextBox1_2.Size = size9;
      this.RichTextBox1.TabIndex = 4;
      this.RichTextBox1.Text = componentResourceManager.GetString("RichTextBox1.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(544, 189);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.cmdUS_Disable);
      this.Controls.Add((Control) this.cmdUS_Enable);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (uploadService);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Garmin Connect";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Button cmdUS_Enable
    {
      get => this._cmdUS_Enable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdEnable_Click);
        if (this._cmdUS_Enable != null)
          this._cmdUS_Enable.Click -= eventHandler;
        this._cmdUS_Enable = value;
        if (this._cmdUS_Enable == null)
          return;
        this._cmdUS_Enable.Click += eventHandler;
      }
    }

    internal virtual Button cmdUS_Disable
    {
      get => this._cmdUS_Disable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdDisable_Click);
        if (this._cmdUS_Disable != null)
          this._cmdUS_Disable.Click -= eventHandler;
        this._cmdUS_Disable = value;
        if (this._cmdUS_Disable == null)
          return;
        this._cmdUS_Disable.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      get => this._GroupBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal virtual TextBox txtUS_Pwd
    {
      get => this._txtUS_Pwd;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtUS_Pwd = value;
    }

    internal virtual TextBox txtUS_UserID
    {
      get => this._txtUS_UserID;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtUS_UserID = value;
    }

    internal virtual Label lblUS_Pwd
    {
      get => this._lblUS_Pwd;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblUS_Pwd = value;
    }

    internal virtual Label lblUS_Usr
    {
      get => this._lblUS_Usr;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblUS_Usr = value;
    }

    internal virtual RichTextBox RichTextBox1
    {
      get => this._RichTextBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._RichTextBox1 = value;
    }

    private void cargaIdioma(int intTipo)
    {
      using (new ResXResourceSet(intTipo != 1 ? "stringResource.resx" : "stringResource.es.resx"))
        ;
    }

    private void uploadService_Load(object sender, EventArgs e)
    {
      if (Operators.CompareString(Strings.Mid(CultureInfo.CurrentCulture.ToString(), 1, 2), "es", false) == 0)
        this.cargaIdioma(1);
      else
        this.cargaIdioma(1000);
    }

    private void cmdEnable_Click(object sender, EventArgs e)
    {
    }

    private void cmdDisable_Click(object sender, EventArgs e)
    {
    }
  }
}
