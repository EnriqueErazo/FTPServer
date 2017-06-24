Public Class vArchivo
	Public Property GidArchivo As Integer
	Public Property GNomArchivo As String
	Public Property GExtension As String
	Public Property GTamano As String
	Public Property GFechaCrea As String
	Public Property GContacto As String
	Public Property GContenido As String
	Public Sub New()
	End Sub
	Public Sub New(ByVal codArchivo As Integer, ByVal nomArchivo As String, ByVal extArchivo As String, ByVal tamanoArchivo As String, ByVal fechaingresoArchivo As String, ByVal usuContacto As String)
		GidArchivo = codArchivo : GNomArchivo = nomArchivo : GExtension = extArchivo : GTamano = tamanoArchivo
		GFechaCrea = fechaingresoArchivo : GContacto = usuContacto : GContenido = ""
	End Sub
	'Public Function ArrElemento() As String()
	'	Dim arc(6) As String : arc(0) = Str(GidArchivo) : arc(1) = GNomArchivo : arc(2) = GExtension : arc(3) = GTamano : arc(4) = GFechaCrea : arc(5) = GContacto
	'	Return arc
	'End Function
End Class
