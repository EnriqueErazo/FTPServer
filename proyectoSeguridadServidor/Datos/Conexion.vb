Imports System.Data.SqlClient
Public Class Conexion
	Protected Cnn As New SqlConnection
	Public Function Conexion()
		Try
			If cnn.State = ConnectionState.Closed Then
				Cnn = New SqlConnection("Data Source = .; Initial Catalog = proSeguridad; Integrated Security = true")
				cnn.Open()
				Return True
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
			Return False
		End Try
		Return False
		'Dim cc As String
		'cc = "server=ASUS-KL4UD10; database=ProyectoSeguridad31121158; Integrated Security=True"
		'Return cc
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