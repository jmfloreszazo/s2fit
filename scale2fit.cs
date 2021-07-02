// Decompiled with JetBrains decompiler
// Type: s2fit.scale2fit
// Assembly: s2fit, Version=2013.3.18.9, Culture=neutral, PublicKeyToken=null
// MVID: 2E7A4E2C-2CBB-4E29-BE48-9870B53D7378
// Assembly location: C:\Users\JoséMaríaFloresZazo\Downloads\SCALE2FIT\s2fit.exe

using Dynastream.Fit;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using s2fit.My;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace s2fit
{
  [DesignerGenerated]
  public class scale2fit : Form
  {
    private IContainer components;
    [AccessedThroughProperty("cboTipoGeneracion")]
    private ComboBox _cboTipoGeneracion;
    [AccessedThroughProperty("fraFicheroExportacion")]
    private GroupBox _fraFicheroExportacion;
    [AccessedThroughProperty("txtRuta")]
    private TextBox _txtRuta;
    [AccessedThroughProperty("fraConfiguracionManual")]
    private GroupBox _fraConfiguracionManual;
    [AccessedThroughProperty("chkListMedidas")]
    private CheckedListBox _chkListMedidas;
    [AccessedThroughProperty("lblMedidas")]
    private Label _lblMedidas;
    [AccessedThroughProperty("chkFechaActual")]
    private CheckBox _chkFechaActual;
    [AccessedThroughProperty("cmdExportarRuta")]
    private Button _cmdExportarRuta;
    [AccessedThroughProperty("panHeader")]
    private Panel _panHeader;
    [AccessedThroughProperty("lblTipoGeneracion")]
    private Label _lblTipoGeneracion;
    [AccessedThroughProperty("cmdConfigurar")]
    private Button _cmdConfigurar;
    [AccessedThroughProperty("panFoot")]
    private Panel _panFoot;
    [AccessedThroughProperty("lblCopyright")]
    private Label _lblCopyright;
    [AccessedThroughProperty("linkWEB")]
    private LinkLabel _linkWEB;
    [AccessedThroughProperty("fraExportarMedidas")]
    private GroupBox _fraExportarMedidas;
    [AccessedThroughProperty("lblSetMetabolicAge")]
    private Label _lblSetMetabolicAge;
    [AccessedThroughProperty("lblSetBoneMass")]
    private Label _lblSetBoneMass;
    [AccessedThroughProperty("lblSetVisceralFatRating")]
    private Label _lblSetVisceralFatRating;
    [AccessedThroughProperty("lblSetPercentHydration")]
    private Label _lblSetPercentHydration;
    [AccessedThroughProperty("lblSetPhysiqueRating")]
    private Label _lblSetPhysiqueRating;
    [AccessedThroughProperty("lblSetPercentFat")]
    private Label _lblSetPercentFat;
    [AccessedThroughProperty("lblSetMuscleMass")]
    private Label _lblSetMuscleMass;
    [AccessedThroughProperty("txtSetMetabolicAge")]
    private TextBox _txtSetMetabolicAge;
    [AccessedThroughProperty("txtSetBoneMass")]
    private TextBox _txtSetBoneMass;
    [AccessedThroughProperty("txtSetVisceralFatRating")]
    private TextBox _txtSetVisceralFatRating;
    [AccessedThroughProperty("txtSetPercentHydration")]
    private TextBox _txtSetPercentHydration;
    [AccessedThroughProperty("txtSetPhysiqueRating")]
    private TextBox _txtSetPhysiqueRating;
    [AccessedThroughProperty("txtSetPercentFat")]
    private TextBox _txtSetPercentFat;
    [AccessedThroughProperty("txtSetMuscleMass")]
    private TextBox _txtSetMuscleMass;
    [AccessedThroughProperty("txtSetWeight")]
    private TextBox _txtSetWeight;
    [AccessedThroughProperty("lblSetWeight")]
    private Label _lblSetWeight;
    [AccessedThroughProperty("cmdGenerar")]
    private Button _cmdGenerar;
    [AccessedThroughProperty("chkUltimasMedidas")]
    private CheckBox _chkUltimasMedidas;
    [AccessedThroughProperty("lbl2SetBoneMass")]
    private Label _lbl2SetBoneMass;
    [AccessedThroughProperty("lbl2SetPercentHydration")]
    private Label _lbl2SetPercentHydration;
    [AccessedThroughProperty("lbl2SetPercentFat")]
    private Label _lbl2SetPercentFat;
    [AccessedThroughProperty("lbl2SetWeight")]
    private Label _lbl2SetWeight;
    [AccessedThroughProperty("lblSetActiveMet")]
    private Label _lblSetActiveMet;
    [AccessedThroughProperty("txtSetActiveMet")]
    private TextBox _txtSetActiveMet;
    [AccessedThroughProperty("lblFechaActual")]
    private Label _lblFechaActual;
    [AccessedThroughProperty("lbl2SetMetabolicAge")]
    private Label _lbl2SetMetabolicAge;
    [AccessedThroughProperty("lbl2SetMuscleMass")]
    private Label _lbl2SetMuscleMass;
    [AccessedThroughProperty("lbl2SetActiveMet")]
    private Label _lbl2SetActiveMet;
    [AccessedThroughProperty("txtFechaActual")]
    private MaskedTextBox _txtFechaActual;
    [AccessedThroughProperty("fraFitBit")]
    private GroupBox _fraFitBit;
    [AccessedThroughProperty("cmdAutorizarFitBit")]
    private Button _cmdAutorizarFitBit;
    [AccessedThroughProperty("rtbFitBit")]
    private RichTextBox _rtbFitBit;
    [AccessedThroughProperty("fraExportarMedidasAutomaticas")]
    private GroupBox _fraExportarMedidasAutomaticas;
    [AccessedThroughProperty("txtPerfil")]
    private TextBox _txtPerfil;
    [AccessedThroughProperty("lblUrsConectado")]
    private Label _lblUrsConectado;
    [AccessedThroughProperty("cmdExportar")]
    private Button _cmdExportar;
    [AccessedThroughProperty("frawithings")]
    private GroupBox _frawithings;
    [AccessedThroughProperty("cmdEnlazarWithings")]
    private Button _cmdEnlazarWithings;
    [AccessedThroughProperty("txtClavePublica")]
    private TextBox _txtClavePublica;
    [AccessedThroughProperty("txtIdUsuario")]
    private TextBox _txtIdUsuario;
    [AccessedThroughProperty("lblPublicKey")]
    private Label _lblPublicKey;
    [AccessedThroughProperty("lblUsrID")]
    private Label _lblUsrID;
    [AccessedThroughProperty("RadioButton2")]
    private RadioButton _RadioButton2;
    [AccessedThroughProperty("RadioButton1")]
    private RadioButton _RadioButton1;
    [AccessedThroughProperty("lblWhatMeasure")]
    private Label _lblWhatMeasure;
    [AccessedThroughProperty("chkLstBoxFechas")]
    private CheckedListBox _chkLstBoxFechas;
    [AccessedThroughProperty("RadioButton5")]
    private RadioButton _RadioButton5;
    [AccessedThroughProperty("RadioButton4")]
    private RadioButton _RadioButton4;
    [AccessedThroughProperty("RadioButton3")]
    private RadioButton _RadioButton3;
    [AccessedThroughProperty("chkKGLB")]
    private CheckBox _chkKGLB;
    [AccessedThroughProperty("pctBoxPaypal")]
    private PictureBox _pctBoxPaypal;
    [AccessedThroughProperty("cmdUpload")]
    private Button _cmdUpload;
    private const float LB = 0.453592f;
    private const float KG = 1f;
    private bool blnLoad;
    private string xmlConfigFile;
    private bool[] arrItemsMedidas;
    private bool blnFechaActual;
    private bool blnUltimasMedidas;
    private int intTipoGeneracion;
    private string strRuta;
    private string strFichero;
    private float MultiplicoPor;
    private string msgboxNoPinFitBit;
    private string msgboxNoDatoDisponible;
    private string msgboxImposibleLanzar;
    private string msgboxFicheroExito;
    private string msgboxFechaHora;
    private string msgboxError;
    private string msgboxfbdDescription;
    private string msgboxGenerar;
    private string msgboxPeso;
    private string msgBoxAlmenosUna;
    private string msgAtLeastOne;

    public scale2fit()
    {
      this.Load += new EventHandler(this.scale2fit_Load);
      this.blnLoad = false;
      this.xmlConfigFile = "config.xml";
      this.arrItemsMedidas = new bool[9];
      this.MultiplicoPor = 1f;
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (scale2fit));
      this.cboTipoGeneracion = new ComboBox();
      this.fraFicheroExportacion = new GroupBox();
      this.cmdUpload = new Button();
      this.cmdExportarRuta = new Button();
      this.txtRuta = new TextBox();
      this.fraConfiguracionManual = new GroupBox();
      this.chkKGLB = new CheckBox();
      this.chkUltimasMedidas = new CheckBox();
      this.chkListMedidas = new CheckedListBox();
      this.lblMedidas = new Label();
      this.chkFechaActual = new CheckBox();
      this.panHeader = new Panel();
      this.cmdExportar = new Button();
      this.lblTipoGeneracion = new Label();
      this.cmdConfigurar = new Button();
      this.panFoot = new Panel();
      this.pctBoxPaypal = new PictureBox();
      this.lblCopyright = new Label();
      this.linkWEB = new LinkLabel();
      this.fraExportarMedidas = new GroupBox();
      this.txtSetMetabolicAge = new TextBox();
      this.txtSetPhysiqueRating = new TextBox();
      this.txtSetActiveMet = new TextBox();
      this.txtFechaActual = new MaskedTextBox();
      this.lbl2SetActiveMet = new Label();
      this.lbl2SetMetabolicAge = new Label();
      this.lbl2SetMuscleMass = new Label();
      this.lblFechaActual = new Label();
      this.lblSetActiveMet = new Label();
      this.lbl2SetBoneMass = new Label();
      this.lbl2SetPercentHydration = new Label();
      this.lbl2SetPercentFat = new Label();
      this.lbl2SetWeight = new Label();
      this.lblSetMetabolicAge = new Label();
      this.lblSetBoneMass = new Label();
      this.lblSetVisceralFatRating = new Label();
      this.lblSetPercentHydration = new Label();
      this.lblSetPhysiqueRating = new Label();
      this.lblSetPercentFat = new Label();
      this.lblSetMuscleMass = new Label();
      this.txtSetBoneMass = new TextBox();
      this.txtSetVisceralFatRating = new TextBox();
      this.txtSetPercentHydration = new TextBox();
      this.txtSetPercentFat = new TextBox();
      this.txtSetMuscleMass = new TextBox();
      this.txtSetWeight = new TextBox();
      this.lblSetWeight = new Label();
      this.cmdGenerar = new Button();
      this.fraFitBit = new GroupBox();
      this.cmdAutorizarFitBit = new Button();
      this.rtbFitBit = new RichTextBox();
      this.fraExportarMedidasAutomaticas = new GroupBox();
      this.RadioButton5 = new RadioButton();
      this.RadioButton4 = new RadioButton();
      this.RadioButton3 = new RadioButton();
      this.RadioButton2 = new RadioButton();
      this.RadioButton1 = new RadioButton();
      this.lblWhatMeasure = new Label();
      this.chkLstBoxFechas = new CheckedListBox();
      this.txtPerfil = new TextBox();
      this.lblUrsConectado = new Label();
      this.frawithings = new GroupBox();
      this.cmdEnlazarWithings = new Button();
      this.txtClavePublica = new TextBox();
      this.txtIdUsuario = new TextBox();
      this.lblPublicKey = new Label();
      this.lblUsrID = new Label();
      this.fraFicheroExportacion.SuspendLayout();
      this.fraConfiguracionManual.SuspendLayout();
      this.panHeader.SuspendLayout();
      this.panFoot.SuspendLayout();
      ((ISupportInitialize) this.pctBoxPaypal).BeginInit();
      this.fraExportarMedidas.SuspendLayout();
      this.fraFitBit.SuspendLayout();
      this.fraExportarMedidasAutomaticas.SuspendLayout();
      this.frawithings.SuspendLayout();
      this.SuspendLayout();
      this.cboTipoGeneracion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cboTipoGeneracion.FormattingEnabled = true;
      ComboBox cboTipoGeneracion1 = this.cboTipoGeneracion;
      Point point1 = new Point(97, 14);
      Point point2 = point1;
      cboTipoGeneracion1.Location = point2;
      this.cboTipoGeneracion.Name = "cboTipoGeneracion";
      ComboBox cboTipoGeneracion2 = this.cboTipoGeneracion;
      Size size1 = new Size(213, 21);
      Size size2 = size1;
      cboTipoGeneracion2.Size = size2;
      this.cboTipoGeneracion.TabIndex = 1;
      this.fraFicheroExportacion.Controls.Add((Control) this.cmdUpload);
      this.fraFicheroExportacion.Controls.Add((Control) this.cmdExportarRuta);
      this.fraFicheroExportacion.Controls.Add((Control) this.txtRuta);
      this.fraFicheroExportacion.Enabled = false;
      GroupBox ficheroExportacion1 = this.fraFicheroExportacion;
      point1 = new Point(11, 272);
      Point point3 = point1;
      ficheroExportacion1.Location = point3;
      this.fraFicheroExportacion.Name = "fraFicheroExportacion";
      GroupBox ficheroExportacion2 = this.fraFicheroExportacion;
      size1 = new Size(473, 52);
      Size size3 = size1;
      ficheroExportacion2.Size = size3;
      this.fraFicheroExportacion.TabIndex = 6;
      this.fraFicheroExportacion.TabStop = false;
      this.fraFicheroExportacion.Text = "File Export Route";
      this.cmdUpload.Enabled = false;
      Button cmdUpload1 = this.cmdUpload;
      point1 = new Point(414, 20);
      Point point4 = point1;
      cmdUpload1.Location = point4;
      this.cmdUpload.Name = "cmdUpload";
      Button cmdUpload2 = this.cmdUpload;
      size1 = new Size(49, 20);
      Size size4 = size1;
      cmdUpload2.Size = size4;
      this.cmdUpload.TabIndex = 9;
      this.cmdUpload.Text = "Upload";
      this.cmdUpload.UseVisualStyleBackColor = true;
      Button cmdExportarRuta1 = this.cmdExportarRuta;
      point1 = new Point(383, 20);
      Point point5 = point1;
      cmdExportarRuta1.Location = point5;
      this.cmdExportarRuta.Name = "cmdExportarRuta";
      Button cmdExportarRuta2 = this.cmdExportarRuta;
      size1 = new Size(25, 20);
      Size size5 = size1;
      cmdExportarRuta2.Size = size5;
      this.cmdExportarRuta.TabIndex = 8;
      this.cmdExportarRuta.Text = "...";
      this.cmdExportarRuta.UseVisualStyleBackColor = true;
      this.txtRuta.Enabled = false;
      TextBox txtRuta1 = this.txtRuta;
      point1 = new Point(14, 20);
      Point point6 = point1;
      txtRuta1.Location = point6;
      this.txtRuta.Name = "txtRuta";
      TextBox txtRuta2 = this.txtRuta;
      size1 = new Size(363, 20);
      Size size6 = size1;
      txtRuta2.Size = size6;
      this.txtRuta.TabIndex = 7;
      this.fraConfiguracionManual.Controls.Add((Control) this.chkKGLB);
      this.fraConfiguracionManual.Controls.Add((Control) this.chkUltimasMedidas);
      this.fraConfiguracionManual.Controls.Add((Control) this.chkListMedidas);
      this.fraConfiguracionManual.Controls.Add((Control) this.lblMedidas);
      this.fraConfiguracionManual.Controls.Add((Control) this.chkFechaActual);
      this.fraConfiguracionManual.Enabled = false;
      GroupBox configuracionManual1 = this.fraConfiguracionManual;
      point1 = new Point(1100, 59);
      Point point7 = point1;
      configuracionManual1.Location = point7;
      this.fraConfiguracionManual.Name = "fraConfiguracionManual";
      GroupBox configuracionManual2 = this.fraConfiguracionManual;
      size1 = new Size(473, 205);
      Size size7 = size1;
      configuracionManual2.Size = size7;
      this.fraConfiguracionManual.TabIndex = 3;
      this.fraConfiguracionManual.TabStop = false;
      this.fraConfiguracionManual.Text = "Configuration";
      this.chkKGLB.AutoSize = true;
      CheckBox chkKglb1 = this.chkKGLB;
      point1 = new Point(264, 88);
      Point point8 = point1;
      chkKglb1.Location = point8;
      this.chkKGLB.Name = "chkKGLB";
      CheckBox chkKglb2 = this.chkKGLB;
      size1 = new Size(101, 17);
      Size size8 = size1;
      chkKglb2.Size = size8;
      this.chkKGLB.TabIndex = 7;
      this.chkKGLB.Text = "Measures in KG";
      this.chkKGLB.UseVisualStyleBackColor = true;
      this.chkKGLB.Visible = false;
      this.chkUltimasMedidas.AutoSize = true;
      CheckBox chkUltimasMedidas1 = this.chkUltimasMedidas;
      point1 = new Point(264, 65);
      Point point9 = point1;
      chkUltimasMedidas1.Location = point9;
      this.chkUltimasMedidas.Name = "chkUltimasMedidas";
      CheckBox chkUltimasMedidas2 = this.chkUltimasMedidas;
      size1 = new Size(159, 17);
      Size size9 = size1;
      chkUltimasMedidas2.Size = size9;
      this.chkUltimasMedidas.TabIndex = 6;
      this.chkUltimasMedidas.Text = "Propose the latest measures";
      this.chkUltimasMedidas.UseVisualStyleBackColor = true;
      this.chkListMedidas.FormattingEnabled = true;
      CheckedListBox chkListMedidas1 = this.chkListMedidas;
      point1 = new Point(74, 42);
      Point point10 = point1;
      chkListMedidas1.Location = point10;
      this.chkListMedidas.Name = "chkListMedidas";
      CheckedListBox chkListMedidas2 = this.chkListMedidas;
      size1 = new Size(169, 139);
      Size size10 = size1;
      chkListMedidas2.Size = size10;
      this.chkListMedidas.TabIndex = 4;
      this.lblMedidas.AutoSize = true;
      Label lblMedidas1 = this.lblMedidas;
      point1 = new Point(12, 42);
      Point point11 = point1;
      lblMedidas1.Location = point11;
      this.lblMedidas.Name = "lblMedidas";
      Label lblMedidas2 = this.lblMedidas;
      size1 = new Size(56, 13);
      Size size11 = size1;
      lblMedidas2.Size = size11;
      this.lblMedidas.TabIndex = 4;
      this.lblMedidas.Text = "Measures:";
      this.chkFechaActual.AutoSize = true;
      CheckBox chkFechaActual1 = this.chkFechaActual;
      point1 = new Point(264, 42);
      Point point12 = point1;
      chkFechaActual1.Location = point12;
      this.chkFechaActual.Name = "chkFechaActual";
      CheckBox chkFechaActual2 = this.chkFechaActual;
      size1 = new Size(203, 17);
      Size size12 = size1;
      chkFechaActual2.Size = size12;
      this.chkFechaActual.TabIndex = 5;
      this.chkFechaActual.Text = "Propose current system date and time";
      this.chkFechaActual.UseVisualStyleBackColor = true;
      this.panHeader.BackColor = SystemColors.AppWorkspace;
      this.panHeader.Controls.Add((Control) this.cmdExportar);
      this.panHeader.Controls.Add((Control) this.lblTipoGeneracion);
      this.panHeader.Controls.Add((Control) this.cboTipoGeneracion);
      this.panHeader.Controls.Add((Control) this.cmdConfigurar);
      this.panHeader.Dock = DockStyle.Top;
      Panel panHeader1 = this.panHeader;
      point1 = new Point(0, 0);
      Point point13 = point1;
      panHeader1.Location = point13;
      this.panHeader.Name = "panHeader";
      Panel panHeader2 = this.panHeader;
      size1 = new Size(496, 48);
      Size size13 = size1;
      panHeader2.Size = size13;
      this.panHeader.TabIndex = 0;
      Button cmdExportar1 = this.cmdExportar;
      point1 = new Point(405, 14);
      Point point14 = point1;
      cmdExportar1.Location = point14;
      this.cmdExportar.Name = "cmdExportar";
      Button cmdExportar2 = this.cmdExportar;
      size1 = new Size(78, 21);
      Size size14 = size1;
      cmdExportar2.Size = size14;
      this.cmdExportar.TabIndex = 7;
      this.cmdExportar.Text = "&Export";
      this.cmdExportar.UseVisualStyleBackColor = true;
      this.lblTipoGeneracion.AutoSize = true;
      Label lblTipoGeneracion1 = this.lblTipoGeneracion;
      point1 = new Point(11, 18);
      Point point15 = point1;
      lblTipoGeneracion1.Location = point15;
      this.lblTipoGeneracion.Name = "lblTipoGeneracion";
      Label lblTipoGeneracion2 = this.lblTipoGeneracion;
      size1 = new Size(81, 13);
      Size size15 = size1;
      lblTipoGeneracion2.Size = size15;
      this.lblTipoGeneracion.TabIndex = 6;
      this.lblTipoGeneracion.Text = "File Generation:";
      Button cmdConfigurar1 = this.cmdConfigurar;
      point1 = new Point(319, 14);
      Point point16 = point1;
      cmdConfigurar1.Location = point16;
      this.cmdConfigurar.Name = "cmdConfigurar";
      Button cmdConfigurar2 = this.cmdConfigurar;
      size1 = new Size(78, 21);
      Size size16 = size1;
      cmdConfigurar2.Size = size16;
      this.cmdConfigurar.TabIndex = 2;
      this.cmdConfigurar.Text = "&Configuration";
      this.cmdConfigurar.UseVisualStyleBackColor = true;
      this.panFoot.BackColor = SystemColors.AppWorkspace;
      this.panFoot.Controls.Add((Control) this.pctBoxPaypal);
      this.panFoot.Controls.Add((Control) this.lblCopyright);
      this.panFoot.Controls.Add((Control) this.linkWEB);
      this.panFoot.Dock = DockStyle.Bottom;
      Panel panFoot1 = this.panFoot;
      point1 = new Point(0, 338);
      Point point17 = point1;
      panFoot1.Location = point17;
      this.panFoot.Name = "panFoot";
      Panel panFoot2 = this.panFoot;
      size1 = new Size(496, 35);
      Size size17 = size1;
      panFoot2.Size = size17;
      this.panFoot.TabIndex = 200;
      this.pctBoxPaypal.Anchor = AnchorStyles.None;
      PictureBox pctBoxPaypal1 = this.pctBoxPaypal;
      point1 = new Point(215, 7);
      Point point18 = point1;
      pctBoxPaypal1.Location = point18;
      this.pctBoxPaypal.Name = "pctBoxPaypal";
      PictureBox pctBoxPaypal2 = this.pctBoxPaypal;
      size1 = new Size(74, 21);
      Size size18 = size1;
      pctBoxPaypal2.Size = size18;
      this.pctBoxPaypal.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pctBoxPaypal.TabIndex = 203;
      this.pctBoxPaypal.TabStop = false;
      this.lblCopyright.AutoSize = true;
      Label lblCopyright1 = this.lblCopyright;
      point1 = new Point(385, 11);
      Point point19 = point1;
      lblCopyright1.Location = point19;
      this.lblCopyright.Name = "lblCopyright";
      Label lblCopyright2 = this.lblCopyright;
      size1 = new Size(99, 13);
      Size size19 = size1;
      lblCopyright2.Size = size19;
      this.lblCopyright.TabIndex = 202;
      this.lblCopyright.Text = "© jmfloreszazo.com";
      this.linkWEB.AutoSize = true;
      LinkLabel linkWeb1 = this.linkWEB;
      point1 = new Point(12, 11);
      Point point20 = point1;
      linkWeb1.Location = point20;
      this.linkWEB.Name = "linkWEB";
      LinkLabel linkWeb2 = this.linkWEB;
      size1 = new Size(118, 13);
      Size size20 = size1;
      linkWeb2.Size = size20;
      this.linkWEB.TabIndex = 201;
      this.linkWEB.TabStop = true;
      this.linkWEB.Text = "http://jmfloreszazo.com";
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetMetabolicAge);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetPhysiqueRating);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetActiveMet);
      this.fraExportarMedidas.Controls.Add((Control) this.txtFechaActual);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetActiveMet);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetMetabolicAge);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetMuscleMass);
      this.fraExportarMedidas.Controls.Add((Control) this.lblFechaActual);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetActiveMet);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetBoneMass);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetPercentHydration);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetPercentFat);
      this.fraExportarMedidas.Controls.Add((Control) this.lbl2SetWeight);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetMetabolicAge);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetBoneMass);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetVisceralFatRating);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetPercentHydration);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetPhysiqueRating);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetPercentFat);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetMuscleMass);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetBoneMass);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetVisceralFatRating);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetPercentHydration);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetPercentFat);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetMuscleMass);
      this.fraExportarMedidas.Controls.Add((Control) this.txtSetWeight);
      this.fraExportarMedidas.Controls.Add((Control) this.lblSetWeight);
      GroupBox fraExportarMedidas1 = this.fraExportarMedidas;
      point1 = new Point(1100, 59);
      Point point21 = point1;
      fraExportarMedidas1.Location = point21;
      this.fraExportarMedidas.Name = "fraExportarMedidas";
      GroupBox fraExportarMedidas2 = this.fraExportarMedidas;
      size1 = new Size(473, 205);
      Size size21 = size1;
      fraExportarMedidas2.Size = size21;
      this.fraExportarMedidas.TabIndex = 9;
      this.fraExportarMedidas.TabStop = false;
      this.fraExportarMedidas.Text = "Measures";
      TextBox txtSetMetabolicAge1 = this.txtSetMetabolicAge;
      point1 = new Point(100, 149);
      Point point22 = point1;
      txtSetMetabolicAge1.Location = point22;
      this.txtSetMetabolicAge.Name = "txtSetMetabolicAge";
      TextBox txtSetMetabolicAge2 = this.txtSetMetabolicAge;
      size1 = new Size(68, 20);
      Size size22 = size1;
      txtSetMetabolicAge2.Size = size22;
      this.txtSetMetabolicAge.TabIndex = 28;
      this.txtSetMetabolicAge.TextAlign = HorizontalAlignment.Right;
      TextBox setPhysiqueRating1 = this.txtSetPhysiqueRating;
      point1 = new Point(100, 123);
      Point point23 = point1;
      setPhysiqueRating1.Location = point23;
      this.txtSetPhysiqueRating.Name = "txtSetPhysiqueRating";
      TextBox setPhysiqueRating2 = this.txtSetPhysiqueRating;
      size1 = new Size(68, 20);
      Size size23 = size1;
      setPhysiqueRating2.Size = size23;
      this.txtSetPhysiqueRating.TabIndex = 26;
      this.txtSetPhysiqueRating.TextAlign = HorizontalAlignment.Right;
      TextBox txtSetActiveMet1 = this.txtSetActiveMet;
      point1 = new Point(365, 149);
      Point point24 = point1;
      txtSetActiveMet1.Location = point24;
      this.txtSetActiveMet.Name = "txtSetActiveMet";
      TextBox txtSetActiveMet2 = this.txtSetActiveMet;
      size1 = new Size(68, 20);
      Size size24 = size1;
      txtSetActiveMet2.Size = size24;
      this.txtSetActiveMet.TabIndex = 29;
      this.txtSetActiveMet.TextAlign = HorizontalAlignment.Right;
      this.txtFechaActual.Culture = new CultureInfo("");
      MaskedTextBox txtFechaActual1 = this.txtFechaActual;
      point1 = new Point(101, 45);
      Point point25 = point1;
      txtFechaActual1.Location = point25;
      this.txtFechaActual.Mask = "00/00/0000 00:00";
      this.txtFechaActual.Name = "txtFechaActual";
      MaskedTextBox txtFechaActual2 = this.txtFechaActual;
      size1 = new Size(108, 20);
      Size size25 = size1;
      txtFechaActual2.Size = size25;
      this.txtFechaActual.TabIndex = 20;
      this.txtFechaActual.TextAlign = HorizontalAlignment.Center;
      this.txtFechaActual.ValidatingType = typeof (System.DateTime);
      this.lbl2SetActiveMet.AutoSize = true;
      this.lbl2SetActiveMet.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label lbl2SetActiveMet1 = this.lbl2SetActiveMet;
      point1 = new Point(437, 152);
      Point point26 = point1;
      lbl2SetActiveMet1.Location = point26;
      this.lbl2SetActiveMet.Name = "lbl2SetActiveMet";
      Label lbl2SetActiveMet2 = this.lbl2SetActiveMet;
      size1 = new Size(14, 13);
      Size size26 = size1;
      lbl2SetActiveMet2.Size = size26;
      this.lbl2SetActiveMet.TabIndex = 26;
      this.lbl2SetActiveMet.Text = "C";
      this.lbl2SetMetabolicAge.AutoSize = true;
      this.lbl2SetMetabolicAge.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label lbl2SetMetabolicAge1 = this.lbl2SetMetabolicAge;
      point1 = new Point(172, 152);
      Point point27 = point1;
      lbl2SetMetabolicAge1.Location = point27;
      this.lbl2SetMetabolicAge.Name = "lbl2SetMetabolicAge";
      Label lbl2SetMetabolicAge2 = this.lbl2SetMetabolicAge;
      size1 = new Size(34, 13);
      Size size27 = size1;
      lbl2SetMetabolicAge2.Size = size27;
      this.lbl2SetMetabolicAge.TabIndex = 25;
      this.lbl2SetMetabolicAge.Text = "Years";
      this.lbl2SetMuscleMass.AutoSize = true;
      this.lbl2SetMuscleMass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label lbl2SetMuscleMass1 = this.lbl2SetMuscleMass;
      point1 = new Point(437, 100);
      Point point28 = point1;
      lbl2SetMuscleMass1.Location = point28;
      this.lbl2SetMuscleMass.Name = "lbl2SetMuscleMass";
      Label lbl2SetMuscleMass2 = this.lbl2SetMuscleMass;
      size1 = new Size(20, 13);
      Size size28 = size1;
      lbl2SetMuscleMass2.Size = size28;
      this.lbl2SetMuscleMass.TabIndex = 24;
      this.lbl2SetMuscleMass.Text = "Kg";
      this.lblFechaActual.AutoSize = true;
      Label lblFechaActual1 = this.lblFechaActual;
      point1 = new Point(12, 49);
      Point point29 = point1;
      lblFechaActual1.Location = point29;
      this.lblFechaActual.Name = "lblFechaActual";
      Label lblFechaActual2 = this.lblFechaActual;
      size1 = new Size(80, 13);
      Size size29 = size1;
      lblFechaActual2.Size = size29;
      this.lblFechaActual.TabIndex = 22;
      this.lblFechaActual.Text = "Date and Time:";
      this.lblSetActiveMet.AutoSize = true;
      Label lblSetActiveMet1 = this.lblSetActiveMet;
      point1 = new Point(233, 152);
      Point point30 = point1;
      lblSetActiveMet1.Location = point30;
      this.lblSetActiveMet.Name = "lblSetActiveMet";
      Label lblSetActiveMet2 = this.lblSetActiveMet;
      size1 = new Size(101, 13);
      Size size30 = size1;
      lblSetActiveMet2.Size = size30;
      this.lblSetActiveMet.TabIndex = 21;
      this.lblSetActiveMet.Text = "Daily Caloric Intake:";
      this.lbl2SetBoneMass.AutoSize = true;
      this.lbl2SetBoneMass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label lbl2SetBoneMass1 = this.lbl2SetBoneMass;
      point1 = new Point(172, 100);
      Point point31 = point1;
      lbl2SetBoneMass1.Location = point31;
      this.lbl2SetBoneMass.Name = "lbl2SetBoneMass";
      Label lbl2SetBoneMass2 = this.lbl2SetBoneMass;
      size1 = new Size(20, 13);
      Size size31 = size1;
      lbl2SetBoneMass2.Size = size31;
      this.lbl2SetBoneMass.TabIndex = 19;
      this.lbl2SetBoneMass.Text = "Kg";
      this.lbl2SetPercentHydration.AutoSize = true;
      this.lbl2SetPercentHydration.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label percentHydration1 = this.lbl2SetPercentHydration;
      point1 = new Point(437, 74);
      Point point32 = point1;
      percentHydration1.Location = point32;
      this.lbl2SetPercentHydration.Name = "lbl2SetPercentHydration";
      Label percentHydration2 = this.lbl2SetPercentHydration;
      size1 = new Size(15, 13);
      Size size32 = size1;
      percentHydration2.Size = size32;
      this.lbl2SetPercentHydration.TabIndex = 18;
      this.lbl2SetPercentHydration.Text = "%";
      this.lbl2SetPercentFat.AutoSize = true;
      this.lbl2SetPercentFat.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label lbl2SetPercentFat1 = this.lbl2SetPercentFat;
      point1 = new Point(172, 74);
      Point point33 = point1;
      lbl2SetPercentFat1.Location = point33;
      this.lbl2SetPercentFat.Name = "lbl2SetPercentFat";
      Label lbl2SetPercentFat2 = this.lbl2SetPercentFat;
      size1 = new Size(15, 13);
      Size size33 = size1;
      lbl2SetPercentFat2.Size = size33;
      this.lbl2SetPercentFat.TabIndex = 17;
      this.lbl2SetPercentFat.Text = "%";
      this.lbl2SetWeight.AutoSize = true;
      this.lbl2SetWeight.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      Label lbl2SetWeight1 = this.lbl2SetWeight;
      point1 = new Point(437, 48);
      Point point34 = point1;
      lbl2SetWeight1.Location = point34;
      this.lbl2SetWeight.Name = "lbl2SetWeight";
      Label lbl2SetWeight2 = this.lbl2SetWeight;
      size1 = new Size(20, 13);
      Size size34 = size1;
      lbl2SetWeight2.Size = size34;
      this.lbl2SetWeight.TabIndex = 16;
      this.lbl2SetWeight.Text = "Kg";
      this.lblSetMetabolicAge.AutoSize = true;
      Label lblSetMetabolicAge1 = this.lblSetMetabolicAge;
      point1 = new Point(12, 150);
      Point point35 = point1;
      lblSetMetabolicAge1.Location = point35;
      this.lblSetMetabolicAge.Name = "lblSetMetabolicAge";
      Label lblSetMetabolicAge2 = this.lblSetMetabolicAge;
      size1 = new Size(78, 13);
      Size size35 = size1;
      lblSetMetabolicAge2.Size = size35;
      this.lblSetMetabolicAge.TabIndex = 15;
      this.lblSetMetabolicAge.Text = "Metabolic Age:";
      this.lblSetBoneMass.AutoSize = true;
      Label lblSetBoneMass1 = this.lblSetBoneMass;
      point1 = new Point(12, 100);
      Point point36 = point1;
      lblSetBoneMass1.Location = point36;
      this.lblSetBoneMass.Name = "lblSetBoneMass";
      Label lblSetBoneMass2 = this.lblSetBoneMass;
      size1 = new Size(63, 13);
      Size size36 = size1;
      lblSetBoneMass2.Size = size36;
      this.lblSetBoneMass.TabIndex = 14;
      this.lblSetBoneMass.Text = "Bone Mass:";
      this.lblSetVisceralFatRating.AutoSize = true;
      Label visceralFatRating1 = this.lblSetVisceralFatRating;
      point1 = new Point(233, 126);
      Point point37 = point1;
      visceralFatRating1.Location = point37;
      this.lblSetVisceralFatRating.Name = "lblSetVisceralFatRating";
      Label visceralFatRating2 = this.lblSetVisceralFatRating;
      size1 = new Size(65, 13);
      Size size37 = size1;
      visceralFatRating2.Size = size37;
      this.lblSetVisceralFatRating.TabIndex = 13;
      this.lblSetVisceralFatRating.Text = "Visceral Fat:";
      this.lblSetPercentHydration.AutoSize = true;
      Label percentHydration3 = this.lblSetPercentHydration;
      point1 = new Point(233, 74);
      Point point38 = point1;
      percentHydration3.Location = point38;
      this.lblSetPercentHydration.Name = "lblSetPercentHydration";
      Label percentHydration4 = this.lblSetPercentHydration;
      size1 = new Size(66, 13);
      Size size38 = size1;
      percentHydration4.Size = size38;
      this.lblSetPercentHydration.TabIndex = 12;
      this.lblSetPercentHydration.Text = "Body Water:";
      this.lblSetPhysiqueRating.AutoSize = true;
      Label setPhysiqueRating3 = this.lblSetPhysiqueRating;
      point1 = new Point(12, 126);
      Point point39 = point1;
      setPhysiqueRating3.Location = point39;
      this.lblSetPhysiqueRating.Name = "lblSetPhysiqueRating";
      Label setPhysiqueRating4 = this.lblSetPhysiqueRating;
      size1 = new Size(87, 13);
      Size size39 = size1;
      setPhysiqueRating4.Size = size39;
      this.lblSetPhysiqueRating.TabIndex = 11;
      this.lblSetPhysiqueRating.Text = "Physique Rating:";
      this.lblSetPercentFat.AutoSize = true;
      Label lblSetPercentFat1 = this.lblSetPercentFat;
      point1 = new Point(12, 74);
      Point point40 = point1;
      lblSetPercentFat1.Location = point40;
      this.lblSetPercentFat.Name = "lblSetPercentFat";
      Label lblSetPercentFat2 = this.lblSetPercentFat;
      size1 = new Size(52, 13);
      Size size40 = size1;
      lblSetPercentFat2.Size = size40;
      this.lblSetPercentFat.TabIndex = 2;
      this.lblSetPercentFat.Text = "Body Fat:";
      this.lblSetMuscleMass.AutoSize = true;
      Label lblSetMuscleMass1 = this.lblSetMuscleMass;
      point1 = new Point(233, 100);
      Point point41 = point1;
      lblSetMuscleMass1.Location = point41;
      this.lblSetMuscleMass.Name = "lblSetMuscleMass";
      Label lblSetMuscleMass2 = this.lblSetMuscleMass;
      size1 = new Size(72, 13);
      Size size41 = size1;
      lblSetMuscleMass2.Size = size41;
      this.lblSetMuscleMass.TabIndex = 9;
      this.lblSetMuscleMass.Text = "Muscle Mass:";
      TextBox txtSetBoneMass1 = this.txtSetBoneMass;
      point1 = new Point(100, 97);
      Point point42 = point1;
      txtSetBoneMass1.Location = point42;
      this.txtSetBoneMass.Name = "txtSetBoneMass";
      TextBox txtSetBoneMass2 = this.txtSetBoneMass;
      size1 = new Size(68, 20);
      Size size42 = size1;
      txtSetBoneMass2.Size = size42;
      this.txtSetBoneMass.TabIndex = 24;
      this.txtSetBoneMass.TextAlign = HorizontalAlignment.Right;
      TextBox visceralFatRating3 = this.txtSetVisceralFatRating;
      point1 = new Point(365, 123);
      Point point43 = point1;
      visceralFatRating3.Location = point43;
      this.txtSetVisceralFatRating.Name = "txtSetVisceralFatRating";
      TextBox visceralFatRating4 = this.txtSetVisceralFatRating;
      size1 = new Size(68, 20);
      Size size43 = size1;
      visceralFatRating4.Size = size43;
      this.txtSetVisceralFatRating.TabIndex = 27;
      this.txtSetVisceralFatRating.TextAlign = HorizontalAlignment.Right;
      TextBox percentHydration5 = this.txtSetPercentHydration;
      point1 = new Point(365, 71);
      Point point44 = point1;
      percentHydration5.Location = point44;
      this.txtSetPercentHydration.Name = "txtSetPercentHydration";
      TextBox percentHydration6 = this.txtSetPercentHydration;
      size1 = new Size(68, 20);
      Size size44 = size1;
      percentHydration6.Size = size44;
      this.txtSetPercentHydration.TabIndex = 23;
      this.txtSetPercentHydration.TextAlign = HorizontalAlignment.Right;
      TextBox txtSetPercentFat1 = this.txtSetPercentFat;
      point1 = new Point(100, 71);
      Point point45 = point1;
      txtSetPercentFat1.Location = point45;
      this.txtSetPercentFat.Name = "txtSetPercentFat";
      TextBox txtSetPercentFat2 = this.txtSetPercentFat;
      size1 = new Size(68, 20);
      Size size45 = size1;
      txtSetPercentFat2.Size = size45;
      this.txtSetPercentFat.TabIndex = 22;
      this.txtSetPercentFat.TextAlign = HorizontalAlignment.Right;
      TextBox txtSetMuscleMass1 = this.txtSetMuscleMass;
      point1 = new Point(365, 97);
      Point point46 = point1;
      txtSetMuscleMass1.Location = point46;
      this.txtSetMuscleMass.Name = "txtSetMuscleMass";
      TextBox txtSetMuscleMass2 = this.txtSetMuscleMass;
      size1 = new Size(68, 20);
      Size size46 = size1;
      txtSetMuscleMass2.Size = size46;
      this.txtSetMuscleMass.TabIndex = 25;
      this.txtSetMuscleMass.TextAlign = HorizontalAlignment.Right;
      TextBox txtSetWeight1 = this.txtSetWeight;
      point1 = new Point(365, 45);
      Point point47 = point1;
      txtSetWeight1.Location = point47;
      this.txtSetWeight.Name = "txtSetWeight";
      TextBox txtSetWeight2 = this.txtSetWeight;
      size1 = new Size(68, 20);
      Size size47 = size1;
      txtSetWeight2.Size = size47;
      this.txtSetWeight.TabIndex = 21;
      this.txtSetWeight.TextAlign = HorizontalAlignment.Right;
      this.lblSetWeight.AutoSize = true;
      Label lblSetWeight1 = this.lblSetWeight;
      point1 = new Point(233, 48);
      Point point48 = point1;
      lblSetWeight1.Location = point48;
      this.lblSetWeight.Name = "lblSetWeight";
      Label lblSetWeight2 = this.lblSetWeight;
      size1 = new Size(44, 13);
      Size size48 = size1;
      lblSetWeight2.Size = size48;
      this.lblSetWeight.TabIndex = 0;
      this.lblSetWeight.Text = "Weight:";
      Button cmdGenerar1 = this.cmdGenerar;
      point1 = new Point(1100, 272);
      Point point49 = point1;
      cmdGenerar1.Location = point49;
      this.cmdGenerar.Name = "cmdGenerar";
      Button cmdGenerar2 = this.cmdGenerar;
      size1 = new Size(472, 52);
      Size size49 = size1;
      cmdGenerar2.Size = size49;
      this.cmdGenerar.TabIndex = 100;
      this.cmdGenerar.Text = "Generate >> \"C:\\...\\ws_manual_20130130.fit\"";
      this.cmdGenerar.UseVisualStyleBackColor = true;
      this.fraFitBit.Controls.Add((Control) this.cmdAutorizarFitBit);
      this.fraFitBit.Controls.Add((Control) this.rtbFitBit);
      GroupBox fraFitBit1 = this.fraFitBit;
      point1 = new Point(1100, 59);
      Point point50 = point1;
      fraFitBit1.Location = point50;
      this.fraFitBit.Name = "fraFitBit";
      GroupBox fraFitBit2 = this.fraFitBit;
      size1 = new Size(473, 205);
      Size size50 = size1;
      fraFitBit2.Size = size50;
      this.fraFitBit.TabIndex = 201;
      this.fraFitBit.TabStop = false;
      this.fraFitBit.Text = "Configuration";
      Button cmdAutorizarFitBit1 = this.cmdAutorizarFitBit;
      point1 = new Point(172, 173);
      Point point51 = point1;
      cmdAutorizarFitBit1.Location = point51;
      this.cmdAutorizarFitBit.Name = "cmdAutorizarFitBit";
      Button cmdAutorizarFitBit2 = this.cmdAutorizarFitBit;
      size1 = new Size(151, 25);
      Size size51 = size1;
      cmdAutorizarFitBit2.Size = size51;
      this.cmdAutorizarFitBit.TabIndex = 31;
      this.cmdAutorizarFitBit.Text = "Allow Access";
      this.cmdAutorizarFitBit.UseVisualStyleBackColor = true;
      this.rtbFitBit.BorderStyle = BorderStyle.None;
      RichTextBox rtbFitBit1 = this.rtbFitBit;
      point1 = new Point(42, 30);
      Point point52 = point1;
      rtbFitBit1.Location = point52;
      this.rtbFitBit.Name = "rtbFitBit";
      this.rtbFitBit.ReadOnly = true;
      this.rtbFitBit.ScrollBars = RichTextBoxScrollBars.None;
      RichTextBox rtbFitBit2 = this.rtbFitBit;
      size1 = new Size(405, 133);
      Size size52 = size1;
      rtbFitBit2.Size = size52;
      this.rtbFitBit.TabIndex = 30;
      this.rtbFitBit.TabStop = false;
      this.rtbFitBit.Text = componentResourceManager.GetString("rtbFitBit.Text");
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.RadioButton5);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.RadioButton4);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.RadioButton3);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.RadioButton2);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.RadioButton1);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.lblWhatMeasure);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.chkLstBoxFechas);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.txtPerfil);
      this.fraExportarMedidasAutomaticas.Controls.Add((Control) this.lblUrsConectado);
      GroupBox medidasAutomaticas1 = this.fraExportarMedidasAutomaticas;
      point1 = new Point(1100, 59);
      Point point53 = point1;
      medidasAutomaticas1.Location = point53;
      this.fraExportarMedidasAutomaticas.Name = "fraExportarMedidasAutomaticas";
      GroupBox medidasAutomaticas2 = this.fraExportarMedidasAutomaticas;
      size1 = new Size(473, 205);
      Size size53 = size1;
      medidasAutomaticas2.Size = size53;
      this.fraExportarMedidasAutomaticas.TabIndex = 202;
      this.fraExportarMedidasAutomaticas.TabStop = false;
      this.RadioButton5.AutoSize = true;
      RadioButton radioButton5_1 = this.RadioButton5;
      point1 = new Point(350, 175);
      Point point54 = point1;
      radioButton5_1.Location = point54;
      this.RadioButton5.Name = "RadioButton5";
      RadioButton radioButton5_2 = this.RadioButton5;
      size1 = new Size(83, 17);
      Size size54 = size1;
      radioButton5_2.Size = size54;
      this.RadioButton5.TabIndex = 8;
      this.RadioButton5.Text = "Uncheck All";
      this.RadioButton5.UseVisualStyleBackColor = true;
      this.RadioButton4.AutoSize = true;
      this.RadioButton4.Checked = true;
      RadioButton radioButton4_1 = this.RadioButton4;
      point1 = new Point(350, 152);
      Point point55 = point1;
      radioButton4_1.Location = point55;
      this.RadioButton4.Name = "RadioButton4";
      RadioButton radioButton4_2 = this.RadioButton4;
      size1 = new Size(70, 17);
      Size size55 = size1;
      radioButton4_2.Size = size55;
      this.RadioButton4.TabIndex = 7;
      this.RadioButton4.TabStop = true;
      this.RadioButton4.Text = "Check All";
      this.RadioButton4.UseVisualStyleBackColor = true;
      this.RadioButton3.AutoSize = true;
      RadioButton radioButton3_1 = this.RadioButton3;
      point1 = new Point(350, 129);
      Point point56 = point1;
      radioButton3_1.Location = point56;
      this.RadioButton3.Name = "RadioButton3";
      RadioButton radioButton3_2 = this.RadioButton3;
      size1 = new Size(91, 17);
      Size size56 = size1;
      radioButton3_2.Size = size56;
      this.RadioButton3.TabIndex = 6;
      this.RadioButton3.Text = "Current Week";
      this.RadioButton3.UseVisualStyleBackColor = true;
      this.RadioButton2.AutoSize = true;
      RadioButton radioButton2_1 = this.RadioButton2;
      point1 = new Point(350, 106);
      Point point57 = point1;
      radioButton2_1.Location = point57;
      this.RadioButton2.Name = "RadioButton2";
      RadioButton radioButton2_2 = this.RadioButton2;
      size1 = new Size(92, 17);
      Size size57 = size1;
      radioButton2_2.Size = size57;
      this.RadioButton2.TabIndex = 5;
      this.RadioButton2.Text = "Current Month";
      this.RadioButton2.UseVisualStyleBackColor = true;
      this.RadioButton1.AutoSize = true;
      RadioButton radioButton1_1 = this.RadioButton1;
      point1 = new Point(350, 83);
      Point point58 = point1;
      radioButton1_1.Location = point58;
      this.RadioButton1.Name = "RadioButton1";
      RadioButton radioButton1_2 = this.RadioButton1;
      size1 = new Size(84, 17);
      Size size58 = size1;
      radioButton1_2.Size = size58;
      this.RadioButton1.TabIndex = 4;
      this.RadioButton1.Text = "Current Year";
      this.RadioButton1.UseVisualStyleBackColor = true;
      this.lblWhatMeasure.AutoSize = true;
      Label lblWhatMeasure1 = this.lblWhatMeasure;
      point1 = new Point(13, 61);
      Point point59 = point1;
      lblWhatMeasure1.Location = point59;
      this.lblWhatMeasure.Name = "lblWhatMeasure";
      Label lblWhatMeasure2 = this.lblWhatMeasure;
      size1 = new Size(129, 13);
      Size size59 = size1;
      lblWhatMeasure2.Size = size59;
      this.lblWhatMeasure.TabIndex = 3;
      this.lblWhatMeasure.Text = "What you want to export?";
      this.chkLstBoxFechas.FormattingEnabled = true;
      CheckedListBox chkLstBoxFechas1 = this.chkLstBoxFechas;
      point1 = new Point(26, 83);
      Point point60 = point1;
      chkLstBoxFechas1.Location = point60;
      this.chkLstBoxFechas.Name = "chkLstBoxFechas";
      CheckedListBox chkLstBoxFechas2 = this.chkLstBoxFechas;
      size1 = new Size(318, 109);
      Size size60 = size1;
      chkLstBoxFechas2.Size = size60;
      this.chkLstBoxFechas.TabIndex = 2;
      this.txtPerfil.Enabled = false;
      TextBox txtPerfil1 = this.txtPerfil;
      point1 = new Point(26, 33);
      Point point61 = point1;
      txtPerfil1.Location = point61;
      this.txtPerfil.Name = "txtPerfil";
      TextBox txtPerfil2 = this.txtPerfil;
      size1 = new Size(414, 20);
      Size size61 = size1;
      txtPerfil2.Size = size61;
      this.txtPerfil.TabIndex = 1;
      this.txtPerfil.TextAlign = HorizontalAlignment.Center;
      this.lblUrsConectado.AutoSize = true;
      Label lblUrsConectado1 = this.lblUrsConectado;
      point1 = new Point(13, 17);
      Point point62 = point1;
      lblUrsConectado1.Location = point62;
      this.lblUrsConectado.Name = "lblUrsConectado";
      Label lblUrsConectado2 = this.lblUrsConectado;
      size1 = new Size(39, 13);
      Size size62 = size1;
      lblUrsConectado2.Size = size62;
      this.lblUrsConectado.TabIndex = 0;
      this.lblUrsConectado.Text = "Profile:";
      this.frawithings.Controls.Add((Control) this.cmdEnlazarWithings);
      this.frawithings.Controls.Add((Control) this.txtClavePublica);
      this.frawithings.Controls.Add((Control) this.txtIdUsuario);
      this.frawithings.Controls.Add((Control) this.lblPublicKey);
      this.frawithings.Controls.Add((Control) this.lblUsrID);
      GroupBox frawithings1 = this.frawithings;
      point1 = new Point(1100, 59);
      Point point63 = point1;
      frawithings1.Location = point63;
      this.frawithings.Name = "frawithings";
      GroupBox frawithings2 = this.frawithings;
      size1 = new Size(473, 205);
      Size size63 = size1;
      frawithings2.Size = size63;
      this.frawithings.TabIndex = 203;
      this.frawithings.TabStop = false;
      this.frawithings.Text = "Configuration";
      Button cmdEnlazarWithings1 = this.cmdEnlazarWithings;
      point1 = new Point(268, 126);
      Point point64 = point1;
      cmdEnlazarWithings1.Location = point64;
      this.cmdEnlazarWithings.Name = "cmdEnlazarWithings";
      Button cmdEnlazarWithings2 = this.cmdEnlazarWithings;
      size1 = new Size(105, 21);
      Size size64 = size1;
      cmdEnlazarWithings2.Size = size64;
      this.cmdEnlazarWithings.TabIndex = 4;
      this.cmdEnlazarWithings.Text = "Link";
      this.cmdEnlazarWithings.UseVisualStyleBackColor = true;
      TextBox txtClavePublica1 = this.txtClavePublica;
      point1 = new Point(166, 101);
      Point point65 = point1;
      txtClavePublica1.Location = point65;
      this.txtClavePublica.Name = "txtClavePublica";
      TextBox txtClavePublica2 = this.txtClavePublica;
      size1 = new Size(207, 20);
      Size size65 = size1;
      txtClavePublica2.Size = size65;
      this.txtClavePublica.TabIndex = 3;
      TextBox txtIdUsuario1 = this.txtIdUsuario;
      point1 = new Point(166, 74);
      Point point66 = point1;
      txtIdUsuario1.Location = point66;
      this.txtIdUsuario.Name = "txtIdUsuario";
      TextBox txtIdUsuario2 = this.txtIdUsuario;
      size1 = new Size(207, 20);
      Size size66 = size1;
      txtIdUsuario2.Size = size66;
      this.txtIdUsuario.TabIndex = 2;
      this.lblPublicKey.AutoSize = true;
      Label lblPublicKey1 = this.lblPublicKey;
      point1 = new Point(88, 105);
      Point point67 = point1;
      lblPublicKey1.Location = point67;
      this.lblPublicKey.Name = "lblPublicKey";
      Label lblPublicKey2 = this.lblPublicKey;
      size1 = new Size(59, 13);
      Size size67 = size1;
      lblPublicKey2.Size = size67;
      this.lblPublicKey.TabIndex = 1;
      this.lblPublicKey.Text = "Public key:";
      this.lblUsrID.AutoSize = true;
      Label lblUsrId1 = this.lblUsrID;
      point1 = new Point(88, 77);
      Point point68 = point1;
      lblUsrId1.Location = point68;
      this.lblUsrID.Name = "lblUsrID";
      Label lblUsrId2 = this.lblUsrID;
      size1 = new Size(44, 13);
      Size size68 = size1;
      lblUsrId2.Size = size68;
      this.lblUsrID.TabIndex = 0;
      this.lblUsrID.Text = "User Id:";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(496, 373);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.frawithings);
      this.Controls.Add((Control) this.fraExportarMedidasAutomaticas);
      this.Controls.Add((Control) this.fraFitBit);
      this.Controls.Add((Control) this.cmdGenerar);
      this.Controls.Add((Control) this.fraExportarMedidas);
      this.Controls.Add((Control) this.panFoot);
      this.Controls.Add((Control) this.panHeader);
      this.Controls.Add((Control) this.fraConfiguracionManual);
      this.Controls.Add((Control) this.fraFicheroExportacion);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.Name = nameof (scale2fit);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (scale2fit);
      this.fraFicheroExportacion.ResumeLayout(false);
      this.fraFicheroExportacion.PerformLayout();
      this.fraConfiguracionManual.ResumeLayout(false);
      this.fraConfiguracionManual.PerformLayout();
      this.panHeader.ResumeLayout(false);
      this.panHeader.PerformLayout();
      this.panFoot.ResumeLayout(false);
      this.panFoot.PerformLayout();
      ((ISupportInitialize) this.pctBoxPaypal).EndInit();
      this.fraExportarMedidas.ResumeLayout(false);
      this.fraExportarMedidas.PerformLayout();
      this.fraFitBit.ResumeLayout(false);
      this.fraExportarMedidasAutomaticas.ResumeLayout(false);
      this.fraExportarMedidasAutomaticas.PerformLayout();
      this.frawithings.ResumeLayout(false);
      this.frawithings.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual ComboBox cboTipoGeneracion
    {
      get => this._cboTipoGeneracion;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cboTipoGeneracion_SelectedIndexChanged);
        if (this._cboTipoGeneracion != null)
          this._cboTipoGeneracion.SelectedIndexChanged -= eventHandler;
        this._cboTipoGeneracion = value;
        if (this._cboTipoGeneracion == null)
          return;
        this._cboTipoGeneracion.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox fraFicheroExportacion
    {
      get => this._fraFicheroExportacion;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fraFicheroExportacion = value;
    }

    internal virtual TextBox txtRuta
    {
      get => this._txtRuta;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRuta = value;
    }

    internal virtual GroupBox fraConfiguracionManual
    {
      get => this._fraConfiguracionManual;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fraConfiguracionManual = value;
    }

    internal virtual CheckedListBox chkListMedidas
    {
      get => this._chkListMedidas;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ItemCheckEventHandler checkEventHandler = new ItemCheckEventHandler(this.chkListMedidas_ItemCheck);
        if (this._chkListMedidas != null)
          this._chkListMedidas.ItemCheck -= checkEventHandler;
        this._chkListMedidas = value;
        if (this._chkListMedidas == null)
          return;
        this._chkListMedidas.ItemCheck += checkEventHandler;
      }
    }

    internal virtual Label lblMedidas
    {
      get => this._lblMedidas;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMedidas = value;
    }

    internal virtual CheckBox chkFechaActual
    {
      get => this._chkFechaActual;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkFechaActual_CheckedChanged);
        if (this._chkFechaActual != null)
          this._chkFechaActual.CheckedChanged -= eventHandler;
        this._chkFechaActual = value;
        if (this._chkFechaActual == null)
          return;
        this._chkFechaActual.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button cmdExportarRuta
    {
      get => this._cmdExportarRuta;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdExportarRuta_Click);
        if (this._cmdExportarRuta != null)
          this._cmdExportarRuta.Click -= eventHandler;
        this._cmdExportarRuta = value;
        if (this._cmdExportarRuta == null)
          return;
        this._cmdExportarRuta.Click += eventHandler;
      }
    }

    internal virtual Panel panHeader
    {
      get => this._panHeader;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._panHeader = value;
    }

    internal virtual Label lblTipoGeneracion
    {
      get => this._lblTipoGeneracion;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTipoGeneracion = value;
    }

    internal virtual Button cmdConfigurar
    {
      get => this._cmdConfigurar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdTipoGenerar_Click);
        if (this._cmdConfigurar != null)
          this._cmdConfigurar.Click -= eventHandler;
        this._cmdConfigurar = value;
        if (this._cmdConfigurar == null)
          return;
        this._cmdConfigurar.Click += eventHandler;
      }
    }

    internal virtual Panel panFoot
    {
      get => this._panFoot;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._panFoot = value;
    }

    internal virtual Label lblCopyright
    {
      get => this._lblCopyright;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblCopyright = value;
    }

    internal virtual LinkLabel linkWEB
    {
      get => this._linkWEB;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkWEB_LinkClicked);
        if (this._linkWEB != null)
          this._linkWEB.LinkClicked -= clickedEventHandler;
        this._linkWEB = value;
        if (this._linkWEB == null)
          return;
        this._linkWEB.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual GroupBox fraExportarMedidas
    {
      get => this._fraExportarMedidas;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fraExportarMedidas = value;
    }

    internal virtual Label lblSetMetabolicAge
    {
      get => this._lblSetMetabolicAge;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetMetabolicAge = value;
    }

    internal virtual Label lblSetBoneMass
    {
      get => this._lblSetBoneMass;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetBoneMass = value;
    }

    internal virtual Label lblSetVisceralFatRating
    {
      get => this._lblSetVisceralFatRating;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetVisceralFatRating = value;
    }

    internal virtual Label lblSetPercentHydration
    {
      get => this._lblSetPercentHydration;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetPercentHydration = value;
    }

    internal virtual Label lblSetPhysiqueRating
    {
      get => this._lblSetPhysiqueRating;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetPhysiqueRating = value;
    }

    internal virtual Label lblSetPercentFat
    {
      get => this._lblSetPercentFat;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetPercentFat = value;
    }

    internal virtual Label lblSetMuscleMass
    {
      get => this._lblSetMuscleMass;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetMuscleMass = value;
    }

    internal virtual TextBox txtSetMetabolicAge
    {
      get => this._txtSetMetabolicAge;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Enteros_Validated);
        EventHandler eventHandler2 = new EventHandler(this.Medidas_TextChanged);
        if (this._txtSetMetabolicAge != null)
        {
          this._txtSetMetabolicAge.Validated -= eventHandler1;
          this._txtSetMetabolicAge.TextChanged -= eventHandler2;
        }
        this._txtSetMetabolicAge = value;
        if (this._txtSetMetabolicAge == null)
          return;
        this._txtSetMetabolicAge.Validated += eventHandler1;
        this._txtSetMetabolicAge.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtSetBoneMass
    {
      get => this._txtSetBoneMass;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Medidas_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.Decimales_Validated);
        if (this._txtSetBoneMass != null)
        {
          this._txtSetBoneMass.TextChanged -= eventHandler1;
          this._txtSetBoneMass.Validated -= eventHandler2;
        }
        this._txtSetBoneMass = value;
        if (this._txtSetBoneMass == null)
          return;
        this._txtSetBoneMass.TextChanged += eventHandler1;
        this._txtSetBoneMass.Validated += eventHandler2;
      }
    }

    internal virtual TextBox txtSetVisceralFatRating
    {
      get => this._txtSetVisceralFatRating;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Enteros_Validated);
        EventHandler eventHandler2 = new EventHandler(this.Medidas_TextChanged);
        if (this._txtSetVisceralFatRating != null)
        {
          this._txtSetVisceralFatRating.Validated -= eventHandler1;
          this._txtSetVisceralFatRating.TextChanged -= eventHandler2;
        }
        this._txtSetVisceralFatRating = value;
        if (this._txtSetVisceralFatRating == null)
          return;
        this._txtSetVisceralFatRating.Validated += eventHandler1;
        this._txtSetVisceralFatRating.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtSetPercentHydration
    {
      get => this._txtSetPercentHydration;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Medidas_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.Decimales_Validated);
        if (this._txtSetPercentHydration != null)
        {
          this._txtSetPercentHydration.TextChanged -= eventHandler1;
          this._txtSetPercentHydration.Validated -= eventHandler2;
        }
        this._txtSetPercentHydration = value;
        if (this._txtSetPercentHydration == null)
          return;
        this._txtSetPercentHydration.TextChanged += eventHandler1;
        this._txtSetPercentHydration.Validated += eventHandler2;
      }
    }

    internal virtual TextBox txtSetPhysiqueRating
    {
      get => this._txtSetPhysiqueRating;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Enteros_Validated);
        EventHandler eventHandler2 = new EventHandler(this.Medidas_TextChanged);
        if (this._txtSetPhysiqueRating != null)
        {
          this._txtSetPhysiqueRating.Validated -= eventHandler1;
          this._txtSetPhysiqueRating.TextChanged -= eventHandler2;
        }
        this._txtSetPhysiqueRating = value;
        if (this._txtSetPhysiqueRating == null)
          return;
        this._txtSetPhysiqueRating.Validated += eventHandler1;
        this._txtSetPhysiqueRating.TextChanged += eventHandler2;
      }
    }

    internal virtual TextBox txtSetPercentFat
    {
      get => this._txtSetPercentFat;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Medidas_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.Decimales_Validated);
        if (this._txtSetPercentFat != null)
        {
          this._txtSetPercentFat.TextChanged -= eventHandler1;
          this._txtSetPercentFat.Validated -= eventHandler2;
        }
        this._txtSetPercentFat = value;
        if (this._txtSetPercentFat == null)
          return;
        this._txtSetPercentFat.TextChanged += eventHandler1;
        this._txtSetPercentFat.Validated += eventHandler2;
      }
    }

    internal virtual TextBox txtSetMuscleMass
    {
      get => this._txtSetMuscleMass;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Medidas_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.Decimales_Validated);
        if (this._txtSetMuscleMass != null)
        {
          this._txtSetMuscleMass.TextChanged -= eventHandler1;
          this._txtSetMuscleMass.Validated -= eventHandler2;
        }
        this._txtSetMuscleMass = value;
        if (this._txtSetMuscleMass == null)
          return;
        this._txtSetMuscleMass.TextChanged += eventHandler1;
        this._txtSetMuscleMass.Validated += eventHandler2;
      }
    }

    internal virtual TextBox txtSetWeight
    {
      get => this._txtSetWeight;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Medidas_TextChanged);
        EventHandler eventHandler2 = new EventHandler(this.Decimales_Validated);
        if (this._txtSetWeight != null)
        {
          this._txtSetWeight.TextChanged -= eventHandler1;
          this._txtSetWeight.Validated -= eventHandler2;
        }
        this._txtSetWeight = value;
        if (this._txtSetWeight == null)
          return;
        this._txtSetWeight.TextChanged += eventHandler1;
        this._txtSetWeight.Validated += eventHandler2;
      }
    }

    internal virtual Label lblSetWeight
    {
      get => this._lblSetWeight;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetWeight = value;
    }

    internal virtual Button cmdGenerar
    {
      get => this._cmdGenerar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdGenerar_Click);
        if (this._cmdGenerar != null)
          this._cmdGenerar.Click -= eventHandler;
        this._cmdGenerar = value;
        if (this._cmdGenerar == null)
          return;
        this._cmdGenerar.Click += eventHandler;
      }
    }

    internal virtual CheckBox chkUltimasMedidas
    {
      get => this._chkUltimasMedidas;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkUltimasMedidas_CheckedChanged);
        if (this._chkUltimasMedidas != null)
          this._chkUltimasMedidas.CheckedChanged -= eventHandler;
        this._chkUltimasMedidas = value;
        if (this._chkUltimasMedidas == null)
          return;
        this._chkUltimasMedidas.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label lbl2SetBoneMass
    {
      get => this._lbl2SetBoneMass;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetBoneMass = value;
    }

    internal virtual Label lbl2SetPercentHydration
    {
      get => this._lbl2SetPercentHydration;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetPercentHydration = value;
    }

    internal virtual Label lbl2SetPercentFat
    {
      get => this._lbl2SetPercentFat;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetPercentFat = value;
    }

    internal virtual Label lbl2SetWeight
    {
      get => this._lbl2SetWeight;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetWeight = value;
    }

    internal virtual Label lblSetActiveMet
    {
      get => this._lblSetActiveMet;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSetActiveMet = value;
    }

    internal virtual TextBox txtSetActiveMet
    {
      get => this._txtSetActiveMet;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler1 = new EventHandler(this.Enteros_Validated);
        EventHandler eventHandler2 = new EventHandler(this.Medidas_TextChanged);
        if (this._txtSetActiveMet != null)
        {
          this._txtSetActiveMet.Validated -= eventHandler1;
          this._txtSetActiveMet.TextChanged -= eventHandler2;
        }
        this._txtSetActiveMet = value;
        if (this._txtSetActiveMet == null)
          return;
        this._txtSetActiveMet.Validated += eventHandler1;
        this._txtSetActiveMet.TextChanged += eventHandler2;
      }
    }

    internal virtual Label lblFechaActual
    {
      get => this._lblFechaActual;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblFechaActual = value;
    }

    internal virtual Label lbl2SetMetabolicAge
    {
      get => this._lbl2SetMetabolicAge;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetMetabolicAge = value;
    }

    internal virtual Label lbl2SetMuscleMass
    {
      get => this._lbl2SetMuscleMass;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetMuscleMass = value;
    }

    internal virtual Label lbl2SetActiveMet
    {
      get => this._lbl2SetActiveMet;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lbl2SetActiveMet = value;
    }

    internal virtual MaskedTextBox txtFechaActual
    {
      get => this._txtFechaActual;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtFechaActual_Validating);
        EventHandler eventHandler1 = new EventHandler(this.txtFechaActual_GotFocus);
        EventHandler eventHandler2 = new EventHandler(this.txtFechaActual_LostFocus);
        if (this._txtFechaActual != null)
        {
          this._txtFechaActual.Validating -= cancelEventHandler;
          this._txtFechaActual.GotFocus -= eventHandler1;
          this._txtFechaActual.LostFocus -= eventHandler2;
        }
        this._txtFechaActual = value;
        if (this._txtFechaActual == null)
          return;
        this._txtFechaActual.Validating += cancelEventHandler;
        this._txtFechaActual.GotFocus += eventHandler1;
        this._txtFechaActual.LostFocus += eventHandler2;
      }
    }

    internal virtual GroupBox fraFitBit
    {
      get => this._fraFitBit;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fraFitBit = value;
    }

    internal virtual Button cmdAutorizarFitBit
    {
      get => this._cmdAutorizarFitBit;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdAutorizarFitBit_Click);
        if (this._cmdAutorizarFitBit != null)
          this._cmdAutorizarFitBit.Click -= eventHandler;
        this._cmdAutorizarFitBit = value;
        if (this._cmdAutorizarFitBit == null)
          return;
        this._cmdAutorizarFitBit.Click += eventHandler;
      }
    }

    internal virtual RichTextBox rtbFitBit
    {
      get => this._rtbFitBit;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._rtbFitBit = value;
    }

    internal virtual GroupBox fraExportarMedidasAutomaticas
    {
      get => this._fraExportarMedidasAutomaticas;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._fraExportarMedidasAutomaticas = value;
    }

    internal virtual TextBox txtPerfil
    {
      get => this._txtPerfil;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPerfil = value;
    }

    internal virtual Label lblUrsConectado
    {
      get => this._lblUrsConectado;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblUrsConectado = value;
    }

    internal virtual Button cmdExportar
    {
      get => this._cmdExportar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdTipoGenerar_Click);
        if (this._cmdExportar != null)
          this._cmdExportar.Click -= eventHandler;
        this._cmdExportar = value;
        if (this._cmdExportar == null)
          return;
        this._cmdExportar.Click += eventHandler;
      }
    }

    internal virtual GroupBox frawithings
    {
      get => this._frawithings;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._frawithings = value;
    }

    internal virtual Button cmdEnlazarWithings
    {
      get => this._cmdEnlazarWithings;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.cmdEnlazarWithings_Click);
        if (this._cmdEnlazarWithings != null)
          this._cmdEnlazarWithings.Click -= eventHandler;
        this._cmdEnlazarWithings = value;
        if (this._cmdEnlazarWithings == null)
          return;
        this._cmdEnlazarWithings.Click += eventHandler;
      }
    }

    internal virtual TextBox txtClavePublica
    {
      get => this._txtClavePublica;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtClavePublica = value;
    }

    internal virtual TextBox txtIdUsuario
    {
      get => this._txtIdUsuario;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtIdUsuario = value;
    }

    internal virtual Label lblPublicKey
    {
      get => this._lblPublicKey;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblPublicKey = value;
    }

    internal virtual Label lblUsrID
    {
      get => this._lblUsrID;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblUsrID = value;
    }

    internal virtual RadioButton RadioButton2
    {
      get => this._RadioButton2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_CheckedChanged);
        if (this._RadioButton2 != null)
          this._RadioButton2.CheckedChanged -= eventHandler;
        this._RadioButton2 = value;
        if (this._RadioButton2 == null)
          return;
        this._RadioButton2.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton1
    {
      get => this._RadioButton1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_CheckedChanged);
        if (this._RadioButton1 != null)
          this._RadioButton1.CheckedChanged -= eventHandler;
        this._RadioButton1 = value;
        if (this._RadioButton1 == null)
          return;
        this._RadioButton1.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label lblWhatMeasure
    {
      get => this._lblWhatMeasure;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblWhatMeasure = value;
    }

    internal virtual CheckedListBox chkLstBoxFechas
    {
      get => this._chkLstBoxFechas;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._chkLstBoxFechas = value;
    }

    internal virtual RadioButton RadioButton5
    {
      get => this._RadioButton5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_CheckedChanged);
        if (this._RadioButton5 != null)
          this._RadioButton5.CheckedChanged -= eventHandler;
        this._RadioButton5 = value;
        if (this._RadioButton5 == null)
          return;
        this._RadioButton5.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton4
    {
      get => this._RadioButton4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_CheckedChanged);
        if (this._RadioButton4 != null)
          this._RadioButton4.CheckedChanged -= eventHandler;
        this._RadioButton4 = value;
        if (this._RadioButton4 == null)
          return;
        this._RadioButton4.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton RadioButton3
    {
      get => this._RadioButton3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RadioButton_CheckedChanged);
        if (this._RadioButton3 != null)
          this._RadioButton3.CheckedChanged -= eventHandler;
        this._RadioButton3 = value;
        if (this._RadioButton3 == null)
          return;
        this._RadioButton3.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox chkKGLB
    {
      get => this._chkKGLB;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.chkKGLB_CheckedChanged);
        if (this._chkKGLB != null)
          this._chkKGLB.CheckedChanged -= eventHandler;
        this._chkKGLB = value;
        if (this._chkKGLB == null)
          return;
        this._chkKGLB.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox pctBoxPaypal
    {
      get => this._pctBoxPaypal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.pctBoxPaypal_Click);
        if (this._pctBoxPaypal != null)
          this._pctBoxPaypal.Click -= eventHandler;
        this._pctBoxPaypal = value;
        if (this._pctBoxPaypal == null)
          return;
        this._pctBoxPaypal.Click += eventHandler;
      }
    }

    internal virtual Button cmdUpload
    {
      get => this._cmdUpload;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnUpload_Click);
        if (this._cmdUpload != null)
          this._cmdUpload.Click -= eventHandler;
        this._cmdUpload = value;
        if (this._cmdUpload == null)
          return;
        this._cmdUpload.Click += eventHandler;
      }
    }

    private scale2fit.StatusResponseEnum ReadStatus(string response) => (scale2fit.StatusResponseEnum) checked ((int) long.Parse(((JValue) JObject.Parse(response).SelectToken("status")).Value.ToString(), (IFormatProvider) CultureInfo.CurrentCulture));

    private string ReadUsr(string response)
    {
      XmlDocument xmlDocument = JsonConvert.DeserializeXmlNode(response, "root");
      return xmlDocument.SelectSingleNode("//root/body/users/firstname").InnerText.ToString() + " " + xmlDocument.SelectSingleNode("//root/body/users/lastname").InnerText.ToString();
    }

    private System.DateTime EPOCHToDateTime(int value) => new System.DateTime(1970, 1, 1, 0, 0, 0).AddSeconds((double) value);

    private int DateTimeToEPOCH(System.DateTime value) => checked ((int) Math.Round(value.Subtract(new System.DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds));

    private bool damePerfil(int tipoPerfil)
    {
      bool flag = false;
      try
      {
        XmlDocument xmlDocument1 = new XmlDocument();
        xmlDocument1.Load(this.xmlConfigFile);
        switch (tipoPerfil)
        {
          case 1:
            string accessToken = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena1").InnerText.ToString());
            string accessTokenSecret = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena2").InnerText.ToString());
            string str1 = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena3").InnerText.ToString());
            RestClient restClient = new RestClient("https://api.fitbit.com/");
            restClient.Authenticator = (IAuthenticator) OAuth1Authenticator.ForProtectedResource("75f47db3edf34217bbf75aa1f07e04b0", "3ed25705358c4f0f886adefc742e0c31", accessToken, accessTokenSecret);
            RestRequest restRequest1 = new RestRequest("oauth/request_token");
            IRestResponse restResponse1 = restClient.Execute((IRestRequest) restRequest1);
            if (!Information.IsNothing((object) restResponse1))
            {
              if (HttpStatusCode.OK == restResponse1.StatusCode)
              {
                RestRequest restRequest2 = new RestRequest(string.Format("/1/user/{0}/profile.xml", (object) str1));
                IRestResponse restResponse2 = restClient.Execute((IRestRequest) restRequest2);
                if (!Information.IsNothing((object) restResponse2))
                {
                  if (HttpStatusCode.OK == restResponse2.StatusCode)
                  {
                    XmlDocument xmlDocument2 = new XmlDocument();
                    string xml = restResponse2.Content.ToString().Replace("Logged In", "logged");
                    xmlDocument2.LoadXml(xml);
                    string str2 = xmlDocument2.SelectSingleNode("//result/user/fullName").InnerText.ToString();
                    Conversions.ToString(Conversions.ToDate(xmlDocument2.SelectSingleNode("//result/user/memberSince").InnerText));
                    this.txtPerfil.Text = str2;
                    this.cargaFechas();
                    flag = true;
                    break;
                  }
                  break;
                }
                break;
              }
              break;
            }
            break;
          case 2:
            Uri requestUri = new Uri(string.Format("http://wbsapi.withings.net/user?action=getbyuserid&userid={0}&publickey={1}", (object) Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/withings/txtCadena1").InnerText.ToString()), (object) Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/withings/txtCadena2").InnerText.ToString())));
            Stream stream = (Stream) null;
            StreamReader streamReader = (StreamReader) null;
            string response = (string) null;
            try
            {
              stream = WebRequest.Create(requestUri).GetResponse().GetResponseStream();
              streamReader = new StreamReader(stream);
              response = streamReader.ReadToEnd();
            }
            catch (NotSupportedException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
            catch (OutOfMemoryException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
            catch (IOException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              response = string.Empty;
              ProjectData.ClearProjectError();
            }
            finally
            {
              if (streamReader != null)
              {
                streamReader.Close();
                streamReader.Dispose();
              }
              if (stream != null)
              {
                stream.Close();
                stream.Dispose();
              }
            }
            if (!Information.IsNothing((object) response))
            {
              scale2fit.StatusResponseEnum statusResponseEnum = new scale2fit.StatusResponseEnum();
              if (this.ReadStatus(response) == scale2fit.StatusResponseEnum.Successfull)
              {
                this.txtPerfil.Text = this.ReadUsr(response);
                this.cargaFechas();
                flag = true;
                break;
              }
              break;
            }
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    private void presentacionPantalla(ref int intAccion)
    {
      this.fraConfiguracionManual.Left = 1100;
      this.fraConfiguracionManual.Enabled = false;
      this.fraExportarMedidas.Left = 1100;
      this.fraExportarMedidas.Enabled = false;
      this.fraFicheroExportacion.Left = 1100;
      this.fraFicheroExportacion.Enabled = false;
      this.fraFitBit.Left = 1100;
      this.fraFitBit.Enabled = false;
      this.fraExportarMedidasAutomaticas.Left = 1100;
      this.fraExportarMedidasAutomaticas.Enabled = false;
      this.frawithings.Left = 1100;
      this.frawithings.Enabled = false;
      this.cmdGenerar.Left = 1100;
      this.cmdGenerar.Enabled = false;
      switch (this.intTipoGeneracion)
      {
        case 0:
          if (intAccion == 1)
          {
            this.fraConfiguracionManual.Left = 11;
            this.fraConfiguracionManual.Enabled = true;
            this.fraFicheroExportacion.Left = 11;
            this.fraFicheroExportacion.Enabled = true;
            break;
          }
          this.fraExportarMedidas.Left = 11;
          this.fraExportarMedidas.Enabled = true;
          this.cmdGenerar.Left = 11;
          this.cmdGenerar.Enabled = true;
          break;
        case 1:
        case 2:
          XmlDocument xmlDocument = new XmlDocument();
          xmlDocument.Load(this.xmlConfigFile);
          if (this.intTipoGeneracion == 1)
          {
            if (Operators.CompareString(xmlDocument.SelectSingleNode("//configuracion/fitbit/txtCadena1").InnerText.ToString(), string.Empty, false) == 0)
              intAccion = 1;
          }
          else if (Operators.CompareString(xmlDocument.SelectSingleNode("//configuracion/withings/txtCadena1").InnerText.ToString(), string.Empty, false) == 0)
            intAccion = 1;
          if (intAccion == 1)
          {
            if (this.intTipoGeneracion == 1)
            {
              this.fraFitBit.Left = 11;
              this.fraFitBit.Enabled = true;
            }
            else
            {
              this.frawithings.Left = 11;
              this.frawithings.Enabled = true;
            }
            this.fraFicheroExportacion.Left = 11;
            this.fraFicheroExportacion.Enabled = true;
            this.fraExportarMedidasAutomaticas.Enabled = false;
            this.fraExportarMedidasAutomaticas.Left = 1100;
            break;
          }
          this.cmdGenerar.Left = 11;
          this.fraExportarMedidasAutomaticas.Enabled = true;
          this.fraExportarMedidasAutomaticas.Left = 11;
          if (this.damePerfil(this.intTipoGeneracion))
          {
            this.cmdGenerar.Enabled = true;
            break;
          }
          int intAccion1 = 1;
          this.presentacionPantalla(ref intAccion1);
          break;
      }
    }

    private void proponerUltimasMedidas(bool blnPropuesta)
    {
      try
      {
        if (blnPropuesta)
        {
          XmlDocument xmlDocument = new XmlDocument();
          xmlDocument.Load(this.xmlConfigFile);
          this.txtSetWeight.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetWeight").InnerText.ToString();
          this.txtSetPercentFat.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetPercentFat").InnerText.ToString();
          this.txtSetPercentHydration.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetPercentHydration").InnerText.ToString();
          this.txtSetBoneMass.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetBoneMass").InnerText.ToString();
          this.txtSetMuscleMass.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetMuscleMass").InnerText.ToString();
          this.txtSetPhysiqueRating.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetPhysiqueRating").InnerText.ToString();
          this.txtSetVisceralFatRating.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetVisceralFatRating").InnerText.ToString();
          this.txtSetMetabolicAge.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetMetabolicAge").InnerText.ToString();
          this.txtSetActiveMet.Text = xmlDocument.SelectSingleNode("//configuracion/manual/ultimasMedidas/SetActiveMet").InnerText.ToString();
        }
        else
        {
          this.txtSetWeight.Text = string.Empty;
          this.txtSetPercentFat.Text = string.Empty;
          this.txtSetPercentHydration.Text = string.Empty;
          this.txtSetBoneMass.Text = string.Empty;
          this.txtSetMuscleMass.Text = string.Empty;
          this.txtSetPhysiqueRating.Text = string.Empty;
          this.txtSetVisceralFatRating.Text = string.Empty;
          this.txtSetMetabolicAge.Text = string.Empty;
          this.txtSetActiveMet.Text = string.Empty;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void editarMedidas()
    {
      try
      {
        this.lblSetWeight.Enabled = this.arrItemsMedidas[0];
        this.txtSetWeight.Enabled = this.arrItemsMedidas[0];
        this.lbl2SetWeight.Enabled = this.arrItemsMedidas[0];
        this.lblSetPercentFat.Enabled = this.arrItemsMedidas[1];
        this.txtSetPercentFat.Enabled = this.arrItemsMedidas[1];
        this.lbl2SetPercentFat.Enabled = this.arrItemsMedidas[1];
        this.lblSetPercentHydration.Enabled = this.arrItemsMedidas[2];
        this.txtSetPercentHydration.Enabled = this.arrItemsMedidas[2];
        this.lbl2SetPercentHydration.Enabled = this.arrItemsMedidas[2];
        this.lblSetBoneMass.Enabled = this.arrItemsMedidas[3];
        this.txtSetBoneMass.Enabled = this.arrItemsMedidas[3];
        this.lbl2SetBoneMass.Enabled = this.arrItemsMedidas[3];
        this.lblSetMuscleMass.Enabled = this.arrItemsMedidas[4];
        this.txtSetMuscleMass.Enabled = this.arrItemsMedidas[4];
        this.lbl2SetMuscleMass.Enabled = this.arrItemsMedidas[4];
        this.lblSetPhysiqueRating.Enabled = this.arrItemsMedidas[5];
        this.txtSetPhysiqueRating.Enabled = this.arrItemsMedidas[5];
        this.lblSetVisceralFatRating.Enabled = this.arrItemsMedidas[6];
        this.txtSetVisceralFatRating.Enabled = this.arrItemsMedidas[6];
        this.lblSetMetabolicAge.Enabled = this.arrItemsMedidas[7];
        this.txtSetMetabolicAge.Enabled = this.arrItemsMedidas[7];
        this.lbl2SetMetabolicAge.Enabled = this.arrItemsMedidas[7];
        this.lblSetActiveMet.Enabled = this.arrItemsMedidas[8];
        this.txtSetActiveMet.Enabled = this.arrItemsMedidas[8];
        this.lbl2SetActiveMet.Enabled = this.arrItemsMedidas[8];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void actualizarRuta(string strR)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuracion/ruta");
        if (xmlNode != null)
          xmlNode.InnerText = strR;
        xmlDocument.Save(this.xmlConfigFile);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void scale2fit_Load(object sender, EventArgs e)
    {
      try
      {
        this.blnLoad = true;
        string path = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\s2fit";
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        this.actualizaXML();
        if (Operators.CompareString(CultureInfo.CurrentCulture.ToString(), "en-US", false) == 0)
          this.chkKGLB.Visible = true;
        string empty = string.Empty;
        HttpWebResponse response = (HttpWebResponse) ((HttpWebRequest) WebRequest.Create(Operators.CompareString(CultureInfo.CurrentCulture.ToString(), "es-ES", false) != 0 ? "https://www.paypal.com/en_US/i/btn/btn_donate_SM.gif" : "https://www.paypal.com/es_ES/i/btn/btn_donate_SM.gif")).GetResponse();
        Image image = (Image) new Bitmap(response.GetResponseStream());
        response.Close();
        this.pctBoxPaypal.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pctBoxPaypal.Image = image;
        this.pctBoxPaypal.Cursor = Cursors.Hand;
        this.txtFechaActual.Culture = CultureInfo.CurrentCulture;
        if (!System.IO.File.Exists(path + "\\" + this.xmlConfigFile))
          System.IO.File.Copy(this.xmlConfigFile, path + "\\" + this.xmlConfigFile);
        this.xmlConfigFile = path + "\\" + this.xmlConfigFile;
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        this.intTipoGeneracion = Conversions.ToInteger(xmlDocument.SelectSingleNode("//configuracion/cboTipoGeneracion").InnerText.ToString());
        this.arrItemsMedidas[0] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item0").InnerText.ToString());
        this.arrItemsMedidas[1] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item1").InnerText.ToString());
        this.arrItemsMedidas[2] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item2").InnerText.ToString());
        this.arrItemsMedidas[3] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item3").InnerText.ToString());
        this.arrItemsMedidas[4] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item4").InnerText.ToString());
        this.arrItemsMedidas[5] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item5").InnerText.ToString());
        this.arrItemsMedidas[6] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item6").InnerText.ToString());
        this.arrItemsMedidas[7] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item7").InnerText.ToString());
        this.arrItemsMedidas[8] = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item8").InnerText.ToString());
        this.blnFechaActual = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkFechaActual").InnerText.ToString());
        this.blnUltimasMedidas = Conversions.ToBoolean(xmlDocument.SelectSingleNode("//configuracion/manual/chkUltimasMedidas").InnerText.ToString());
        if (Operators.CompareString(Strings.Mid(CultureInfo.CurrentCulture.ToString(), 1, 2), "es", false) == 0)
          this.cargaIdioma(1);
        else
          this.cargaIdioma(1000);
        this.editarMedidas();
        this.chkFechaActual.Checked = this.blnFechaActual;
        if (this.blnFechaActual)
          this.txtFechaActual.Text = string.Format("{0:dd/MM/yyyy hh:mm}", (object) System.DateTime.Now);
        this.chkUltimasMedidas.Checked = this.blnUltimasMedidas;
        this.strRuta = xmlDocument.SelectSingleNode("//configuracion/ruta").InnerText.ToString();
        if (Operators.CompareString(this.strRuta, string.Empty, false) == 0)
        {
          this.strRuta = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\s2fit";
          this.actualizarRuta(this.strRuta);
          if (!Directory.Exists(this.strRuta))
            Directory.CreateDirectory(this.strRuta);
          int intAccion = 1;
          this.presentacionPantalla(ref intAccion);
        }
        else
        {
          int intAccion = 2;
          this.presentacionPantalla(ref intAccion);
        }
        this.txtRuta.Text = this.strRuta;
        this.strFichero = "ws_s2fit" + string.Format("{0:yyyyMMddHHmm}", (object) System.DateTime.Now) + ".fit";
        this.cmdGenerar.Text = this.msgboxGenerar + " \"" + this.strFichero + "\"";
        this.txtIdUsuario.Text = Compartidos.Decrypt(xmlDocument.SelectSingleNode("//configuracion/withings/txtCadena1").InnerText.ToString());
        this.txtClavePublica.Text = Compartidos.Decrypt(xmlDocument.SelectSingleNode("//configuracion/withings/txtCadena2").InnerText.ToString());
        this.proponerUltimasMedidas(this.blnUltimasMedidas);
        this.chkKGLB.Checked = Conversions.ToBoolean(Interaction.IIf(Conversions.ToInteger(xmlDocument.SelectSingleNode("//configuracion/manual/chkKGr").InnerText) == 1, (object) true, (object) false));
        this.MultiplicoPor = Operators.CompareString(CultureInfo.CurrentCulture.ToString(), "en-US", false) != 0 ? 1f : (!this.chkKGLB.Checked ? 0.453592f : 1f);
        int num = this.intTipoGeneracion != 1 ? Conversions.ToInteger(xmlDocument.SelectSingleNode("//configuracion/withings/opt").InnerText) : Conversions.ToInteger(xmlDocument.SelectSingleNode("//configuracion/fitbit/opt").InnerText);
        this.RadioButton1.Checked = false;
        this.RadioButton2.Checked = false;
        this.RadioButton3.Checked = false;
        this.RadioButton4.Checked = false;
        this.RadioButton5.Checked = false;
        switch (num)
        {
          case 1:
            this.RadioButton1.Checked = true;
            break;
          case 2:
            this.RadioButton2.Checked = true;
            break;
          case 3:
            this.RadioButton3.Checked = true;
            break;
          case 4:
            this.RadioButton4.Checked = true;
            break;
          case 5:
            this.RadioButton5.Checked = true;
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxImposibleLanzar + "\r\n" + this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void cmdExportarRuta_Click(object sender, EventArgs e)
    {
      try
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        folderBrowserDialog.Description = this.msgboxfbdDescription;
        folderBrowserDialog.SelectedPath = this.strRuta;
        int num = (int) folderBrowserDialog.ShowDialog();
        this.strRuta = folderBrowserDialog.SelectedPath;
        this.txtRuta.Text = this.strRuta;
        this.actualizarRuta(this.strRuta);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void chkFechaActual_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuracion/manual/chkFechaActual");
        if (xmlNode != null)
          xmlNode.InnerText = this.chkFechaActual.Checked.ToString();
        xmlDocument.Save(this.xmlConfigFile);
        if (this.chkFechaActual.Checked)
          this.txtFechaActual.Text = string.Format("{0:dd/MM/yyyy hh:mm}", (object) System.DateTime.Now);
        else
          this.txtFechaActual.Text = string.Empty;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void chkListMedidas_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuracion/manual/chkListMedidas/Item" + Conversions.ToString(e.Index));
        if (xmlNode != null)
        {
          xmlNode.InnerText = Conversions.ToString((int) e.NewValue);
          this.arrItemsMedidas[e.Index] = (uint) e.NewValue > 0U;
        }
        xmlDocument.Save(this.xmlConfigFile);
        this.editarMedidas();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void cmdTipoGenerar_Click(object sender, EventArgs e)
    {
      try
      {
        string name = ((Control) sender).Name;
        if (Operators.CompareString(name, "cmdConfigurar", false) == 0)
        {
          if (!this.cmdGenerar.Enabled)
            return;
          int intAccion = 1;
          this.presentacionPantalla(ref intAccion);
        }
        else
        {
          if (Operators.CompareString(name, "cmdExportar", false) != 0 || this.cmdGenerar.Enabled)
            return;
          int intAccion = 2;
          this.presentacionPantalla(ref intAccion);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void chkUltimasMedidas_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuracion/manual/chkUltimasMedidas");
        if (xmlNode != null)
          xmlNode.InnerText = this.chkUltimasMedidas.Checked.ToString();
        xmlDocument.Save(this.xmlConfigFile);
        this.proponerUltimasMedidas(this.chkUltimasMedidas.Checked);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void Medidas_TextChanged(object sender, EventArgs e)
    {
      try
      {
        TextBox textBox = (TextBox) sender;
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        string xpath = "//configuracion/manual/ultimasMedidas/" + textBox.Name.Replace("txt", string.Empty);
        XmlNode xmlNode = xmlDocument.SelectSingleNode(xpath);
        if (xmlNode != null)
          xmlNode.InnerText = textBox.Text;
        xmlDocument.Save(this.xmlConfigFile);
        this.editarMedidas();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void cmdGenerar_Click(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument1 = new XmlDocument();
        xmlDocument1.Load(this.xmlConfigFile);
        FileIdMesg fileIdMesg = new FileIdMesg();
        WeightScaleMesg weightScaleMesg1 = new WeightScaleMesg();
        FileStream fileStream = new FileStream(this.strRuta + "\\" + this.strFichero, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
        Encode encode1 = new Encode();
        ArrayList arrayList1 = new ArrayList();
        scale2fit.myAutoMeasures myAutoMeasures1;
        switch (this.cboTipoGeneracion.SelectedIndex)
        {
          case 0:
            try
            {
              if (!Information.IsDate((object) this.txtFechaActual.Text))
              {
                int num = (int) Interaction.MsgBox((object) this.msgboxFechaHora, Title: ((object) this.Text));
                return;
              }
              if (Operators.CompareString(this.txtSetWeight.Text, string.Empty, false) == 0)
              {
                int num = (int) Interaction.MsgBox((object) this.msgboxPeso, Title: ((object) this.Text));
                return;
              }
              string[] strArray = new string[2]
              {
                "MM/dd/yyyy hh:mm",
                "dd/MM/yyyy hh:mm"
              };
              System.DateTime date = Conversions.ToDate(this.txtFechaActual.Text);
              Encode encode2 = encode1;
              encode2.Open((Stream) fileStream);
              try
              {
                Encode encode3 = encode1;
                Dynastream.Fit.DateTime timestamp_ = new Dynastream.Fit.DateTime(date);
                WeightScaleMesg weightScaleMesg2 = weightScaleMesg1;
                weightScaleMesg2.SetTimestamp(timestamp_);
                if (this.txtSetWeight.Enabled && Operators.CompareString(this.txtSetWeight.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetWeight((float?) (this.MultiplicoPor * Conversions.ToSingle(this.txtSetWeight.Text)));
                if (this.txtSetPercentFat.Enabled && Operators.CompareString(this.txtSetPercentFat.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetPercentFat((float?) Conversions.ToSingle(this.txtSetPercentFat.Text));
                if (this.txtSetPercentHydration.Enabled && Operators.CompareString(this.txtSetPercentHydration.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetPercentHydration((float?) Conversions.ToSingle(this.txtSetPercentHydration.Text));
                if (this.txtSetBoneMass.Enabled && Operators.CompareString(this.txtSetBoneMass.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetBoneMass((float?) (this.MultiplicoPor * Conversions.ToSingle(this.txtSetBoneMass.Text)));
                if (this.txtSetMuscleMass.Enabled && Operators.CompareString(this.txtSetMuscleMass.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetMuscleMass((float?) (this.MultiplicoPor * Conversions.ToSingle(this.txtSetMuscleMass.Text)));
                if (this.txtSetPhysiqueRating.Enabled && Operators.CompareString(this.txtSetPhysiqueRating.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetPhysiqueRating((byte?) Conversions.ToByte(this.txtSetPhysiqueRating.Text));
                if (this.txtSetVisceralFatRating.Enabled && Operators.CompareString(this.txtSetVisceralFatRating.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetVisceralFatRating((byte?) Conversions.ToByte(this.txtSetVisceralFatRating.Text));
                if (this.txtSetMetabolicAge.Enabled && Operators.CompareString(this.txtSetMetabolicAge.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetMetabolicAge((byte?) Conversions.ToByte(this.txtSetMetabolicAge.Text));
                if (this.txtSetActiveMet.Enabled && Operators.CompareString(this.txtSetActiveMet.Text, string.Empty, false) != 0)
                  weightScaleMesg2.SetActiveMet((float?) Conversions.ToSingle(this.txtSetActiveMet.Text));
                encode3.Write((Mesg) weightScaleMesg1);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
                ProjectData.ClearProjectError();
              }
              finally
              {
                encode2.Close();
              }
              break;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
              ProjectData.ClearProjectError();
              break;
            }
            finally
            {
              fileStream.Close();
            }
          case 1:
            bool flag1 = false;
            int num1 = checked (this.chkLstBoxFechas.Items.Count - 1);
            int index1 = 0;
            while (index1 <= num1)
            {
              if (this.chkLstBoxFechas.GetItemChecked(index1))
              {
                flag1 = true;
                break;
              }
              checked { ++index1; }
            }
            if (!flag1)
            {
              int num2 = (int) Interaction.MsgBox((object) this.msgAtLeastOne, Title: ((object) this.Text));
              return;
            }
            string accessToken = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena1").InnerText.ToString());
            string accessTokenSecret = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena2").InnerText.ToString());
            string str1 = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena3").InnerText.ToString());
            RestClient restClient = new RestClient("https://api.fitbit.com/");
            restClient.Authenticator = (IAuthenticator) OAuth1Authenticator.ForProtectedResource("75f47db3edf34217bbf75aa1f07e04b0", "3ed25705358c4f0f886adefc742e0c31", accessToken, accessTokenSecret);
            RestRequest restRequest1 = new RestRequest("oauth/request_token");
            IRestResponse restResponse1 = restClient.Execute((IRestRequest) restRequest1);
            if (!Information.IsNothing((object) restResponse1) && HttpStatusCode.OK == restResponse1.StatusCode)
            {
              RestRequest restRequest2 = new RestRequest(string.Format("/1/user/{0}/profile.xml", (object) str1));
              IRestResponse restResponse2 = restClient.Execute((IRestRequest) restRequest2);
              if (!Information.IsNothing((object) restResponse2) && HttpStatusCode.OK == restResponse2.StatusCode)
              {
                XmlDocument xmlDocument2 = new XmlDocument();
                string xml = restResponse2.Content.ToString().Replace("Logged In", "logged");
                xmlDocument2.LoadXml(xml);
                System.DateTime date = Conversions.ToDate(xmlDocument2.SelectSingleNode("//result/user/memberSince").InnerText);
                System.DateTime now = System.DateTime.Now;
                long num2 = checked (DateAndTime.DateDiff(DateInterval.Day, date, now) + 1L);
                long num3 = 0;
                while (num3 <= num2)
                {
                  System.DateTime dateTime = date.AddDays((double) num3);
                  RestRequest restRequest3 = new RestRequest(string.Format("/1/user/{0}/body/date/{1}.xml", (object) str1, (object) string.Format("{0:yyyy-MM-dd}", (object) dateTime)));
                  IRestResponse restResponse3 = restClient.Execute((IRestRequest) restRequest3);
                  if (!Information.IsNothing((object) restResponse3) && HttpStatusCode.OK == restResponse3.StatusCode)
                  {
                    ArrayList arrayList2 = arrayList1;
                    scale2fit.myAutoMeasures myAutoMeasures2;
                    ref scale2fit.myAutoMeasures local1 = ref myAutoMeasures2;
                    string str2 = Conversions.ToString(dateTime);
                    ref string local2 = ref str2;
                    IRestResponse restResponse4 = restResponse3;
                    string content = restResponse4.Content;
                    ref string local3 = ref content;
                    local1 = new scale2fit.myAutoMeasures(ref local2, ref local3);
                    scale2fit.myAutoMeasures myAutoMeasures3 = myAutoMeasures2;
                    restResponse4.Content = content;
                    Conversions.ToDate(str2);
                    // ISSUE: variable of a boxed type
                    __Boxed<scale2fit.myAutoMeasures> local4 = (ValueType) myAutoMeasures3;
                    arrayList2.Add((object) local4);
                  }
                  checked { ++num3; }
                }
              }
            }
            if (arrayList1.Count > 0)
            {
              Encode encode2 = encode1;
              encode2.Open((Stream) fileStream);
              Encode encode3 = encode1;
              int num2 = checked (arrayList1.Count - 1);
              int index2 = 0;
              while (index2 <= num2)
              {
                XmlDocument xmlDocument2 = new XmlDocument();
                object obj = arrayList1[index2];
                scale2fit.myAutoMeasures myAutoMeasures2 = obj != null ? (scale2fit.myAutoMeasures) obj : myAutoMeasures1;
                Dynastream.Fit.DateTime timestamp_ = new Dynastream.Fit.DateTime(myAutoMeasures2.fecha);
                xmlDocument2.LoadXml(myAutoMeasures2.xmlResponse.ToString().Replace("Logged In", "logged"));
                float single1;
                float single2;
                if (Operators.CompareString(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".", false) == 0)
                {
                  single1 = Conversions.ToSingle(xmlDocument2.SelectSingleNode("//result/body/weight").InnerText.ToString());
                  single2 = Conversions.ToSingle(xmlDocument2.SelectSingleNode("//result/body/fat").InnerText.ToString());
                }
                else
                {
                  single1 = Conversions.ToSingle(xmlDocument2.SelectSingleNode("//result/body/weight").InnerText.ToString().Replace(".", ","));
                  single2 = Conversions.ToSingle(xmlDocument2.SelectSingleNode("//result/body/fat").InnerText.ToString().Replace(".", ","));
                }
                if ((double) single1 > 0.0 && this.esFechaSeleccionada(myAutoMeasures2.fecha, "yyyy/MM/dd"))
                {
                  WeightScaleMesg weightScaleMesg2 = weightScaleMesg1;
                  weightScaleMesg2.SetTimestamp(timestamp_);
                  weightScaleMesg2.SetWeight((float?) single1);
                  weightScaleMesg2.SetPercentFat((float?) single2);
                  encode3.Write((Mesg) weightScaleMesg1);
                }
                checked { ++index2; }
              }
              encode2.Close();
              fileStream.Close();
              break;
            }
            int num4 = (int) Interaction.MsgBox((object) this.msgboxNoDatoDisponible, Title: ((object) this.Text));
            return;
          case 2:
            bool flag2 = false;
            int num5 = checked (this.chkLstBoxFechas.Items.Count - 1);
            int index3 = 0;
            while (index3 <= num5)
            {
              if (this.chkLstBoxFechas.GetItemChecked(index3))
              {
                flag2 = true;
                break;
              }
              checked { ++index3; }
            }
            if (!flag2)
            {
              int num2 = (int) Interaction.MsgBox((object) this.msgAtLeastOne, Title: ((object) this.Text));
              return;
            }
            Uri requestUri = new Uri(string.Format("http://wbsapi.withings.net/measure?action=getmeas&userid={0}&publickey={1}&devtype=1&startdate={2}&enddate={3}", (object) Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/withings/txtCadena1").InnerText.ToString()), (object) Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/withings/txtCadena2").InnerText.ToString()), (object) this.DateTimeToEPOCH(System.DateTime.Now.AddYears(-3)), (object) this.DateTimeToEPOCH(System.DateTime.Now)));
            Stream stream = (Stream) null;
            StreamReader streamReader = (StreamReader) null;
            string response = (string) null;
            try
            {
              stream = WebRequest.Create(requestUri).GetResponse().GetResponseStream();
              streamReader = new StreamReader(stream);
              response = streamReader.ReadToEnd();
            }
            catch (NotSupportedException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
            catch (OutOfMemoryException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
            catch (IOException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              response = string.Empty;
              ProjectData.ClearProjectError();
            }
            finally
            {
              if (streamReader != null)
              {
                streamReader.Close();
                streamReader.Dispose();
              }
              if (stream != null)
              {
                stream.Close();
                stream.Dispose();
              }
            }
            if (!Information.IsNothing((object) response))
            {
              scale2fit.StatusResponseEnum statusResponseEnum = new scale2fit.StatusResponseEnum();
              if (this.ReadStatus(response) == scale2fit.StatusResponseEnum.Successfull)
              {
                XmlDocument xmlDocument2 = JsonConvert.DeserializeXmlNode(response, "root");
                arrayList1.Add((object) xmlDocument2.InnerXml);
              }
            }
            if (arrayList1.Count > 0)
            {
              Encode encode2 = encode1;
              encode2.Open((Stream) fileStream);
              Encode encode3 = encode1;
              XmlDocument xmlDocument2 = new XmlDocument();
              xmlDocument2.LoadXml(arrayList1[0].ToString());
              arrayList1.Clear();
              XmlNodeList elementsByTagName = xmlDocument2.DocumentElement.GetElementsByTagName("measuregrps");
              int num2 = checked (elementsByTagName.Count - 1);
              int i1 = 0;
              while (i1 <= num2)
              {
                string innerText1 = elementsByTagName[i1].SelectSingleNode("date").InnerText;
                XmlNodeList xmlNodeList = elementsByTagName[i1].SelectNodes("measures");
                string Left1 = string.Empty;
                string Left2 = string.Empty;
                int num3 = checked (xmlNodeList.Count - 1);
                int i2 = 0;
                while (i2 <= num3)
                {
                  if (Operators.CompareString(xmlNodeList[i2].SelectSingleNode("type").InnerText, "1", false) == 0)
                  {
                    string innerText2 = xmlNodeList[i2].SelectSingleNode("value").InnerText;
                    int num6 = Math.Abs(Conversions.ToInteger(xmlNodeList[i2].SelectSingleNode("unit").InnerText));
                    Left1 = innerText2.Insert(checked (innerText2.Length - num6), ".");
                  }
                  else if (Operators.CompareString(xmlNodeList[i2].SelectSingleNode("type").InnerText, "6", false) == 0)
                  {
                    string innerText2 = xmlNodeList[i2].SelectSingleNode("value").InnerText;
                    int num6 = Math.Abs(Conversions.ToInteger(xmlNodeList[i2].SelectSingleNode("unit").InnerText));
                    Left2 = innerText2.Insert(checked (innerText2.Length - num6), ".");
                  }
                  checked { ++i2; }
                }
                if (Operators.CompareString(innerText1, string.Empty, false) != 0 && Operators.CompareString(Left1, string.Empty, false) != 0 && Operators.CompareString(Left2, string.Empty, false) != 0)
                {
                  System.DateTime dateTime = this.EPOCHToDateTime(Conversions.ToInteger(innerText1));
                  string str2 = string.Format("<result><body><weight>{0}</weight><fat>{1}</fat></body></result>", (object) Left1, (object) Left2);
                  ArrayList arrayList2 = arrayList1;
                  scale2fit.myAutoMeasures myAutoMeasures2;
                  ref scale2fit.myAutoMeasures local1 = ref myAutoMeasures2;
                  string str3 = Conversions.ToString(dateTime);
                  ref string local2 = ref str3;
                  ref string local3 = ref str2;
                  local1 = new scale2fit.myAutoMeasures(ref local2, ref local3);
                  scale2fit.myAutoMeasures myAutoMeasures3 = myAutoMeasures2;
                  Conversions.ToDate(str3);
                  // ISSUE: variable of a boxed type
                  __Boxed<scale2fit.myAutoMeasures> local4 = (ValueType) myAutoMeasures3;
                  arrayList2.Add((object) local4);
                }
                checked { ++i1; }
              }
              int num7 = checked (arrayList1.Count - 1);
              int index2 = 0;
              while (index2 <= num7)
              {
                XmlDocument xmlDocument3 = new XmlDocument();
                object obj = arrayList1[index2];
                scale2fit.myAutoMeasures myAutoMeasures2 = obj != null ? (scale2fit.myAutoMeasures) obj : myAutoMeasures1;
                xmlDocument3.LoadXml(myAutoMeasures2.xmlResponse);
                Dynastream.Fit.DateTime timestamp_ = new Dynastream.Fit.DateTime(myAutoMeasures2.fecha);
                float single1;
                float single2;
                if (Operators.CompareString(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, ".", false) == 0)
                {
                  single1 = Conversions.ToSingle(xmlDocument3.SelectSingleNode("//result/body/weight").InnerText.ToString());
                  single2 = Conversions.ToSingle(xmlDocument3.SelectSingleNode("//result/body/fat").InnerText.ToString());
                }
                else
                {
                  single1 = Conversions.ToSingle(xmlDocument3.SelectSingleNode("//result/body/weight").InnerText.ToString().Replace(".", ","));
                  single2 = Conversions.ToSingle(xmlDocument3.SelectSingleNode("//result/body/fat").InnerText.ToString().Replace(".", ","));
                }
                if ((double) single1 > 0.0 && this.esFechaSeleccionada(myAutoMeasures2.fecha, "yyyy/MM/dd hh:mm"))
                {
                  WeightScaleMesg weightScaleMesg2 = weightScaleMesg1;
                  weightScaleMesg2.SetTimestamp(timestamp_);
                  weightScaleMesg2.SetWeight((float?) single1);
                  weightScaleMesg2.SetPercentFat((float?) single2);
                  encode3.Write((Mesg) weightScaleMesg1);
                }
                checked { ++index2; }
              }
              encode2.Close();
              fileStream.Close();
              break;
            }
            int num8 = (int) Interaction.MsgBox((object) this.msgboxNoDatoDisponible, Title: ((object) this.Text));
            return;
        }
        int num9 = (int) Interaction.MsgBox((object) this.msgboxFicheroExito, Title: ((object) this.Text));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void txtFechaActual_GotFocus(object sender, EventArgs e)
    {
      try
      {
        this.txtFechaActual.Select(0, this.txtFechaActual.TextLength);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void txtFechaActual_Validating(object sender, CancelEventArgs e)
    {
      try
      {
        if (Information.IsDate((object) this.txtFechaActual.Text))
          return;
        string Left = CultureInfo.CurrentCulture.ToString();
        if (Operators.CompareString(Left, "en-AU", false) == 0 || Operators.CompareString(Left, "en-US", false) == 0)
          this.txtFechaActual.Text = string.Format("{0:MM/dd/yyyy HH:mm}", (object) System.DateTime.Now);
        else
          this.txtFechaActual.Text = string.Format("{0:dd/MM/yyyy HH:mm}", (object) System.DateTime.Now);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void Enteros_Validated(object sender, EventArgs e)
    {
      try
      {
        TextBox textBox = (TextBox) sender;
        if (Versioned.IsNumeric((object) textBox.Text))
        {
          int num = Operators.CompareString(textBox.Name, "txtSetActiveMet", false) == 0 ? 9999 : (int) byte.MaxValue;
          if (textBox.TextLength >= 1 & textBox.TextLength <= 4)
          {
            if (Conversions.ToShort(textBox.Text) >= (short) 1 & (int) Conversions.ToShort(textBox.Text) <= num)
              return;
            textBox.Text = string.Empty;
          }
          else
            textBox.Text = string.Empty;
        }
        else
          textBox.Text = string.Empty;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void Decimales_Validated(object sender, EventArgs e)
    {
      try
      {
        TextBox textBox = (TextBox) sender;
        if (Versioned.IsNumeric((object) textBox.Text))
        {
          long num1;
          long num2;
          if (Operators.CompareString(textBox.Name, "txtSetPercentFat", false) == 0 | Operators.CompareString(textBox.Name, "txtSetPercentHydration", false) == 0)
          {
            num1 = 0L;
            num2 = 100L;
          }
          else
          {
            num1 = 1L;
            num2 = 1000L;
          }
          if (!(Conversions.ToLong(textBox.Text) >= num1 & Conversions.ToLong(textBox.Text) <= num2))
            textBox.Text = string.Empty;
          else
            textBox.Text = Conversions.ToString(Decimal.Round(Conversions.ToDecimal(textBox.Text), 1));
        }
        else
          textBox.Text = string.Empty;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void cboTipoGeneracion_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuracion/cboTipoGeneracion");
        if (xmlNode != null)
        {
          ComboBox comboBox = (ComboBox) sender;
          xmlNode.InnerText = Conversions.ToString(comboBox.SelectedIndex);
          this.intTipoGeneracion = comboBox.SelectedIndex;
        }
        xmlDocument.Save(this.xmlConfigFile);
        int intAccion = 2;
        this.presentacionPantalla(ref intAccion);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void cmdAutorizarFitBit_Click(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        string xpath1 = "//configuracion/fitbit/txtCadena1";
        XmlNode xmlNode1 = xmlDocument.SelectSingleNode(xpath1);
        if (xmlNode1 != null)
          xmlNode1.InnerText = string.Empty;
        string xpath2 = "//configuracion/fitbit/txtCadena2";
        XmlNode xmlNode2 = xmlDocument.SelectSingleNode(xpath2);
        if (xmlNode2 != null)
          xmlNode2.InnerText = string.Empty;
        string xpath3 = "//configuracion/fitbit/txtCadena3";
        XmlNode xmlNode3 = xmlDocument.SelectSingleNode(xpath3);
        if (xmlNode3 != null)
          xmlNode3.InnerText = string.Empty;
        xmlDocument.Save(this.xmlConfigFile);
        RestClient restClient = new RestClient("https://api.fitbit.com/");
        restClient.Authenticator = (IAuthenticator) OAuth1Authenticator.ForRequestToken("75f47db3edf34217bbf75aa1f07e04b0", "3ed25705358c4f0f886adefc742e0c31");
        RestRequest restRequest1 = new RestRequest("oauth/request_token");
        IRestResponse restResponse1 = restClient.Execute((IRestRequest) restRequest1);
        if (Information.IsNothing((object) restResponse1) || HttpStatusCode.OK != restResponse1.StatusCode)
          return;
        string[] strArray1 = restResponse1.Content.Split('&');
        string token = strArray1[0].Replace("oauth_token=", string.Empty);
        string tokenSecret = strArray1[1].Replace("oauth_token_secret=", string.Empty);
        RestRequest restRequest2 = new RestRequest("oauth/authorize?oauth_token=" + token);
        Process.Start(restClient.BuildUri((IRestRequest) restRequest2).ToString());
        string verifier = Interaction.InputBox("PIN");
        RestRequest restRequest3 = new RestRequest("oauth/access_token");
        restClient.Authenticator = (IAuthenticator) OAuth1Authenticator.ForAccessToken("75f47db3edf34217bbf75aa1f07e04b0", "3ed25705358c4f0f886adefc742e0c31", token, tokenSecret, verifier);
        IRestResponse restResponse2 = restClient.Execute((IRestRequest) restRequest3);
        if (Strings.InStr(restResponse2.Content, "oauth_token") > 0 && Strings.InStr(restResponse2.Content, "oauth_token_secret") > 0 && Strings.InStr(restResponse2.Content, "encoded_user_id") > 0)
        {
          string[] strArray2 = restResponse2.Content.ToString().Split('&');
          string str1 = Compartidos.Encrypt(strArray2[0].Replace("oauth_token=", string.Empty));
          string str2 = Compartidos.Encrypt(strArray2[1].Replace("oauth_token_secret=", string.Empty));
          string str3 = Compartidos.Encrypt(strArray2[2].Replace("encoded_user_id=", string.Empty));
          xmlDocument.Load(this.xmlConfigFile);
          string xpath4 = "//configuracion/fitbit/txtCadena1";
          XmlNode xmlNode4 = xmlDocument.SelectSingleNode(xpath4);
          if (xmlNode4 != null)
            xmlNode4.InnerText = str1;
          string xpath5 = "//configuracion/fitbit/txtCadena2";
          XmlNode xmlNode5 = xmlDocument.SelectSingleNode(xpath5);
          if (xmlNode5 != null)
            xmlNode5.InnerText = str2;
          string xpath6 = "//configuracion/fitbit/txtCadena3";
          XmlNode xmlNode6 = xmlDocument.SelectSingleNode(xpath6);
          if (xmlNode6 != null)
            xmlNode6.InnerText = str3;
          xmlDocument.Save(this.xmlConfigFile);
          int intAccion = 2;
          this.presentacionPantalla(ref intAccion);
        }
        else
        {
          int num = (int) MessageBox.Show(this.msgboxNoPinFitBit, this.Text);
          xmlDocument.Load(this.xmlConfigFile);
          string xpath4 = "//configuracion/fitbit/txtCadena1";
          XmlNode xmlNode4 = xmlDocument.SelectSingleNode(xpath4);
          if (xmlNode4 != null)
            xmlNode4.InnerText = string.Empty;
          string xpath5 = "//configuracion/fitbit/txtCadena2";
          XmlNode xmlNode5 = xmlDocument.SelectSingleNode(xpath5);
          if (xmlNode5 != null)
            xmlNode5.InnerText = string.Empty;
          string xpath6 = "//configuracion/fitbit/txtCadena3";
          XmlNode xmlNode6 = xmlDocument.SelectSingleNode(xpath6);
          if (xmlNode6 != null)
            xmlNode6.InnerText = string.Empty;
          xmlDocument.Save(this.xmlConfigFile);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void cmdEnlazarWithings_Click(object sender, EventArgs e)
    {
      try
      {
        Uri requestUri = new Uri(string.Format("http://wbsapi.withings.net/user?action=getbyuserid&userid={0}&publickey={1}", (object) this.txtIdUsuario.Text, (object) this.txtClavePublica.Text));
        Stream stream = (Stream) null;
        StreamReader streamReader = (StreamReader) null;
        string response = (string) null;
        try
        {
          stream = WebRequest.Create(requestUri).GetResponse().GetResponseStream();
          streamReader = new StreamReader(stream);
          response = streamReader.ReadToEnd();
        }
        catch (NotSupportedException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        catch (OutOfMemoryException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          response = string.Empty;
          ProjectData.ClearProjectError();
        }
        finally
        {
          if (streamReader != null)
          {
            streamReader.Close();
            streamReader.Dispose();
          }
          if (stream != null)
          {
            stream.Close();
            stream.Dispose();
          }
        }
        if (Information.IsNothing((object) response))
          return;
        scale2fit.StatusResponseEnum statusResponseEnum = new scale2fit.StatusResponseEnum();
        if (this.ReadStatus(response) != scale2fit.StatusResponseEnum.Successfull)
          return;
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        string xpath1 = "//configuracion/withings/txtCadena1";
        xmlDocument.SelectSingleNode(xpath1);
        XmlNode xmlNode1 = xmlDocument.SelectSingleNode(xpath1);
        if (xmlNode1 != null)
          xmlNode1.InnerText = Compartidos.Encrypt(this.txtIdUsuario.Text);
        string xpath2 = "//configuracion/withings/txtCadena2";
        XmlNode xmlNode2 = xmlDocument.SelectSingleNode(xpath2);
        if (xmlNode2 != null)
          xmlNode2.InnerText = Compartidos.Encrypt(this.txtClavePublica.Text);
        xmlDocument.Save(this.xmlConfigFile);
        int intAccion = 2;
        this.presentacionPantalla(ref intAccion);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void txtFechaActual_LostFocus(object sender, EventArgs e)
    {
      this.strFichero = "ws_s2fit" + string.Format("{0:yyyyMMddHHmm}", (object) Conversions.ToDate(this.txtFechaActual.Text)) + ".fit";
      this.cmdGenerar.Text = this.msgboxGenerar + " \"" + this.strFichero + "\"";
    }

    private void cargaIdioma(int intTipo)
    {
      using (ResXResourceSet resXresourceSet = new ResXResourceSet(intTipo != 1 ? "stringResource.resx" : "stringResource.es.resx"))
      {
        this.cmdUpload.Text = resXresourceSet.GetString("cmdUpload");
        this.rtbFitBit.Text = resXresourceSet.GetString("rtbFitBit");
        this.chkFechaActual.Text = resXresourceSet.GetString("chkFechaActual");
        this.chkUltimasMedidas.Text = resXresourceSet.GetString("chkUltimasMedidas");
        this.msgboxNoPinFitBit = resXresourceSet.GetString("msgboxNoPinFitBit");
        this.msgboxNoDatoDisponible = resXresourceSet.GetString("msgboxNoDatoDisponible");
        this.msgboxImposibleLanzar = resXresourceSet.GetString("msgboxImposibleLanzar");
        this.msgboxFicheroExito = resXresourceSet.GetString("msgboxFicheroExito");
        this.msgboxFechaHora = resXresourceSet.GetString("msgboxFechaHora");
        this.msgboxError = resXresourceSet.GetString("msgboxError");
        this.msgboxPeso = resXresourceSet.GetString("msgboxPeso");
        this.lblWhatMeasure.Text = resXresourceSet.GetString("lblWhatMeasure");
        this.RadioButton1.Text = resXresourceSet.GetString("RadioButton1");
        this.RadioButton2.Text = resXresourceSet.GetString("RadioButton2");
        this.RadioButton3.Text = resXresourceSet.GetString("RadioButton3");
        this.RadioButton4.Text = resXresourceSet.GetString("RadioButton4");
        this.RadioButton5.Text = resXresourceSet.GetString("RadioButton5");
        this.msgBoxAlmenosUna = resXresourceSet.GetString("msgAtLeastOne");
        this.msgAtLeastOne = resXresourceSet.GetString("msgAtLeastOne");
        this.lblUsrID.Text = resXresourceSet.GetString("lblUsrID");
        this.lblUrsConectado.Text = resXresourceSet.GetString("lblUrsConectado");
        this.lblTipoGeneracion.Text = resXresourceSet.GetString("lblTipoGeneracion");
        this.lblSetWeight.Text = resXresourceSet.GetString("lblSetWeight");
        this.lblSetVisceralFatRating.Text = resXresourceSet.GetString("lblSetVisceralFatRating");
        this.lblSetPhysiqueRating.Text = resXresourceSet.GetString("lblSetPhysiqueRating");
        this.lblSetPercentFat.Text = resXresourceSet.GetString("lblSetPercentFat");
        this.lblSetMuscleMass.Text = resXresourceSet.GetString("lblSetMuscleMass");
        this.lblSetMetabolicAge.Text = resXresourceSet.GetString("lblSetMetabolicAge");
        this.lblSetBoneMass.Text = resXresourceSet.GetString("lblSetBoneMass");
        this.lblSetPercentHydration.Text = resXresourceSet.GetString("lblSetBodyWater");
        this.lblSetActiveMet.Text = resXresourceSet.GetString("lblSetActiveMet");
        this.lblPublicKey.Text = resXresourceSet.GetString("lblPublicKey");
        this.lblMedidas.Text = resXresourceSet.GetString("lblMedidas");
        this.lblFechaActual.Text = resXresourceSet.GetString("lblFechaActual");
        this.lbl2SetMetabolicAge.Text = resXresourceSet.GetString("lbl2SetMetabolicAge");
        this.frawithings.Text = resXresourceSet.GetString("frawithings");
        this.fraFitBit.Text = resXresourceSet.GetString("fraFitBit");
        this.fraFicheroExportacion.Text = resXresourceSet.GetString("fraFicheroExportacion");
        this.fraExportarMedidas.Text = resXresourceSet.GetString("fraExportarMedidas");
        this.fraConfiguracionManual.Text = resXresourceSet.GetString("fraConfiguracionManual");
        this.msgboxfbdDescription = resXresourceSet.GetString("fbd.Description");
        this.msgboxGenerar = resXresourceSet.GetString("cmdGenerar");
        this.cmdExportar.Text = resXresourceSet.GetString("cmdExportar");
        this.cmdEnlazarWithings.Text = resXresourceSet.GetString("cmdEnlazarWithings");
        this.cmdConfigurar.Text = resXresourceSet.GetString("cmdConfigurar");
        this.cmdAutorizarFitBit.Text = resXresourceSet.GetString("cmdAutorizarFitBit");
        this.chkFechaActual.Text = resXresourceSet.GetString("chkFechaActual");
        ComboBox cboTipoGeneracion = this.cboTipoGeneracion;
        cboTipoGeneracion.Items.Insert(0, (object) resXresourceSet.GetString("cboTipoGeneracion0"));
        cboTipoGeneracion.Items.Insert(1, (object) resXresourceSet.GetString("cboTipoGeneracion1"));
        cboTipoGeneracion.Items.Insert(2, (object) resXresourceSet.GetString("cboTipoGeneracion2"));
        cboTipoGeneracion.SelectedIndex = this.intTipoGeneracion;
        CheckedListBox chkListMedidas = this.chkListMedidas;
        chkListMedidas.Items.Insert(0, (object) resXresourceSet.GetString("chkListMedidas0"));
        chkListMedidas.SetItemChecked(0, this.arrItemsMedidas[0]);
        chkListMedidas.Items.Insert(1, (object) resXresourceSet.GetString("chkListMedidas1"));
        chkListMedidas.SetItemChecked(1, this.arrItemsMedidas[1]);
        chkListMedidas.Items.Insert(2, (object) resXresourceSet.GetString("chkListMedidas2"));
        chkListMedidas.SetItemChecked(2, this.arrItemsMedidas[2]);
        chkListMedidas.Items.Insert(3, (object) resXresourceSet.GetString("chkListMedidas3"));
        chkListMedidas.SetItemChecked(3, this.arrItemsMedidas[3]);
        chkListMedidas.Items.Insert(4, (object) resXresourceSet.GetString("chkListMedidas4"));
        chkListMedidas.SetItemChecked(4, this.arrItemsMedidas[4]);
        chkListMedidas.Items.Insert(5, (object) resXresourceSet.GetString("chkListMedidas5"));
        chkListMedidas.SetItemChecked(5, this.arrItemsMedidas[5]);
        chkListMedidas.Items.Insert(6, (object) resXresourceSet.GetString("chkListMedidas6"));
        chkListMedidas.SetItemChecked(6, this.arrItemsMedidas[6]);
        chkListMedidas.Items.Insert(7, (object) resXresourceSet.GetString("chkListMedidas7"));
        chkListMedidas.SetItemChecked(7, this.arrItemsMedidas[7]);
        chkListMedidas.Items.Insert(8, (object) resXresourceSet.GetString("chkListMedidas8"));
        chkListMedidas.SetItemChecked(8, this.arrItemsMedidas[8]);
      }
      if (Operators.CompareString(CultureInfo.CurrentCulture.ToString(), "en-US", false) == 0)
      {
        if (!this.chkKGLB.Checked)
        {
          this.lbl2SetBoneMass.Text = "Lb";
          this.lbl2SetWeight.Text = "Lb";
          this.lbl2SetMuscleMass.Text = "Lb";
          this.MultiplicoPor = 0.453592f;
        }
        else
        {
          this.lbl2SetBoneMass.Text = "Kg";
          this.lbl2SetWeight.Text = "Kg";
          this.lbl2SetMuscleMass.Text = "Kg";
          this.MultiplicoPor = 1f;
        }
      }
      else
      {
        this.lbl2SetBoneMass.Text = "Kg";
        this.lbl2SetWeight.Text = "Kg";
        this.lbl2SetMuscleMass.Text = "Kg";
        this.MultiplicoPor = 1f;
      }
    }

    private void linkWEB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://jmfloreszazo.com/scale2fi/");

    private void cargaFechas()
    {
      try
      {
        XmlDocument xmlDocument1 = new XmlDocument();
        xmlDocument1.Load(this.xmlConfigFile);
        ArrayList arrayList1 = new ArrayList();
        switch (this.cboTipoGeneracion.SelectedIndex)
        {
          case 1:
            string accessToken = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena1").InnerText.ToString());
            string accessTokenSecret = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena2").InnerText.ToString());
            string str1 = Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/fitbit/txtCadena3").InnerText.ToString());
            RestClient restClient = new RestClient("https://api.fitbit.com/");
            restClient.Authenticator = (IAuthenticator) OAuth1Authenticator.ForProtectedResource("75f47db3edf34217bbf75aa1f07e04b0", "3ed25705358c4f0f886adefc742e0c31", accessToken, accessTokenSecret);
            RestRequest restRequest1 = new RestRequest("oauth/request_token");
            IRestResponse restResponse1 = restClient.Execute((IRestRequest) restRequest1);
            this.chkLstBoxFechas.Items.Clear();
            if (!Information.IsNothing((object) restResponse1) && HttpStatusCode.OK == restResponse1.StatusCode)
            {
              RestRequest restRequest2 = new RestRequest(string.Format("/1/user/{0}/profile.xml", (object) str1));
              IRestResponse restResponse2 = restClient.Execute((IRestRequest) restRequest2);
              if (!Information.IsNothing((object) restResponse2) && HttpStatusCode.OK == restResponse2.StatusCode)
              {
                XmlDocument xmlDocument2 = new XmlDocument();
                string xml = restResponse2.Content.ToString().Replace("Logged In", "logged");
                xmlDocument2.LoadXml(xml);
                System.DateTime date = Conversions.ToDate(xmlDocument2.SelectSingleNode("//result/user/memberSince").InnerText);
                System.DateTime now = System.DateTime.Now;
                long num1 = checked (DateAndTime.DateDiff(DateInterval.Day, date, now) + 1L);
                long num2 = 0;
                while (num2 <= num1)
                {
                  System.DateTime dateTime = date.AddDays((double) num2);
                  RestRequest restRequest3 = new RestRequest(string.Format("/1/user/{0}/body/date/{1}.xml", (object) str1, (object) string.Format("{0:yyyy-MM-dd}", (object) dateTime)));
                  IRestResponse restResponse3 = restClient.Execute((IRestRequest) restRequest3);
                  if (!Information.IsNothing((object) restResponse3) && HttpStatusCode.OK == restResponse3.StatusCode)
                  {
                    ArrayList arrayList2 = arrayList1;
                    scale2fit.myAutoMeasures myAutoMeasures1;
                    ref scale2fit.myAutoMeasures local1 = ref myAutoMeasures1;
                    string str2 = Conversions.ToString(dateTime);
                    ref string local2 = ref str2;
                    IRestResponse restResponse4 = restResponse3;
                    string content = restResponse4.Content;
                    ref string local3 = ref content;
                    local1 = new scale2fit.myAutoMeasures(ref local2, ref local3);
                    scale2fit.myAutoMeasures myAutoMeasures2 = myAutoMeasures1;
                    restResponse4.Content = content;
                    Conversions.ToDate(str2);
                    // ISSUE: variable of a boxed type
                    __Boxed<scale2fit.myAutoMeasures> local4 = (ValueType) myAutoMeasures2;
                    arrayList2.Add((object) local4);
                  }
                  checked { ++num2; }
                }
              }
            }
            int index1 = 0;
            int num3 = checked (arrayList1.Count - 1);
            int index2 = 0;
            while (index2 <= num3)
            {
              XmlDocument xmlDocument2 = new XmlDocument();
              object obj = arrayList1[index2];
              scale2fit.myAutoMeasures myAutoMeasures1;
              scale2fit.myAutoMeasures myAutoMeasures2 = obj != null ? (scale2fit.myAutoMeasures) obj : myAutoMeasures1;
              Dynastream.Fit.DateTime dateTime = new Dynastream.Fit.DateTime(myAutoMeasures2.fecha);
              xmlDocument2.LoadXml(myAutoMeasures2.xmlResponse.ToString().Replace("Logged In", "logged"));
              float single = Conversions.ToSingle(xmlDocument2.SelectSingleNode("//result/body/weight").InnerText.ToString().Replace(".", ","));
              Conversions.ToSingle(xmlDocument2.SelectSingleNode("//result/body/fat").InnerText.ToString().Replace(".", ","));
              if ((double) single > 0.0)
              {
                CheckedListBox chkLstBoxFechas = this.chkLstBoxFechas;
                chkLstBoxFechas.Items.Insert(index1, (object) myAutoMeasures2.fecha.ToString("yyyy/MM/dd"));
                chkLstBoxFechas.SetItemChecked(index1, false);
                checked { ++index1; }
              }
              checked { ++index2; }
            }
            break;
          case 2:
            Uri requestUri = new Uri(string.Format("http://wbsapi.withings.net/measure?action=getmeas&userid={0}&publickey={1}&devtype=1&startdate={2}&enddate={3}", (object) Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/withings/txtCadena1").InnerText.ToString()), (object) Compartidos.Decrypt(xmlDocument1.SelectSingleNode("//configuracion/withings/txtCadena2").InnerText.ToString()), (object) this.DateTimeToEPOCH(System.DateTime.Now.AddYears(-3)), (object) this.DateTimeToEPOCH(System.DateTime.Now)));
            Stream stream = (Stream) null;
            StreamReader streamReader = (StreamReader) null;
            string response = (string) null;
            try
            {
              stream = WebRequest.Create(requestUri).GetResponse().GetResponseStream();
              streamReader = new StreamReader(stream);
              response = streamReader.ReadToEnd();
            }
            catch (NotSupportedException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
            catch (OutOfMemoryException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              ProjectData.ClearProjectError();
            }
            catch (IOException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              response = string.Empty;
              ProjectData.ClearProjectError();
            }
            finally
            {
              if (streamReader != null)
              {
                streamReader.Close();
                streamReader.Dispose();
              }
              if (stream != null)
              {
                stream.Close();
                stream.Dispose();
              }
            }
            if (!Information.IsNothing((object) response))
            {
              scale2fit.StatusResponseEnum statusResponseEnum = new scale2fit.StatusResponseEnum();
              if (this.ReadStatus(response) == scale2fit.StatusResponseEnum.Successfull)
              {
                XmlDocument xmlDocument2 = JsonConvert.DeserializeXmlNode(response, "root");
                arrayList1.Add((object) xmlDocument2.InnerXml);
              }
            }
            if (arrayList1.Count > 0)
            {
              XmlDocument xmlDocument2 = new XmlDocument();
              xmlDocument2.LoadXml(arrayList1[0].ToString());
              arrayList1.Clear();
              XmlNodeList elementsByTagName = xmlDocument2.DocumentElement.GetElementsByTagName("measuregrps");
              this.chkLstBoxFechas.Items.Clear();
              int num1 = checked (elementsByTagName.Count - 1);
              int num2 = 0;
              while (num2 <= num1)
              {
                System.DateTime dateTime = this.EPOCHToDateTime(Conversions.ToInteger(elementsByTagName[num2].SelectSingleNode("date").InnerText));
                CheckedListBox chkLstBoxFechas = this.chkLstBoxFechas;
                chkLstBoxFechas.Items.Insert(num2, (object) dateTime.ToString("yyyy/MM/dd hh:mm"));
                chkLstBoxFechas.SetItemChecked(num2, false);
                checked { ++num2; }
              }
              break;
            }
            break;
        }
        this.PonRangoFechas(this.intTipoGeneracion != 1 ? Conversions.ToInteger(xmlDocument1.SelectSingleNode("//configuracion/withings/opt").InnerText) : Conversions.ToInteger(xmlDocument1.SelectSingleNode("//configuracion/fitbit/opt").InnerText));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private bool esFechaSeleccionada(System.DateTime dtFecha, string strFormato)
    {
      bool flag = false;
      int num = checked (this.chkLstBoxFechas.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (this.chkLstBoxFechas.GetItemChecked(index) && Operators.CompareString(dtFecha.ToString(strFormato), this.chkLstBoxFechas.Items[index].ToString(), false) == 0)
        {
          flag = true;
          break;
        }
        checked { ++index; }
      }
      return flag;
    }

    private void actualizaXML()
    {
      string str = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments + "\\s2fit\\" + this.xmlConfigFile;
      if (!System.IO.File.Exists(str))
        return;
      string xmlConfigFile = this.xmlConfigFile;
      string tempFileName = Path.GetTempFileName();
      System.IO.File.Delete(tempFileName);
      System.IO.File.Copy(xmlConfigFile, tempFileName);
      string filename = tempFileName;
      XmlDocument xmlDocument1 = new XmlDocument();
      xmlDocument1.Load(str);
      XmlDocument xmlDocument2 = new XmlDocument();
      xmlDocument2.Load(filename);
      int integer1 = Conversions.ToInteger(xmlDocument1.SelectSingleNode("//configuracion/version").InnerText.ToString());
      int integer2 = Conversions.ToInteger(xmlDocument2.SelectSingleNode("//configuracion/version").InnerText.ToString());
      if (integer1 != integer2)
      {
        if (integer1 < 2)
        {
          XmlNode element1 = (XmlNode) xmlDocument1.CreateElement("chkKGr");
          element1.InnerText = "0";
          xmlDocument1.SelectSingleNode("//configuracion/manual").AppendChild(element1);
          XmlNode element2 = (XmlNode) xmlDocument1.CreateElement("opt");
          xmlDocument1.SelectSingleNode("//configuracion/fitbit").AppendChild(element2);
          element2.InnerText = "4";
          XmlNode element3 = (XmlNode) xmlDocument1.CreateElement("opt");
          xmlDocument1.SelectSingleNode("//configuracion/withings").AppendChild(element3);
          element3.InnerText = "4";
          XmlNode xmlNode = xmlDocument1.SelectSingleNode("//configuracion/version");
          if (xmlNode != null)
            xmlNode.InnerText = "2";
          xmlDocument1.Save(str);
        }
        if (integer1 < 3)
        {
          XmlNode element1 = (XmlNode) xmlDocument1.CreateElement("GarminConnect");
          xmlDocument1.SelectSingleNode("//configuracion").AppendChild(element1);
          XmlNode element2 = (XmlNode) xmlDocument1.CreateElement("Active");
          xmlDocument1.SelectSingleNode("//configuracion/GarminConnect").AppendChild(element2);
          element2.InnerText = "0";
          XmlNode element3 = (XmlNode) xmlDocument1.CreateElement("txtCadena1");
          xmlDocument1.SelectSingleNode("//configuracion/GarminConnect").AppendChild(element3);
          element3.InnerText = string.Empty;
          XmlNode element4 = (XmlNode) xmlDocument1.CreateElement("txtCadena2");
          xmlDocument1.SelectSingleNode("//configuracion/GarminConnect").AppendChild(element4);
          element4.InnerText = string.Empty;
          XmlNode xmlNode = xmlDocument1.SelectSingleNode("//configuracion/version");
          if (xmlNode != null)
            xmlNode.InnerText = "3";
          xmlDocument1.Save(str);
        }
        if (integer1 >= 4)
          ;
      }
      System.IO.File.Delete(tempFileName);
    }

    private void PonRangoFechas(int intFilto)
    {
      switch (intFilto)
      {
        case 1:
          int num1 = checked (this.chkLstBoxFechas.Items.Count - 1);
          int index1 = 0;
          while (index1 <= num1)
          {
            if (Operators.CompareString(string.Format("{0:yyyy}", (object) Conversions.ToDate(this.chkLstBoxFechas.Items[index1].ToString())), string.Format("{0:yyyy}", (object) System.DateTime.Now), false) == 0)
              this.chkLstBoxFechas.SetItemChecked(index1, true);
            else
              this.chkLstBoxFechas.SetItemChecked(index1, false);
            checked { ++index1; }
          }
          break;
        case 2:
          int num2 = checked (this.chkLstBoxFechas.Items.Count - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            this.chkLstBoxFechas.SetItemChecked(index2, false);
            if (Operators.CompareString(string.Format("{0:yyyy}", (object) Conversions.ToDate(this.chkLstBoxFechas.Items[index2].ToString())), string.Format("{0:yyyy}", (object) System.DateTime.Now), false) == 0 && Operators.CompareString(string.Format("{0:MM}", (object) Conversions.ToDate(this.chkLstBoxFechas.Items[index2].ToString())), string.Format("{0:MM}", (object) System.DateTime.Now), false) == 0)
              this.chkLstBoxFechas.SetItemChecked(index2, true);
            checked { ++index2; }
          }
          break;
        case 3:
          CultureInfo cultureInfo = new CultureInfo(CultureInfo.CurrentCulture.ToString());
          Calendar calendar = cultureInfo.Calendar;
          CalendarWeekRule calendarWeekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
          DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
          int weekOfYear = calendar.GetWeekOfYear(System.DateTime.Now, calendarWeekRule, firstDayOfWeek);
          int num3 = checked (this.chkLstBoxFechas.Items.Count - 1);
          int index3 = 0;
          while (index3 <= num3)
          {
            if (Operators.CompareString(string.Format("{0:yyyy}", (object) Conversions.ToDate(this.chkLstBoxFechas.Items[index3].ToString())), string.Format("{0:yyyy}", (object) System.DateTime.Now), false) == 0)
            {
              if (calendar.GetWeekOfYear(Conversions.ToDate(string.Format("{0:" + cultureInfo.DateTimeFormat.ShortDatePattern + "}", (object) Conversions.ToDate(this.chkLstBoxFechas.Items[index3].ToString()))), calendarWeekRule, firstDayOfWeek) == weekOfYear)
                this.chkLstBoxFechas.SetItemChecked(index3, true);
              else
                this.chkLstBoxFechas.SetItemChecked(index3, false);
            }
            checked { ++index3; }
          }
          break;
        case 4:
          int num4 = checked (this.chkLstBoxFechas.Items.Count - 1);
          int index4 = 0;
          while (index4 <= num4)
          {
            this.chkLstBoxFechas.SetItemChecked(index4, true);
            checked { ++index4; }
          }
          break;
        case 5:
          int num5 = checked (this.chkLstBoxFechas.Items.Count - 1);
          int index5 = 0;
          while (index5 <= num5)
          {
            this.chkLstBoxFechas.SetItemChecked(index5, false);
            checked { ++index5; }
          }
          break;
      }
    }

    private void chkKGLB_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode("//configuracion/manual/chkKGr");
        if (xmlNode != null)
        {
          xmlNode.InnerText = Conversions.ToString(Interaction.IIf(this.chkKGLB.Checked, (object) "1", (object) "0"));
          if (Operators.CompareString(CultureInfo.CurrentCulture.ToString(), "en-US", false) == 0)
          {
            if (!this.chkKGLB.Checked)
            {
              this.lbl2SetBoneMass.Text = "Lb";
              this.lbl2SetWeight.Text = "Lb";
              this.lbl2SetMuscleMass.Text = "Lb";
              this.MultiplicoPor = 0.453592f;
            }
            else
            {
              this.lbl2SetBoneMass.Text = "Kg";
              this.lbl2SetWeight.Text = "Kg";
              this.lbl2SetMuscleMass.Text = "Kg";
              this.MultiplicoPor = 1f;
            }
          }
          else
          {
            this.lbl2SetBoneMass.Text = "Kg";
            this.lbl2SetWeight.Text = "Kg";
            this.lbl2SetMuscleMass.Text = "Kg";
            this.MultiplicoPor = 1f;
          }
        }
        xmlDocument.Save(this.xmlConfigFile);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void RadioButton_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (!this.blnLoad)
          return;
        string empty = string.Empty;
        string xpath = this.intTipoGeneracion != 1 ? "//configuracion/withings/opt" : "//configuracion/fitbit/opt";
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(this.xmlConfigFile);
        XmlNode xmlNode = xmlDocument.SelectSingleNode(xpath);
        if (xmlNode == null)
          return;
        int intFilto = 4;
        string name = ((Control) sender).Name;
        if (Operators.CompareString(name, "RadioButton1", false) == 0)
          intFilto = 1;
        else if (Operators.CompareString(name, "RadioButton2", false) == 0)
          intFilto = 2;
        else if (Operators.CompareString(name, "RadioButton3", false) == 0)
          intFilto = 3;
        else if (Operators.CompareString(name, "RadioButton4", false) == 0)
          intFilto = 4;
        else if (Operators.CompareString(name, "RadioButton5", false) == 0)
          intFilto = 5;
        xmlNode.InnerText = Conversions.ToString(intFilto);
        xmlDocument.Save(this.xmlConfigFile);
        this.PonRangoFechas(intFilto);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) (this.msgboxError + ex.Message), Title: ((object) this.Text));
        ProjectData.ClearProjectError();
      }
    }

    private void pctBoxPaypal_Click(object sender, EventArgs e) => Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=contacto%40jmfloreszazo%2ecom&lc=US&item_name=Colaborar%20con%20el%20Blog%20%2f%2f%20Support%20the%20Blog&item_number=cb%2djmfloreszazo%2ecom&amount=5%2e00&currency_code=EUR&no_note=0&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest");

    private void btnUpload_Click(object sender, EventArgs e)
    {
      int num = (int) new uploadService()
      {
        xmlConfigFile = this.xmlConfigFile
      }.ShowDialog();
    }

    private enum StatusResponseEnum
    {
      Successfull = 0,
      HashMissingOrInvalid = 100, // 0x00000064
      UserIdAbsentOrIncorrect = 247, // 0x000000F7
      UserDataIsNotPublic = 250, // 0x000000FA
      EmailAddressIsUnknownInvalid = 264, // 0x00000108
      NoSuchSubscriptionFound = 286, // 0x0000011E
      CallbackUrlIsAbsentOrIncorrect = 293, // 0x00000125
      NoSubscriptionCouldBeDeleted = 294, // 0x00000126
      CommentAbsentOrIncorrect = 304, // 0x00000130
      AnUnknownErrorOccured = 2555, // 0x000009FB
    }

    public struct myAutoMeasures
    {
      private System.DateTime _fecha;
      private string _xmlResponse;

      public System.DateTime fecha
      {
        get => this._fecha;
        set => this._fecha = value;
      }

      public string xmlResponse
      {
        get => this._xmlResponse;
        set => this._xmlResponse = value;
      }

      public myAutoMeasures(ref string fecha, ref string xmlResponse)
        : this()
      {
        this._fecha = Conversions.ToDate(fecha);
        this._xmlResponse = xmlResponse;
      }
    }
  }
}
