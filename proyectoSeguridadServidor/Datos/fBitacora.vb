Imports System.Data.SqlClient
Public Class fBitacora
	Inherits Conexion
	Dim cmd As New SqlCommand
	Public Function mostrar() As DataTable
		Try
			Conexion() : cmd = New SqlCommand("sp_mBitacora")
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
	Public Function Insertar(ByVal dts As vBitacora) As Boolean
		Try
			Conexion() : cmd = New SqlCommand("sp_iBitacora")
			cmd.CommandType = CommandType.StoredProcedure : cmd.Connection = Cnn
			cmd.Parameters.AddWithValue("@usuContacto", dts.GUsuario) : cmd.Parameters.AddWithValue("@fechaModif", dts.Gfecha)
			cmd.Parameters.AddWithValue("@accion", dts.GDetalle)
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
