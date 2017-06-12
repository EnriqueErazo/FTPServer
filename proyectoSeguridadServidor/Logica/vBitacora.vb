Imports System.Data.SqlClient
Public Class vBitacora
	Inherits Conexion
	Dim _usuContacto As String : Dim _fechaModif As String : Dim _accion As String : Dim _detalle As String
	Public Property GUsuario
		Get
			Return _usuContacto
		End Get
		Set(ByVal value)
			_usuContacto = value
		End Set
	End Property
	Public Property Gfecha
		Get
			Return _fechaModif
		End Get
		Set(ByVal value)
			_fechaModif = value
		End Set
	End Property
	Public Property GAccion
		Get
			Return _accion
		End Get
		Set(ByVal value)
			_accion = value
		End Set
	End Property
	Public Property GDetalle
		Get
			Return _detalle
		End Get
		Set(ByVal value)
			_detalle = value
		End Set
	End Property
	Public Sub New()
	End Sub
	Public Sub New(ByVal usuContacto As String, ByVal fechaModif As String, ByVal accion As String, ByVal detalle As String)
		GUsuario = usuContacto : Gfecha = fechaModif : GAccion = accion : GDetalle = detalle
	End Sub
	Public Function Manejo(ByVal usuContacto As String, ByVal accion As String, ByVal valor As String)
		Try
			Select Case accion
				Case "Login"
					_detalle = usuContacto & " inicio sesion"
				Case "Archivo"
					_detalle = usuContacto & " agrego archivo " & valor
				Case "Bitacora"
					_detalle = usuContacto & " solicito bitacora"
			End Select
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
		Return _detalle
	End Function
End Class
