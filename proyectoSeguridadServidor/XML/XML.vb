Public Class XML
	Public Valor1 As String	'usuario
	Public Valor2 As String	'archivo/bitacora
	Public Valor3 As String	'idUsuario
	Public Hash As String
	Public Funcion As String
	Public Shared xml As ArrayList
	Public Sub New()
	End Sub
	Public Sub New(ByVal newnombre As String, ByVal newArchivo As String, ByVal newContacto As String, ByVal newHash As String, ByVal newFuncion As String)
		Valor1 = newnombre : Valor2 = newArchivo : Hash = newHash : Valor3 = newContacto : Funcion = newFuncion
	End Sub
End Class