Public Class XML
	Public nombre As String
	Public archivo As String
	Public idContacto As String
	Public Hash As String
	Public Funcion As String
	Public Sub New()
	End Sub
	Public Sub New(ByVal newnombre As String, ByVal newarchivo As String, ByVal newcontacto As String, ByVal newHash As String, ByVal newFuncion As String)
		nombre = newnombre : archivo = newarchivo : Hash = newHash : idContacto = newcontacto : Funcion = newFuncion
	End Sub
End Class