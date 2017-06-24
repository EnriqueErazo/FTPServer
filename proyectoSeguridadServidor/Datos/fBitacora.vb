Imports System.Data.SqlClient
Public Class fBitacora
	Inherits Conexion
	Shared ReadOnly Conexion1 As New Conexion
	Dim _cmd As New SqlCommand
	Public Function MostrarS() As DataTable
		Try
			ConexionA() : _cmd = New SqlCommand("sp_mBitacoraComp")
			_cmd.CommandType = CommandType.StoredProcedure : _cmd.Connection = Cnn 'Conexion1.Conexion()
			If _cmd.ExecuteNonQuery Then
				Dim dt As New DataTable : Dim da As New SqlDataAdapter(_cmd) : da.Fill(dt) : Return dt
			Else
				Return Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message) : Return Nothing
		End Try
	End Function
	Public Shared Function MostrarC(ByVal usuario As String, ByVal hash As String, ByVal opcion As String) As List(Of vBitacora)
		Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
		Dim entradas As New List(Of vBitacora)
		Dim bitacora As New vBitacora
		Try
			da.SelectCommand = New SqlCommand("sp_mBitacora")
			da.SelectCommand.CommandType = CommandType.StoredProcedure
			da.SelectCommand.Connection = Conexion1.Conexion()
			'da.SelectCommand.Parameters.AddWithValue("@idContacto", usuario)
			da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
			bitacora.GidUsuario = usuario
			entradas.Add(bitacora)
			While dr.Read
				bitacora = New vBitacora()
				bitacora.GFecha = dr.GetString(3)
				bitacora.GAccion = dr.GetString(2)
				entradas.Add(bitacora)
			End While
			bitacora.GHash = hash
			bitacora.GAccion = opcion
			entradas.Add(bitacora)
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		Return entradas
	End Function
	Public Function Insertar(ByVal dts As vBitacora) As Boolean
		Try
			ConexionA() : _cmd = New SqlCommand("sp_iBitacora")
			_cmd.CommandType = CommandType.StoredProcedure : _cmd.Connection = Cnn 'Conexion1.ConexionA()
			_cmd.Parameters.AddWithValue("@usuContacto", dts.GidUsuario) : _cmd.Parameters.AddWithValue("@accion", dts.GAccion)
			If _cmd.ExecuteNonQuery Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message) : Return False
		End Try
	End Function

	'ReadOnly _conexion As New Conexion : Dim cmd As New SqlCommand
	'Public Function MostrarCliente(ByVal usuario As String) As ArrayList
	'	Dim result As New ArrayList : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mBitacora") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@idContacto", fContacto.IdUsuario(usuario))
	'		da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		While dr.Read
	'			result.Add(New vBitacora(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3), dr.GetInt32(4), dr.GetInt32(5)))
	'		End While
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Function MostrarServidor() As DataTable
	'	Try
	'		If cmd.ExecuteNonQuery Then
	'			Dim dt As New DataTable : Dim da As New SqlDataAdapter(cmd) : da.Fill(dt) : Return dt
	'		Else
	'			Return Nothing
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message) : Return Nothing
	'	End Try
	'End Function
	'Public Sub Insertar(ByVal accion As String, ByVal equipo As String, ByVal idArchivo As Integer, ByVal usuario As String)
	'	Dim da As New SqlDataAdapter()
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_iBitacora") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@accion", accion)
	'		da.SelectCommand.Parameters.AddWithValue("@nomEquipo", equipo) : da.SelectCommand.Parameters.AddWithValue("@idArchivo", idArchivo)
	'		da.SelectCommand.Parameters.AddWithValue("@idContacto", fContacto.IdUsuario(usuario))
	'		da.SelectCommand.Connection.Open() : da.SelectCommand.ExecuteNonQuery()
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'End Sub
End Class
