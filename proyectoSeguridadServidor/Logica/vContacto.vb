Public Class vContacto
	Public Property GCorreo As String
	Public Property GUsuario As String
	Public Property GNombre As String
	Public Property GIpContacto As String
	Public Property GEstado As String
	Public Property GPass As String
	Public Sub New()
	End Sub
	Public Sub New(ByVal correoContacto As String, ByVal usuContacto As String, ByVal nomContacto As String, ByVal ipContacto As String, ByVal estado As String, ByVal pass As String)
		GCorreo = correoContacto : GUsuario = usuContacto : GNombre = nomContacto : GIpContacto = ipContacto : GEstado = estado : GPass = pass
	End Sub
End Class
