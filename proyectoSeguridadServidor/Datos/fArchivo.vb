Imports System.Data.SqlClient
Public Class fArchivo
	Inherits Conexion
	Dim cmd As New SqlCommand
	Public Function mostrar() As DataTable
		Try
			Conexion() : cmd = New SqlCommand("sp_mArchivo")
			cmd.CommandType = CommandType.StoredProcedure : cmd.Connection = Cnn
			If cmd.ExecuteNonQuery Then
				Dim dt As New DataTable : Dim da As New SqlDataAdapter(cmd) : da.Fill(dt) : Return dt
			Else
				Return Nothing
			End If
		Catch ex As Exception
			MsgBox(ex.Message) : Return Nothing
		Finally
			Desconexion()
		End Try
	End Function
	Public Function insertar(ByVal dts As vArchivo) As Boolean
		Try
			Conexion() : cmd = New SqlCommand("sp_iArchivo")
			cmd.CommandType = CommandType.StoredProcedure : cmd.Connection = Cnn
			cmd.Parameters.AddWithValue("@nomArchivo", dts.gNomArchivo) : cmd.Parameters.AddWithValue("@Archivo", dts.gArchivo)
			If cmd.ExecuteNonQuery Then
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
