Imports System.Data.SqlClient
Public Class fContacto
	Inherits Conexion
	Dim _cmd As New SqlCommand
	Public Function Validacion(ByVal dts As vContacto) As Boolean
		Try
			Conexion() : _cmd = New SqlCommand("sp_iniContacto") : _cmd.CommandType = CommandType.StoredProcedure
			_cmd.Connection = Cnn : _cmd.Parameters.AddWithValue("@usuContacto", dts.GUsuario) : _cmd.Parameters.AddWithValue("@pass", dts.GPass)
			Dim dr As SqlDataReader : dr = _cmd.ExecuteReader
			If dr.HasRows = True Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		Finally
			Desconexion()
		End Try
	End Function
End Class
