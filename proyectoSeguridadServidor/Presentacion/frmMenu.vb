Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Xml.Serialization
Imports DevExpress.XtraBars

Public Class frmMenu
	Private dt As New DataTable : Dim _myDataAdapter As New SqlDataAdapter() : Dim WithEvents WinSockServer1 As New WinSockServer()
	Private _demo As Thread = Nothing : Private _demo1 As Thread = Nothing : Private _demo2 As Thread = Nothing
	Dim _ip1, _ip2, _texto As String
	Dim _valor1 As String : Dim _valor2 As String : Dim _valor3 As String : Dim _hash As String : Dim _respuesta As String
	Public Property Encrip As Md5_3Ds = New Md5_3Ds
	Delegate Sub SetTextCallback(ByVal [text1] As String)
	Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		rbControl.Minimized = True
		dataSBitacora.AutoResizeColumns()
	End Sub
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
	Private Sub MostrarBitacora() 'ByVal bi As ArrayList)
		Try
			Dim func As New fBitacora : dataSBitacora.DataSource = func.MostrarS
			dataSBitacora.AutoResizeColumns() : dataSBitacora.Columns.Item("idBitacora").Visible = False
			dataSBitacora.Update() : dataSBitacora.Refresh()
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
		Dim cadena As String
		Dim xmldes As String
		If rtxtRecibido.InvokeRequired Then
			Dim d As New SetTextCallback(AddressOf SetText1)
			Invoke(d, New Object() {[text1]})
		Else
			rtxtRecibido.Text = _texto
			xmldes = Encrip.DecryptString(rtxtRecibido.Text)
			rtxtXMLR.Text = (xmldes)
			Deserializar(xmldes)
			Dim tiempo = TimeOfDay.Hour().ToString() & ":" & TimeOfDay.Minute().ToString()
			Dim unlock As String
			Using md5Hash As MD5 = MD5.Create()
				If Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo)) = _hash Then
					If Deserializar(rtxtXMLR.Text) = "Login" Then
						Dim dtsC As New vContacto
						Dim funC As New fContacto
						dtsC.GUsuario = _valor1
						dtsC.GPass = _valor2
						cadena = ""
						If funC.Validacion(dtsC) Then
							tiempo = TimeOfDay.Hour() & ":" & TimeOfDay.Minute()
							unlock = Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo))
							WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, _valor2, 0, unlock, "Login")))
							rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, unlock, "Login")
							rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
							rtxtMD5Recibido.Text = _hash
							rtxtMD5Enviado.Text = unlock
							LogBitacora("Login")
						Else
							unlock = Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo))
							WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, _valor2, 0, unlock, "Nulo")))
							rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, unlock, "Nulo")
							rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
							rtxtMD5Recibido.Text = _hash
							rtxtMD5Enviado.Text = unlock
						End If
					ElseIf Deserializar(rtxtXMLR.Text) = "Archivo" Then
						tiempo = TimeOfDay.Hour() & ":" & TimeOfDay.Minute()
						unlock = Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo))
						rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, _valor2, _valor3, unlock, "Archivo")
						rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
						rtxtMD5Recibido.Text = _hash
						rtxtMD5Enviado.Text = unlock
						Try
							Dim dtsA As New vArchivo : Dim funA As New fArchivo : dtsA.GContacto = _valor1 : dtsA.GNomArchivo = _valor2 : dtsA.GContenido = _valor3
							If funA.insertar(dtsA) Then
								LogBitacora("Archivo")
								'MsgBox("Registro correcto")
								'Mostrar()
							Else
								MsgBox("No se pudo realizar el registro, intente de nuevo")
								'Mostrar()
							End If
						Catch ex As Exception
							MsgBox(ex.Message)
						End Try
					ElseIf Deserializar(rtxtXMLR.Text) = "Bitacora" Then
						Try
							tiempo = TimeOfDay.Hour() & ":" & TimeOfDay.Minute()
							unlock = Encrip.Md5Encryta(md5Hash, ManejoXml.Key(tiempo))
							'WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, SendBitacora(Mostrar()).ToString(), 0, unlock, "Bitacora")))
							MsgBox("1")
							WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SeriBitacora(_valor1, _valor2, _valor3, unlock, "Bitacora")))
							MsgBox("2")
							'WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml()))
							'rtxtXMLE.Text = ManejoXml.SerialiazarXml()
							rtxtXMLE.Text = ManejoXml.SeriBitacora(_valor1, _valor2, _valor3, unlock, "Bitacora")
							MsgBox("3")
							rtxtEnviado.Text = Encrip.EncryptString(rtxtXMLE.Text)
							MsgBox("4")
							rtxtMD5Recibido.Text = _valor3
							rtxtMD5Enviado.Text = unlock



							''''''''rtxtXMLE.Text = ManejoXml.SerialiazarXml(_valor1, lstFecha.Text, lstAccion.Text, unlock, "Bitacora")
							'WinSockServer.EnviarDatos(Encrip.EncryptString(ManejoXml.SerialiazarXml(_valor1, lstFecha.Text, _valor3, "Bitacora")))
							'WinSockServer.EnviarDatos(rtxtEnviado.Text)
							LogBitacora("Bitacora")
						Catch ex As Exception
							MsgBox(ex.Message)
						End Try
					End If
				Else
					MsgBox("Hash esta corrupto 1")
					'rtxtXMLE.Text = _usuario & _pass
				End If
			End Using
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
		_demo = New Thread(New ThreadStart(AddressOf ThreadProcSafe))
		_demo.Start()
		lblEstado.Caption = "Se ha conectado la IP " & idTerminal.Address.ToString & ", Puerto " & idTerminal.Port
	End Sub
	Private Sub WinSockServer_ConexionTerminada(ByVal idTerminal As IPEndPoint) Handles WinSockServer1.ConexionTerminada
		_ip2 = idTerminal.Address.ToString & ":" & idTerminal.Port.ToString
		_demo2 = New Thread(New ThreadStart(AddressOf ThreadProcSafe2)) : _demo2.Start()
		lblEstado.Caption = "Se ha desconectado la IP " & idTerminal.Address.ToString & ", Puerto " & idTerminal.Port
	End Sub
	Private Sub WinSockServer_DatosRecibidos(ByVal IDTerminal As IPEndPoint, ByVal Datos As String) Handles WinSockServer1.DatosRecibidos
		_texto = Datos : _demo1 = New Thread(New ThreadStart(AddressOf ThreadProcSafe1)) : _demo1.Start()
	End Sub
	Private Sub frmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		End
	End Sub
	'Public Function DLogin(ByVal str As String)
	'	Dim serializer1 As New XmlSerializer(GetType(Login))
	'	Dim items1 As XML
	'	Using reader1 As New StringReader(str)
	'		items1 = CType(serializer1.Deserialize(reader1), Login)
	'	End Using
	'	_valor1 = items1.Usuario : _valor2 = items1.Contra : _valor3 = items1.Id : _hash = items1.Hash : _respuesta = items1.Funcion
	'	Return _respuesta
	'End Function
	Public Function Deserializar(ByVal str As String)
		Dim serializer1 As New XmlSerializer(GetType(XML))
		Dim items1 As XML
		Using reader1 As New StringReader(str)
			items1 = CType(serializer1.Deserialize(reader1), XML)
		End Using
		_valor1 = items1.Valor1
		_valor2 = items1.Valor2
		_valor3 = items1.Valor3
		_hash = items1.Hash
		_respuesta = items1.Funcion
		Return _respuesta

	End Function
	Public Sub LogBitacora(ByVal accion As String)
		Dim accionB As String
		Dim dtsB As New vBitacora
		Dim funB As New fBitacora
		accionB = dtsB.Manejo(_valor1, accion, _valor2)
		dtsB.GidUsuario = _valor1
		dtsB.GFecha = DateTime.Now
		dtsB.GAccion = accionB
		MsgBox("1")
		funB.Insertar(dtsB)
	End Sub
	Public Function Mostrar() 
		'Dim str As String = "Data Source=ASUS-KL4UD10; Initial Catalog=proSeguridad; Integrated security=true"
		'Dim conn As New SqlConnection(str)
		''Dim idu = consulta.DatosCliente(usu, pass, 1)
		'Dim comm As New SqlCommand("select * from Bitacora", conn)
		'Dim da As New SqlDataAdapter(comm)

		'Dim dt As New DataTable
		'Dim x As New DataGridView
		'da.Fill(dt)
		'lstFecha.DataSource = dt
		''lstAccion.DataSource = dt
		'lstFecha.DisplayMember = "fechaModif"
		''lstAccion.DisplayMember = "accion"



		Dim result As New ArrayList
		'Dim myDataAdapter As New SqlDataAdapter()
		Dim reader As SqlDataReader
		Try

			'myDataAdapter.SelectCommand = New SqlCommand()
			'myDataAdapter.SelectCommand.Connection = New SqlConnection("Data Source = .; Initial Catalog = proSeguridad; Integrated Security = true")
			'myDataAdapter.SelectCommand.CommandText = "SELECT * FROM Bitacora"
			'myDataAdapter.SelectCommand.Connection.Open() 'se abre la conexion
			'dr = myDataAdapter.SelectCommand.ExecuteReader

			Const cadenaConexion As String = "Data Source = .; Initial Catalog = proSeguridad; Integrated Security = true"
			Dim sqlConnection1 As New SqlConnection(cadenaConexion)
			Dim cmd As New SqlCommand
			cmd.CommandText = "select * from Bitacora"
			cmd.CommandType = CommandType.Text
			cmd.Connection = sqlConnection1
			sqlConnection1.Open()
			reader = cmd.ExecuteReader()

			If reader.HasRows Then
				Do While reader.Read()
					result.Add(reader.GetString(2) _
					  & vbTab & reader.GetDateTime(3))
				Loop
			Else
				Console.WriteLine("vacia")
			End If
			reader.Close()
			sqlConnection1.Close()
			'While dr.Read
			'	result.Add(New vBitacora(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3)))
			'End While
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return result
		'Try
		'	Dim func As New fArchivo
		'	dt = func.mostrar
		'	If dt.Rows.Count <> 0 Then
		'		'dataListado.DataSource = dt : dataListado.ColumnHeadersVisible = True
		'	Else
		'		'dataListado.DataSource = Nothing : dataListado.ColumnHeadersVisible = False
		'	End If

		'Catch ex As Exception
		'	MsgBox(ex.Message)
		'End Try
		'Return lstFecha.Text
	End Function

	Public Function SendBitacora(ByVal bitacora As ArrayList) As String
		Dim ser As XmlSerializer = New XmlSerializer(GetType(XML))
		Dim writer As New StringWriter

		For Each item As String In bitacora
			XML.xml.Add(item)
		Next
		'ser.Serialize(writer, ser)
		'Dim stringReader As StringReader = New StringReader(writer.ToString())
		'Dim deserealize As XmlSerializer = New XmlSerializer(GetType(XML))
		'ser = deserealize.Deserialize(stringReader)
		'writer.Close()





		''Dim dr As SqlDataReader
		''Dim cmd As SqlCommand
		''cmd = New SqlCommand()
		''cmd.Connection = New SqlConnection("Data Source = .; Initial Catalog = proSeguridad; Integrated Security = true")
		''cmd.CommandText = "SELECT * FROM Bitacora"
		''cmd.Connection.Open()	'se abre la conexion
		''dr = cmd.ExecuteReader

		'Static xmlSerializer As XmlSerializer : Static stringWriter As New StringWriter

		''Dim bit As New XML1(_valor1, _valor2, _valor3, _hash, _respuesta)
		'Dim bit As New XML
		'xmlSerializer = New XmlSerializer(GetType(XML))
		'Dim ns As New XmlSerializerNamespaces() : ns.Add("", "") : stringWriter = New StringWriter

		'For Each elemento As String In bitacora.ToString()
		'	XML.xml.Add(elemento)
		'Next
		'xmlSerializer.Serialize(stringWriter, bit, ns) : stringWriter.Close()
		'Return stringWriter.ToString()
		Return bitacora.ToString()
	End Function
End Class