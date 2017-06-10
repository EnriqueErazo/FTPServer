Public Class XML
	Public valor1 As String
	Public valor2 As String
	Public valor3 As String
	Public Funcion As String

	Public Sub New()
	End Sub
	Public Sub New(ByVal newValor1 As String, ByVal newValor2 As String, ByVal newValor3 As String, ByVal newFuncion As String)
		valor1 = newValor1
		valor2 = newValor2
		valor3 = newValor3
		Funcion = newFuncion
	End Sub
End Class