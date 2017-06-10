Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Xml.Serialization
Imports DevExpress.XtraBars

Public Class frmMenu
	Private dt As New DataTable : Dim MyDataAdapter As New SqlDataAdapter()
	Dim WithEvents WinSockServer1 As New WinSockServer()
	Private demo As Thread = Nothing
	Private demo1 As Thread = Nothing
	Private demo2 As Thread = Nothing
	Dim _ip1, _ip2 As String
	Dim _texto As String
	Dim _valor1 As String
	Dim _valor2 As String
	Dim _valor3 As String
	Dim _respuesta As String
	Public Property Encrip As Md5_3Ds = New Md5_3Ds
	Delegate Sub SetTextCallback(ByVal [text1] As String)
	Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rbControl.Minimized = True
		dataSBitacora.AutoResizeColumns()
	End Sub
	'Private Sub txtPuerto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPuerto.ItemPress
	'	Select Case e.KeyData
	'		Case Keys.Enter
	'			btnConectar.PerformClick()
	'			e.Handled = False
	'	End Select
	'End Sub
	Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.ItemClick
		If txtPuerto.EditValue <> "" Then
			If btnConectar.Caption = "Establecer" Then
				With WinSockServer1
					.PuertoDeEscucha = txtPuerto.EditValue
					.Escuchar()
				End With
				lblEstado.Caption = "Puerto " & txtPuerto.EditValue & " ha sido habilitado"
				txtPuerto.Enabled = False
				btnConectar.Caption = "Cerrar"
				btnConectar.LargeGlyph = My.Resources.Cancel
			ElseIf btnConectar.Caption = "Cerrar" Then
				Try
					WinSockServer1.Cerrar()
					lblEstado.Caption = "Puerto " & txtPuerto.EditValue & " ha sido deshabilitado"
					For i = 0 To 10
						WinSockServer1.Cerrar()
					Next
				Catch ex As Exception
					MsgBox("1 " & ex.Message)
				End Try
				MsgBox("Se ha cerrado la conexion con el puerto " & txtPuerto.EditValue)
				btnConectar.Caption = "Establecer"
				btnConectar.LargeGlyph = My.Resources.Convert
				txtPuerto.Enabled = True
				txtPuerto.EditValue = ""
			End If
		Else
			MsgBox("Favor ingrese el numero de puerto")
		End If

		''If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Application.CurrentCulture.NumberFormat.NumberDecimalSeparator) Or Char.IsControl(e.KeyChar)) Then
		''e.Handled = True
		''End If
	End Sub
	Private Sub txtPuerto_EditValueChanged(sender As Object, e As EventArgs) Handles txtPuerto.ItemPress
		'If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Application.CurrentCulture.NumberFormat.NumberDecimalSeparator) Or Char.IsControl(e.KeyChar)) Then
		'e.Handled = True
		'End If
	End Sub
	Private Sub rbControl_Click(sender As Object, e As EventArgs) Handles rbControl.Click
		rbControl.Minimized = False
		If rbControl.SelectedPage.Text = "Comunicacion" Then
			pnlComs.Visible = True
			pnlBitacora.Visible = False
		ElseIf rbControl.SelectedPage.Text = "Bitacora" Then
			pnlBitacora.Visible = True
			pnlComs.Visible = False
		End If
	End Sub
	Private Sub btnGenerar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnGenerar.ItemClick
		MostrarBitacora()
	End Sub
	Private Sub MostrarBitacora()
		Dim dt As DataTable
		Try
			Dim func As New fBitacora
			dt = func.mostrar
			dataSBitacora.DataSource = dt
			dataSBitacora.AutoResizeColumns()
			dataSBitacora.Columns.Item("idBitacora").Visible = False
			dataSBitacora.Update()
			dataSBitacora.Refresh()

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub ThreadProcSafe()
		SetText(_ip1)
	End Sub
	Private Sub SetText(ByVal [text1] As String)
		' InvokeRequired required compares the thread ID of the
		' calling thread to the thread ID of the creating thread.
		' If these threads are different, it returns true.
		If ListaCon.InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf SetText)
			Invoke(d, New Object() {[text1]})
		Else
			ListaCon.Items.Add(_ip1)
		End If
	End Sub
	Private Sub ThreadProcSafe1()
		SetText1(_texto)
	End Sub
	Private Sub SetText1(ByVal [text1])
		Dim xmldes As String
		If rtxtRecibido.InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf SetText1)
			Invoke(d, New Object() {[text1]})
		Else
			rtxtRecibido.Text = _texto
			xmldes = Encrip.DecryptString(rtxtRecibido.Text)
			rtxtXMLR.Text = (xmldes)
			Deserializar(rtxtXMLR.Text)
			If Deserializar(rtxtXMLR.Text) = "Login" Then
				Dim dtsC As New vContacto
				Dim funC As New fContacto
				dtsC.GUsuario = _valor1
				dtsC.GPass = _valor2
				If funC.Validacion(dtsC) Then
					WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, "Login")))
					rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, "Login")
					rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
					rtxtMD5Recibido.Text = _valor2
					rtxtMD5Enviado.Text = _valor2
					LogBitacora("Login")
				Else
					WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, "nulo")))
					rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, "nulo")
					rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
					rtxtMD5Recibido.Text = _valor2
					rtxtMD5Enviado.Text = _valor2
				End If
			ElseIf Deserializar(rtxtXMLR.Text) = "Archivo" Then
				'MsgBox(_nombre&_tipo&_tam&_fechaCrea)
				rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, "Archivo")
				rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
				Try
					Dim dts As New vArchivo : Dim func As New fArchivo : dts.gNomArchivo = _valor2 : dts.gArchivo = _valor3
					If func.insertar(dts) Then
						LogBitacora("Archivo")
						'MessageBox.Show("Registro correcto", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Information)
						'Mostrar()
					Else '	MessageBox.Show("No se pudo realizar el registro, intente de nuevo", "Guardando", MessageBoxButtons.OK, MessageBoxIcon.Error)
						'Mostrar()
					End If
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try
			End If
			'rtxtXMLE.Text = _usuario & _pass

		End If
	End Sub
	Private Sub ThreadProcSafe2()
		SetText2(_ip2)
	End Sub
	Private Sub SetText2(ByVal [text2] As String)
		' InvokeRequired required compares the thread ID of the
		' calling thread to the thread ID of the creating thread.
		' If these threads are different, it returns true.
		If listaDes.InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf SetText2)
			Invoke(d, New Object() {[text2]})
		Else
			listaDes.Items.Add(_ip2)
		End If
	End Sub
	Private Sub WinSockServer_NuevaConexion(ByVal idTerminal As IPEndPoint) Handles WinSockServer1.NuevaConexion
		_ip1 = idTerminal.Address.ToString & ":" & idTerminal.Port.ToString
		demo = New Thread(New ThreadStart(AddressOf ThreadProcSafe)):
		demo.Start()
		lblEstado.Caption = "Se ha conectado la IP " & idTerminal.Address.ToString & ", Puerto " & idTerminal.Port
	End Sub
	Private Sub WinSockServer_ConexionTerminada(ByVal idTerminal As IPEndPoint) Handles WinSockServer1.ConexionTerminada
		_ip2 = idTerminal.Address.ToString & ":" & idTerminal.Port.ToString
		demo2 = New Thread(New ThreadStart(AddressOf ThreadProcSafe2)):demo2.Start()
		lblEstado.Caption = "Se ha desconectado la IP " & idTerminal.Address.ToString & ", Puerto " & idTerminal.Port
	End Sub
	Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As IPEndPoint, ByVal Datos As String) Handles WinSockServer1.DatosRecibidos
		_texto = Datos:demo1 = New Thread(New ThreadStart(AddressOf ThreadProcSafe1)):demo1.Start()
	End Sub
	Private Sub frmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		End
	End Sub
	Public Function Deserializar(ByVal str As String)
		Dim serializer1 As New XmlSerializer(GetType(XML))
		Dim items1 As XML
		Using reader1 As New StringReader(str)
			items1 = CType(serializer1.Deserialize(reader1), XML)
		End Using
		_valor1 = items1.valor1 : _valor2 = items1.valor2 : _valor3 = items1.valor3 : _respuesta = items1.Funcion
		Return _respuesta
	End Function
	Public Sub LogBitacora(ByVal accion As String)
		Dim accionB As String
		Dim dtsB As New vBitacora
		Dim funB As New fBitacora
		accionB = dtsB.Manejo(_valor1, accion, _valor2)
		dtsB.GUsuario = _valor1
		dtsB.Gfecha = DateTime.Now
		dtsB.GAccion = accionB
		funB.Insertar(dtsB)
	End Sub
	Private Sub Mostrar()
		Try
			Dim func As New fArchivo
			dt = func.mostrar
			If dt.Rows.Count <> 0 Then
				'dataListado.DataSource = dt : dataListado.ColumnHeadersVisible = True
			Else
				'dataListado.DataSource = Nothing : dataListado.ColumnHeadersVisible = False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
End Class