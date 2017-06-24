Imports System.Data.SqlClient
Public Class fContacto
	Inherits Conexion
	Dim _cmd As New SqlCommand
	Public Function Validacion(ByVal dts As vContacto) As Boolean
		Try
			ConexionA()
			_cmd = New SqlCommand("sp_iniContacto") : _cmd.CommandType = CommandType.StoredProcedure
			_cmd.Connection = Cnn : _cmd.Parameters.AddWithValue("@usuContacto", dts.GUsuario) : _cmd.Parameters.AddWithValue("@pass", dts.GPass)
			Dim dr As SqlDataReader : dr = _cmd.ExecuteReader()
			If dr.HasRows Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox("asd" + ex.Message)
			Return False
		Finally
			Desconexion()
		End Try
	End Function
	'ReadOnly _conexion As New Conexion
	'Public Function Validacion(ByVal usu As String, ByVal pass As String) As Integer
	'	Dim result As Integer = 1 : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_iniContacto") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@usuContacto", usu)
	'		da.SelectCommand.Parameters.AddWithValue("@pass", pass) : da.SelectCommand.Connection.Open()
	'		dr = da.SelectCommand.ExecuteReader
	'		If dr.Read Then
	'			result = 0
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Shared Function IdUsuario(ByVal usuContacto As String) As String
	'	Dim result As String = "" : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mIdContacto") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@usuContacto", usuContacto)
	'		da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		If dr.Read Then
	'			result = dr.GetInt32(0)
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Function Mostrar() As ArrayList
	'	Dim result As New ArrayList:Dim da As New SqlDataAdapter():Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mContacto") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		While dr.Read
	'			result.Add(dr.GetString(0))
	'		End While
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Function InsertaCxA(ByVal usuario As String, ByVal idArchivo As Integer) As Integer
	'	Dim result As Integer = 1 : Dim da As New SqlDataAdapter()
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_iCXA") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@idContacto", IdUsuario(usuario))
	'		da.SelectCommand.Parameters.AddWithValue("@idArchivo", idArchivo) : da.SelectCommand.Connection.Open()
	'		If (da.SelectCommand.ExecuteNonQuery() > 0) Then
	'			result = 0
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function



	'Public Function Validacion(ByVal dts As vContacto) As Boolean
	'	Try
	'		Conexion() : _cmd = New SqlCommand("sp_iniContacto") : _cmd.CommandType = CommandType.StoredProcedure
	'		_cmd.Connection = Cnn : _cmd.Parameters.AddWithValue("@usuContacto", dts.GUsuario) : _cmd.Parameters.AddWithValue("@pass", dts.GPass)
	'		Dim dr As SqlDataReader : dr = _cmd.ExecuteReader
	'		If dr.HasRows = True Then
	'			Return True
	'		Else
	'			Return False
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'		Return False
	'	End Try
	'End Function
End Class
