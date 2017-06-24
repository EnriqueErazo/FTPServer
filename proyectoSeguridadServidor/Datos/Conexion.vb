Imports System.Data.SqlClient
Public Class Conexion
	Protected Cnn As New SqlConnection
	Public Function Conexion() As SqlConnection
		Try
			Cnn = New SqlConnection("Data Source = .; Initial Catalog = proSeguridadFinal; Integrated Security = true")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		Return cnn
	End Function
	Public Function ConexionA()
		Try
			If Cnn.State = ConnectionState.Closed Then
				Cnn = New SqlConnection("Data Source = .; Initial Catalog = proSeguridadFinal; Integrated Security = true")
				Cnn.Open()
				Return True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
		Return False
	End Function
	Public Function Desconexion()
		Try
			If cnn.State = ConnectionState.Open Then
				cnn.Close()
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
	End Function
End Class