Imports System.Data.SqlClient
Public Class fArchivo
	Inherits Conexion
	Dim cmd As New SqlCommand
	Public Function mostrar() As DataTable
		Try
			ConexionA() : cmd = New SqlCommand("sp_mArchivo")
			cmd.CommandType = CommandType.StoredProcedure : cmd.Connection = Cnn
			If cmd.ExecuteNonQuery Then
				Dim dt As New DataTable : Dim da As New SqlDataAdapter(cmd) : da.Fill(dt) : Return dt
			Else
				Return Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message) : Return Nothing
		End Try
	End Function
	Public Function Insertar(ByVal dts As vArchivo) As Boolean
		Try
			ConexionA() : cmd = New SqlCommand("sp_iArchivo")
			cmd.CommandType = CommandType.StoredProcedure : cmd.Connection = Cnn : cmd.Parameters.AddWithValue("@usuContacto", dts.GContacto)
			cmd.Parameters.AddWithValue("@nomArchivo", dts.GNomArchivo) : cmd.Parameters.AddWithValue("@Archivo", dts.GContenido)
			If cmd.ExecuteNonQuery Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
	End Function
	'ReadOnly _conexion As New Conexion
	'Public Function Mostrar(ByVal id As Integer) As ArrayList
	'	Dim result As New ArrayList : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mArchivo") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@idArchivo", id)
	'		da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		While dr.Read
	'			result.Add(dr.GetString(0)) : result.Add(dr.GetString(1)) : result.Add(dr.GetString(2))
	'		End While
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result ' retorna el resultado
	'End Function
	'Public Function IdArchivo(ByVal arc As vArchivo) As Integer
	'	Dim result As Integer = 0 : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mIdArchivo") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@nomArchivo", arc.GNomArchivo)
	'		da.SelectCommand.Parameters.AddWithValue("@extension", arc.GExtension)
	'		da.SelectCommand.Parameters.AddWithValue("@idContacto", fContacto.IdUsuario(arc.GContacto))
	'		da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		If dr.Read Then
	'			result = dr.GetInt32(0)
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Function Insertar(ByVal arc As vArchivo) As Integer
	'	Dim result As Integer = 1 : Dim da As New SqlDataAdapter()
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_iArchivo") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@nomArchivo", arc.GNomArchivo)
	'		da.SelectCommand.Parameters.AddWithValue("@extension", arc.GExtension) : da.SelectCommand.Parameters.AddWithValue("@tamArchivo", arc.GTamano)
	'		da.SelectCommand.Parameters.AddWithValue("@Archivo", arc.GContenido)
	'		da.SelectCommand.Parameters.AddWithValue("@idContacto", fContacto.IdUsuario(arc.GContacto)) : da.SelectCommand.Connection.Open()
	'		MsgBox("11 " & arc.GNomArchivo & " " & arc.GExtension & " " & arc.GTamano & " " & arc.GContenido & " " & fContacto.IdUsuario(arc.GContacto))
	'		If (da.SelectCommand.ExecuteNonQuery()) > 0 Then
	'			result = 0
	'		End If
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Function MostrarArcXCon(ByVal contacto As String) As ArrayList
	'	Dim result As New ArrayList : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mCXA") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion()
	'		da.SelectCommand.Parameters.AddWithValue("@idContacto", fContacto.IdUsuario(contacto))
	'		da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		While dr.Read
	'			result.Add(New vArchivo(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetDateTime(4), dr.GetInt32(5)))
	'		End While
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
	'Public Function MostrarCompartidos(ByVal id As Integer) As ArrayList
	'	Dim result As New ArrayList : Dim da As New SqlDataAdapter() : Dim dr As SqlDataReader
	'	Try
	'		da.SelectCommand = New SqlCommand("sp_mCompartidos") : da.SelectCommand.CommandType = CommandType.StoredProcedure
	'		da.SelectCommand.Connection = _conexion.Conexion() : da.SelectCommand.Parameters.AddWithValue("@idArchivo", id)
	'		da.SelectCommand.Connection.Open() : dr = da.SelectCommand.ExecuteReader
	'		While dr.Read
	'			result.Add(dr.GetString(0))
	'		End While
	'	Catch ex As Exception
	'		MsgBox(ex.Message)
	'	End Try
	'	Return result
	'End Function
End Class
