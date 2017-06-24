Public Class vBitacora
	Public Property GIdBitacora As Integer
	Public Property GAccion As String
	Public Property GFecha As String
	Public Property GidUsuario As String
	Public Property GHash As String
	'Public Sub New()
	'End Sub
	'Public Sub New(ByVal newIdBitacora As Integer, ByVal newAccion As String, ByVal newFechaCrea As String, ByVal newIdUsuario As String)
	'	GIdBitacora = newIdBitacora : GAccion = newAccion : GFecha = newFechaCrea : GidUsuario = newIdUsuario
	'End Sub
	Public Function Manejo(ByVal usuContacto As String, ByVal accion As String, ByVal valor As String)
		Dim detalle = ""
		Try
			Select Case accion
				Case "Login"
					detalle = usuContacto & " inicio sesion"
				Case "Archivo"
					detalle = usuContacto & " agrego archivo " & valor
				Case "Bitacora"
					detalle = usuContacto & " solicito bitacora"
			End Select
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		Return detalle
	End Function
	'Public Sub New(ByVal fechaModif As String, ByVal accion As String)
	'	GFecha = fechaModif : GAccion = accion ' : GDetalle = detalle
	'End Sub
End Class
