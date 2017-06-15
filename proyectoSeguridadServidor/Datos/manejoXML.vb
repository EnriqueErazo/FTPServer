Imports System.IO
Imports System.Xml.Serialization
Public Class ManejoXml
	Shared _xmlSerializer As XmlSerializer : Shared _stringWriter As New StringWriter
	Public Shared Function Key(hora As String) As String
		Dim llave As String = "ftpseguro" & hora
		Return llave
	End Function
	Public Shared Function SerialiazarXmlLogin(ByVal valor1 As String, ByVal valor2 As String, ByVal hash As String, ByVal opcion As String) As String
		Dim log As New Login(valor1, valor2, hash, opcion) : _xmlSerializer = New XmlSerializer(GetType(Login))
		Dim ns As New XmlSerializerNamespaces() : ns.Add("", "") : _stringWriter = New StringWriter
		_xmlSerializer.Serialize(_stringWriter, log, ns) : _stringWriter.Close()
		Return _stringWriter.ToString()
	End Function
	Public Shared Function SerialiazarXmlArchivo(ByVal nombre As String, ByVal archivo As String, ByVal owner As Integer, ByVal hash As String, ByVal opcion As String) As String
		Dim arc As New XML(nombre, archivo, owner, hash, opcion) : _xmlSerializer = New XmlSerializer(GetType(XML))
		Dim ns As New XmlSerializerNamespaces() : ns.Add("", "") : _stringWriter = New StringWriter
		_xmlSerializer.Serialize(_stringWriter, log, ns) : _stringWriter.Close()
		Return _stringWriter.ToString()
	End Function
End Class
