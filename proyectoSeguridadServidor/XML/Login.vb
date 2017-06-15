Public Class Login
	Public Usuario As String	'usuario
	Public contra As String	'contraseña
	Public Hash As String 'hash
	Public Funcion As String 'accion a realizar
	Public Sub New()
	End Sub
	Public Sub New(ByVal newUsuario As String, ByVal newcontra As String, ByVal newHash As String, ByVal newFuncion As String)
		Usuario = newUsuario : contra = newcontra : Hash = newHash : Funcion = newFuncion
	End Sub
End Class