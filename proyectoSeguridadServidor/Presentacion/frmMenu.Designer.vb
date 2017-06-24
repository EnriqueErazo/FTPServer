<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
		Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
		Me.pnlComs = New DevExpress.XtraEditors.PanelControl()
		Me.listaDes = New System.Windows.Forms.ListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblMensajeE = New System.Windows.Forms.Label()
		Me.lblXMLE = New System.Windows.Forms.Label()
		Me.lblMensajeR = New System.Windows.Forms.Label()
		Me.lblXMLR = New System.Windows.Forms.Label()
		Me.rtxtXMLE = New System.Windows.Forms.RichTextBox()
		Me.ListaCon = New System.Windows.Forms.ListBox()
		Me.rtxtMD5Recibido = New System.Windows.Forms.RichTextBox()
		Me.rtxtMD5Enviado = New System.Windows.Forms.RichTextBox()
		Me.rtxtEnviado = New System.Windows.Forms.RichTextBox()
		Me.rtxtRecibido = New System.Windows.Forms.RichTextBox()
		Me.rtxtXMLR = New System.Windows.Forms.RichTextBox()
		Me.rbmContactos = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.btnGenerar = New DevExpress.XtraBars.BarButtonItem()
		Me.rbmComs = New DevExpress.XtraBars.Ribbon.RibbonPage()
		Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
		Me.txtPuerto = New DevExpress.XtraBars.BarEditItem()
		Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
		Me.btnConectar = New DevExpress.XtraBars.BarButtonItem()
		Me.lblEstado = New DevExpress.XtraBars.BarStaticItem()
		Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
		Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
		Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
		Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
		Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
		Me.rbControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
		Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
		Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
		Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
		Me.pnlBitacora = New DevExpress.XtraEditors.PanelControl()
		Me.dataSBitacora = New System.Windows.Forms.DataGridView()
		CType(Me.pnlComs, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlComs.SuspendLayout()
		CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.rbControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pnlBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlBitacora.SuspendLayout()
		CType(Me.dataSBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'pnlComs
		'
		Me.pnlComs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pnlComs.Appearance.BackColor = System.Drawing.SystemColors.Control
		Me.pnlComs.Appearance.BackColor2 = System.Drawing.SystemColors.Control
		Me.pnlComs.Appearance.BorderColor = System.Drawing.Color.Red
		Me.pnlComs.Appearance.ForeColor = System.Drawing.SystemColors.Control
		Me.pnlComs.Appearance.Options.UseBackColor = True
		Me.pnlComs.Appearance.Options.UseBorderColor = True
		Me.pnlComs.Appearance.Options.UseForeColor = True
		Me.pnlComs.Controls.Add(Me.listaDes)
		Me.pnlComs.Controls.Add(Me.Label2)
		Me.pnlComs.Controls.Add(Me.Label1)
		Me.pnlComs.Controls.Add(Me.lblMensajeE)
		Me.pnlComs.Controls.Add(Me.lblXMLE)
		Me.pnlComs.Controls.Add(Me.lblMensajeR)
		Me.pnlComs.Controls.Add(Me.lblXMLR)
		Me.pnlComs.Controls.Add(Me.rtxtXMLE)
		Me.pnlComs.Controls.Add(Me.ListaCon)
		Me.pnlComs.Controls.Add(Me.rtxtMD5Recibido)
		Me.pnlComs.Controls.Add(Me.rtxtMD5Enviado)
		Me.pnlComs.Controls.Add(Me.rtxtEnviado)
		Me.pnlComs.Controls.Add(Me.rtxtRecibido)
		Me.pnlComs.Controls.Add(Me.rtxtXMLR)
		Me.pnlComs.Location = New System.Drawing.Point(12, 150)
		Me.pnlComs.LookAndFeel.SkinName = "DevExpress Dark Style"
		Me.pnlComs.LookAndFeel.UseWindowsXPTheme = True
		Me.pnlComs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.pnlComs.Name = "pnlComs"
		Me.pnlComs.Size = New System.Drawing.Size(657, 533)
		Me.pnlComs.TabIndex = 1
		Me.pnlComs.Visible = False
		'
		'listaDes
		'
		Me.listaDes.BackColor = System.Drawing.SystemColors.Control
		Me.listaDes.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.listaDes.FormattingEnabled = True
		Me.listaDes.ItemHeight = 16
		Me.listaDes.Items.AddRange(New Object() {"Usuarios desconectados"})
		Me.listaDes.Location = New System.Drawing.Point(334, 429)
		Me.listaDes.Name = "listaDes"
		Me.listaDes.Size = New System.Drawing.Size(323, 96)
		Me.listaDes.TabIndex = 16
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label2.Location = New System.Drawing.Point(334, 335)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(89, 16)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "MD5 Recibido"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Label1.Location = New System.Drawing.Point(5, 335)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 16)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "MD5 Enviado"
		'
		'lblMensajeE
		'
		Me.lblMensajeE.AutoSize = True
		Me.lblMensajeE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.lblMensajeE.Location = New System.Drawing.Point(334, 179)
		Me.lblMensajeE.Name = "lblMensajeE"
		Me.lblMensajeE.Size = New System.Drawing.Size(93, 16)
		Me.lblMensajeE.TabIndex = 13
		Me.lblMensajeE.Text = "Trama Enviada"
		'
		'lblXMLE
		'
		Me.lblXMLE.AutoSize = True
		Me.lblXMLE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.lblXMLE.Location = New System.Drawing.Point(5, 179)
		Me.lblXMLE.Name = "lblXMLE"
		Me.lblXMLE.Size = New System.Drawing.Size(82, 16)
		Me.lblXMLE.TabIndex = 12
		Me.lblXMLE.Text = "XML Enviado"
		'
		'lblMensajeR
		'
		Me.lblMensajeR.AutoSize = True
		Me.lblMensajeR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.lblMensajeR.Location = New System.Drawing.Point(334, 4)
		Me.lblMensajeR.Name = "lblMensajeR"
		Me.lblMensajeR.Size = New System.Drawing.Size(98, 16)
		Me.lblMensajeR.TabIndex = 11
		Me.lblMensajeR.Text = "Trama Recibida"
		'
		'lblXMLR
		'
		Me.lblXMLR.AutoSize = True
		Me.lblXMLR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.lblXMLR.Location = New System.Drawing.Point(5, 4)
		Me.lblXMLR.Name = "lblXMLR"
		Me.lblXMLR.Size = New System.Drawing.Size(87, 16)
		Me.lblXMLR.TabIndex = 6
		Me.lblXMLR.Text = "XML Recibido"
		'
		'rtxtXMLE
		'
		Me.rtxtXMLE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxtXMLE.BackColor = System.Drawing.SystemColors.Control
		Me.rtxtXMLE.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtXMLE.Location = New System.Drawing.Point(5, 199)
		Me.rtxtXMLE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtxtXMLE.Name = "rtxtXMLE"
		Me.rtxtXMLE.ReadOnly = True
		Me.rtxtXMLE.Size = New System.Drawing.Size(323, 132)
		Me.rtxtXMLE.TabIndex = 10
		Me.rtxtXMLE.Text = ""
		'
		'ListaCon
		'
		Me.ListaCon.BackColor = System.Drawing.SystemColors.Control
		Me.ListaCon.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.ListaCon.FormattingEnabled = True
		Me.ListaCon.ItemHeight = 16
		Me.ListaCon.Items.AddRange(New Object() {"Usuarios conectados"})
		Me.ListaCon.Location = New System.Drawing.Point(5, 429)
		Me.ListaCon.Name = "ListaCon"
		Me.ListaCon.Size = New System.Drawing.Size(323, 96)
		Me.ListaCon.TabIndex = 9
		'
		'rtxtMD5Recibido
		'
		Me.rtxtMD5Recibido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxtMD5Recibido.BackColor = System.Drawing.SystemColors.Control
		Me.rtxtMD5Recibido.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtMD5Recibido.Location = New System.Drawing.Point(334, 355)
		Me.rtxtMD5Recibido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtxtMD5Recibido.Name = "rtxtMD5Recibido"
		Me.rtxtMD5Recibido.ReadOnly = True
		Me.rtxtMD5Recibido.Size = New System.Drawing.Size(318, 68)
		Me.rtxtMD5Recibido.TabIndex = 8
		Me.rtxtMD5Recibido.Text = ""
		'
		'rtxtMD5Enviado
		'
		Me.rtxtMD5Enviado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxtMD5Enviado.BackColor = System.Drawing.SystemColors.Control
		Me.rtxtMD5Enviado.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtMD5Enviado.Location = New System.Drawing.Point(5, 355)
		Me.rtxtMD5Enviado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtxtMD5Enviado.Name = "rtxtMD5Enviado"
		Me.rtxtMD5Enviado.ReadOnly = True
		Me.rtxtMD5Enviado.Size = New System.Drawing.Size(323, 68)
		Me.rtxtMD5Enviado.TabIndex = 7
		Me.rtxtMD5Enviado.Text = ""
		'
		'rtxtEnviado
		'
		Me.rtxtEnviado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxtEnviado.BackColor = System.Drawing.SystemColors.Control
		Me.rtxtEnviado.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtEnviado.Location = New System.Drawing.Point(334, 199)
		Me.rtxtEnviado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtxtEnviado.Name = "rtxtEnviado"
		Me.rtxtEnviado.ReadOnly = True
		Me.rtxtEnviado.Size = New System.Drawing.Size(318, 132)
		Me.rtxtEnviado.TabIndex = 6
		Me.rtxtEnviado.Text = ""
		'
		'rtxtRecibido
		'
		Me.rtxtRecibido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxtRecibido.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtRecibido.Location = New System.Drawing.Point(334, 24)
		Me.rtxtRecibido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtxtRecibido.Name = "rtxtRecibido"
		Me.rtxtRecibido.ReadOnly = True
		Me.rtxtRecibido.Size = New System.Drawing.Size(318, 151)
		Me.rtxtRecibido.TabIndex = 5
		Me.rtxtRecibido.Text = ""
		'
		'rtxtXMLR
		'
		Me.rtxtXMLR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtxtXMLR.BackColor = System.Drawing.SystemColors.Control
		Me.rtxtXMLR.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.rtxtXMLR.Location = New System.Drawing.Point(5, 24)
		Me.rtxtXMLR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rtxtXMLR.Name = "rtxtXMLR"
		Me.rtxtXMLR.ReadOnly = True
		Me.rtxtXMLR.Size = New System.Drawing.Size(323, 151)
		Me.rtxtXMLR.TabIndex = 0
		Me.rtxtXMLR.Text = ""
		'
		'rbmContactos
		'
		Me.rbmContactos.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
		Me.rbmContactos.Name = "rbmContactos"
		Me.rbmContactos.Text = "Bitacora"
		'
		'RibbonPageGroup2
		'
		Me.RibbonPageGroup2.ItemLinks.Add(Me.btnGenerar)
		Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
		Me.RibbonPageGroup2.Text = "Bitacora"
		'
		'btnGenerar
		'
		Me.btnGenerar.Caption = "Generar Bitacora"
		Me.btnGenerar.Glyph = CType(resources.GetObject("btnGenerar.Glyph"), System.Drawing.Image)
		Me.btnGenerar.Id = 20
		Me.btnGenerar.LargeGlyph = CType(resources.GetObject("btnGenerar.LargeGlyph"), System.Drawing.Image)
		Me.btnGenerar.Name = "btnGenerar"
		'
		'rbmComs
		'
		Me.rbmComs.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
		Me.rbmComs.Name = "rbmComs"
		Me.rbmComs.Text = "Comunicacion"
		'
		'RibbonPageGroup1
		'
		Me.RibbonPageGroup1.ItemLinks.Add(Me.txtPuerto)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.btnConectar)
		Me.RibbonPageGroup1.ItemLinks.Add(Me.lblEstado)
		Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
		Me.RibbonPageGroup1.ShowCaptionButton = False
		Me.RibbonPageGroup1.Text = "Conexion"
		'
		'txtPuerto
		'
		Me.txtPuerto.Caption = "Puerto"
		Me.txtPuerto.Edit = Me.RepositoryItemTextEdit4
		Me.txtPuerto.Id = 13
		Me.txtPuerto.Name = "txtPuerto"
		'
		'RepositoryItemTextEdit4
		'
		Me.RepositoryItemTextEdit4.AutoHeight = False
		Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.RepositoryItemTextEdit4.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.RepositoryItemTextEdit4.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
		Me.RepositoryItemTextEdit4.Mask.IgnoreMaskBlank = False
		Me.RepositoryItemTextEdit4.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(32)
		Me.RepositoryItemTextEdit4.Mask.SaveLiteral = False
		Me.RepositoryItemTextEdit4.MaxLength = 4
		Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
		Me.RepositoryItemTextEdit4.ValidateOnEnterKey = True
		'
		'btnConectar
		'
		Me.btnConectar.Caption = "Establecer"
		Me.btnConectar.Glyph = CType(resources.GetObject("btnConectar.Glyph"), System.Drawing.Image)
		Me.btnConectar.Id = 14
		Me.btnConectar.LargeGlyph = CType(resources.GetObject("btnConectar.LargeGlyph"), System.Drawing.Image)
		Me.btnConectar.Name = "btnConectar"
		'
		'lblEstado
		'
		Me.lblEstado.Caption = "Estado"
		Me.lblEstado.Id = 21
		Me.lblEstado.Name = "lblEstado"
		Me.lblEstado.TextAlignment = System.Drawing.StringAlignment.Near
		'
		'RepositoryItemMemoEdit1
		'
		Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
		'
		'RepositoryItemButtonEdit2
		'
		Me.RepositoryItemButtonEdit2.AutoHeight = False
		Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Establecer", Nothing, Nothing, True)})
		Me.RepositoryItemButtonEdit2.MaxLength = 4
		Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
		'
		'RepositoryItemTextEdit1
		'
		Me.RepositoryItemTextEdit1.AutoHeight = False
		Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
		'
		'RepositoryItemButtonEdit1
		'
		Me.RepositoryItemButtonEdit1.AutoHeight = False
		Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
		Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
		'
		'RepositoryItemToggleSwitch1
		'
		Me.RepositoryItemToggleSwitch1.AutoHeight = False
		Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
		Me.RepositoryItemToggleSwitch1.OffText = "Off"
		Me.RepositoryItemToggleSwitch1.OnText = "On"
		'
		'RepositoryItemTextEdit2
		'
		Me.RepositoryItemTextEdit2.AutoHeight = False
		Me.RepositoryItemTextEdit2.MaxLength = 4
		Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
		'
		'rbControl
		'
		Me.rbControl.ExpandCollapseItem.Id = 0
		Me.rbControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.rbControl.ExpandCollapseItem, Me.txtPuerto, Me.btnConectar, Me.btnGenerar, Me.lblEstado})
		Me.rbControl.Location = New System.Drawing.Point(0, 0)
		Me.rbControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.rbControl.MaxItemId = 22
		Me.rbControl.Name = "rbControl"
		Me.rbControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rbmComs, Me.rbmContactos})
		Me.rbControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemToggleSwitch1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemButtonEdit2, Me.RepositoryItemTextEdit4, Me.RepositoryItemMemoEdit1})
		Me.rbControl.Size = New System.Drawing.Size(681, 142)
		'
		'RepositoryItemTextEdit3
		'
		Me.RepositoryItemTextEdit3.AutoHeight = False
		Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
		'
		'BarButtonItem1
		'
		Me.BarButtonItem1.Caption = "Establecer"
		Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
		Me.BarButtonItem1.Id = -1
		Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
		Me.BarButtonItem1.Name = "BarButtonItem1"
		'
		'BarButtonItem2
		'
		Me.BarButtonItem2.Id = -1
		Me.BarButtonItem2.Name = "BarButtonItem2"
		'
		'pnlBitacora
		'
		Me.pnlBitacora.Controls.Add(Me.dataSBitacora)
		Me.pnlBitacora.Location = New System.Drawing.Point(12, 150)
		Me.pnlBitacora.Name = "pnlBitacora"
		Me.pnlBitacora.Size = New System.Drawing.Size(657, 534)
		Me.pnlBitacora.TabIndex = 4
		Me.pnlBitacora.Visible = False
		'
		'dataSBitacora
		'
		Me.dataSBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataSBitacora.Location = New System.Drawing.Point(5, 5)
		Me.dataSBitacora.Name = "dataSBitacora"
		Me.dataSBitacora.Size = New System.Drawing.Size(647, 522)
		Me.dataSBitacora.TabIndex = 0
		'
		'frmMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(681, 696)
		Me.Controls.Add(Me.rbControl)
		Me.Controls.Add(Me.pnlComs)
		Me.Controls.Add(Me.pnlBitacora)
		Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(697, 726)
		Me.Name = "frmMenu"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Servidor"
		CType(Me.pnlComs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlComs.ResumeLayout(False)
		Me.pnlComs.PerformLayout()
		CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.rbControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pnlBitacora, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlBitacora.ResumeLayout(False)
		CType(Me.dataSBitacora, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents pnlComs As DevExpress.XtraEditors.PanelControl
	Friend WithEvents rbmContactos As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents rbmComs As DevExpress.XtraBars.Ribbon.RibbonPage
	Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
	Friend WithEvents rbControl As DevExpress.XtraBars.Ribbon.RibbonControl
	Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents txtPuerto As DevExpress.XtraBars.BarEditItem
	Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
	Friend WithEvents btnConectar As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
	Friend WithEvents rtxtXMLR As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxtRecibido As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxtEnviado As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxtMD5Recibido As System.Windows.Forms.RichTextBox
	Friend WithEvents rtxtMD5Enviado As System.Windows.Forms.RichTextBox
	Friend WithEvents pnlBitacora As DevExpress.XtraEditors.PanelControl
	Friend WithEvents dataSBitacora As System.Windows.Forms.DataGridView
	Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	Friend WithEvents btnGenerar As DevExpress.XtraBars.BarButtonItem
	Friend WithEvents ListaCon As System.Windows.Forms.ListBox
	Friend WithEvents rtxtXMLE As System.Windows.Forms.RichTextBox
	Friend WithEvents lblEstado As DevExpress.XtraBars.BarStaticItem
	Friend WithEvents lblXMLR As System.Windows.Forms.Label
	Friend WithEvents lblMensajeR As System.Windows.Forms.Label
	Friend WithEvents lblXMLE As System.Windows.Forms.Label
	Friend WithEvents lblMensajeE As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents listaDes As System.Windows.Forms.ListBox
End Class