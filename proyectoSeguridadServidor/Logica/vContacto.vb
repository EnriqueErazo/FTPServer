Public Class vContacto
	Dim _correoContacto As String : Dim _usuContacto As String : Dim _nomContacto As String : Dim _ipContacto As String : Dim _estado As String : Dim _pass As String
	Public Property GCorreo
		Get
			Return _correoContacto
		End Get
		Set(ByVal value)
			_correoContacto = value
		End Set
	End Property
	Public Property GUsuario
		Get
			Return _usuContacto
		End Get
		Set(ByVal value)
			_usuContacto = value
		End Set
	End Property
	Public Property GNombre
		Get
			Return _nomContacto
		End Get
		Set(ByVal value)
			_nomContacto = value
		End Set
	End Property
	Public Property GIpContacto
		Get
			Return _ipContacto
		End Get
		Set(ByVal value)
			_ipContacto = value
		End Set
	End Property
	Public Property GEstado
		Get
			Return _estado
		End Get
		Set(ByVal value)
			_estado = value
		End Set
	End Property
	Public Property GPass
		Get
			Return _pass
		End Get
		Set(ByVal value)
			_pass = value
		End Set
	End Property
	Public Sub New()
	End Sub
	Public Sub New(ByVal correoContacto As String, ByVal usuContacto As String, ByVal nomContacto As String, ByVal ipContacto As String, ByVal estado As String, ByVal pass As String)
		GCorreo = correoContacto : GUsuario = usuContacto : GNombre = nomContacto : GIpContacto = ipContacto : GEstado = estado : GPass = pass
	End Sub

End Class
