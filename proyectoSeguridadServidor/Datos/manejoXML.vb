Imports System.IO
Imports System.Xml.Serialization
Public Class ManejoXml
	Shared _xmlSerializer As XmlSerializer : Shared _stringWriter As New StringWriter
	Public Shared Function SerialiazarXml(ByVal valor1 As String, ByVal valor2 As String, ByVal valor3 As String, ByVal opcion As String) As String
		Dim log As New XML(valor1, valor2, valor3, opcion):_xmlSerializer = New XmlSerializer(GetType(XML))
		Dim ns As New XmlSerializerNamespaces():ns.Add("", ""):_stringWriter = New StringWriter
		_xmlSerializer.Serialize(_stringWriter, log, ns):_stringWriter.Close()
		Return _stringWriter.ToString()
	End Function
End Class
