Public Class vArchivo
	Dim idArchivo As Integer : Dim nomArchivo As String : Dim archivo As String
	Public Property gIdArchivo
		Get
			Return idArchivo
		End Get
		Set(ByVal value)
			idArchivo = value
		End Set
	End Property
	Public Property gNomArchivo
		Get
			Return nomArchivo
		End Get
		Set(ByVal value)
			nomArchivo = value
		End Set
	End Property
	Public Property gArchivo
		Get
			Return archivo
		End Get
		Set(ByVal value)
			archivo = value
		End Set
	End Property
	Public Sub New()
	End Sub
	Public Sub New(ByVal idArchivo As Integer, ByVal nomArchivo As String, ByVal archivo As String)
		gIdArchivo = idArchivo : gNomArchivo = nomArchivo : gArchivo = archivo
	End Sub
End Class
