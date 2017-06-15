Imports System.Data.SqlClient
Public Class fBitacora
	Inherits Conexion
	Dim cmd As New SqlCommand
	Public Function mostrarS() As DataTable
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
	Public Shared Function mostrarC() As ArrayList
		Dim result As New ArrayList
		'Dim da As New SqlDataAdapter()
		Try
			Dim dr As SqlDataReader
			Dim cmd As SqlCommand
			cmd = New SqlCommand()
			cmd.Connection = New SqlConnection("Data Source = .; Initial Catalog = proSeguridad; Integrated Security = true")
			cmd.CommandText = "SELECT * FROM Bitacora"
			cmd.Connection.Open()	'se abre la conexion
			dr = cmd.ExecuteReader
			'	Dim dr As SqlDataReader
			'	'Conexion = New clsConexionBaseDatos(servidor, basededatos)
			'	da.SelectCommand = New SqlCommand()
			'	da.SelectCommand.Connection = New SqlConnection("Data Source = .; Initial Catalog = proSeguridad; Integrated Security = true")
			'	da.SelectCommand.CommandText = "SELECT * FROM Bitacora"

			'	'MyDataAdapter.SelectCommand.Parameters.AddWithValue("@Cod_Usuario", getCodUsuario(usuario))

			'	da.SelectCommand.Connection.Open() 'se abre la conexion
			'	dr = da.SelectCommand.ExecuteReader
			While dr.Read
				result.Add(New vBitacora(dr.GetString(2), dr.GetString(3)))
			End While
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return result ' retorna el resultado
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
