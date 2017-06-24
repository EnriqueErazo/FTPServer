'Imports System.IO
'Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml.Serialization

Public Class ManejoXml
	' ''obtener datos del XML recibido
	''Public Function IdOperacion(ByVal xml As String) As Integer
	''	Dim cadena As Integer = 0 : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = CInt(node.ChildNodes(0).InnerText)
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Operacion(ByVal xml As String) As String
	''	Dim res As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			res = node.ChildNodes(1).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return res
	''End Function
	''Public Function Contacto(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(3).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Password(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(4).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Estado(ByVal xml As String) As Integer
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = CInt(node.ChildNodes(2).InnerText)
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Equipo(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(2).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Contactos(ByVal xml As String) As String
	''	Dim cadena As String = ""
	''	: Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(4).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function NomArchivo(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(5).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Extension(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(6).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Tamano(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(7).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Contenido(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(8).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Opcion(ByVal xml As String) As String
	''	Dim cadena As String = "" : Dim xmlDoc As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xmlDoc.LoadXml(xml) : nodelist = xmlDoc.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(5).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	' ''Repeticion de registros(Archivos, Bitacora, Contactos)
	''Public Function XmlRepeticion(ByVal repetido As Integer) As String
	''	Dim twriter As XmlTextWriter : Dim cadena As String = ""
	''	Try
	''		Dim sw As New StringWriter() : twriter = New XmlTextWriter(sw) : twriter.WriteStartDocument(True)
	''		twriter.Formatting = Formatting.Indented : twriter.Indentation = 2 : twriter.WriteStartElement("XML")
	''		twriter.WriteStartElement("Repeticiones") : twriter.WriteString(repetido) : twriter.WriteEndElement()
	''		twriter.WriteEndElement() : twriter.WriteEndDocument() : cadena = sw.ToString() : twriter.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Repetido(ByVal xmlRepeticion As String) As Integer
	''	Dim cadena As Integer = 0 : Dim xml As New XmlDocument : Dim nodelist As XmlNodeList : Dim node As XmlNode
	''	Try
	''		xml.LoadXml(XmlRepeticion) : nodelist = xml.SelectNodes("/XML")
	''		For Each node In nodelist
	''			cadena = node.ChildNodes(0).InnerText
	''		Next
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	' ''XML enviado
	''Public Function XmlRespuesta(ByVal operacion As Integer, ByVal respuesta As Integer) As String
	''	Dim twriter As XmlTextWriter : Dim resultado As String = "" : Dim sw As New StringWriter()
	''	Try
	''		twriter = New XmlTextWriter(sw) : twriter.WriteStartDocument(True) : twriter.Formatting = Formatting.Indented : twriter.Indentation = 2
	''		twriter.WriteStartElement("XML")
	''		twriter.WriteStartElement("idOperacion") : twriter.WriteString(operacion) : twriter.WriteEndElement()
	''		twriter.WriteStartElement("Operacion") : twriter.WriteString("Respuesta") : twriter.WriteEndElement()
	''		twriter.WriteStartElement("Estado") : twriter.WriteString(respuesta) : twriter.WriteEndElement()
	''		twriter.WriteEndElement()
	''		twriter.WriteEndDocument()
	''		resultado = sw.ToString()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return resultado
	''End Function
	''Public Function XmlContactos(ByVal contactos As ArrayList) As String
	''	Dim twriter As XmlTextWriter : Dim cadena As String = "" : Dim sw As New StringWriter()
	''	Try
	''		twriter = New XmlTextWriter(sw) : twriter.WriteStartDocument(True) : twriter.Formatting = Formatting.Indented : twriter.Indentation = 2
	''		twriter.WriteStartElement("XML")
	''		twriter.WriteStartElement("idOperacion") : twriter.WriteString("4") : twriter.WriteEndElement()
	''		For Each item As String In contactos
	''			twriter.WriteStartElement("Contacto") : twriter.WriteString(item) : twriter.WriteEndElement()
	''		Next
	''		twriter.WriteEndElement() : twriter.WriteEndDocument() : cadena = sw.ToString() : twriter.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function XmlArchivos(ByVal archivo As ArrayList) As String
	''	Dim writer As XmlTextWriter : Dim cadena As String = "" : Dim myStringWriter As New StringWriter()
	''	Try
	''		writer = New XmlTextWriter(myStringWriter):writer.WriteStartDocument(True):writer.Formatting = Formatting.Indented:writer.Indentation = 2
	''		writer.WriteStartElement("XML")
	''		writer.WriteStartElement("idOperacion") : writer.WriteString("5") : writer.WriteEndElement()
	''		For Each item As vArchivo In archivo
	''			writer.WriteStartElement("Archivo")
	''			writer.WriteStartElement("idArchivo") : writer.WriteString(item.GidArchivo) : writer.WriteEndElement()
	''			writer.WriteStartElement("Nombre") : writer.WriteString(item.GNomArchivo) : writer.WriteEndElement()
	''			writer.WriteStartElement("Extension") : writer.WriteString(item.GExtension) : writer.WriteEndElement()
	''			writer.WriteStartElement("Tamano") : writer.WriteString(item.GTamano) : writer.WriteEndElement()
	''			writer.WriteStartElement("fechaModif") : writer.WriteString(item.GFechaCrea) : writer.WriteEndElement()
	''			writer.WriteStartElement("idContacto") : writer.WriteString(item.GContacto) : writer.WriteEndElement()
	''			writer.WriteEndElement()
	''		Next
	''		writer.WriteEndElement() : writer.WriteEndDocument() : cadena = myStringWriter.ToString() : writer.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function XmlDescarga(ByVal datos As ArrayList) As String
	''	Dim writer As XmlTextWriter : Dim cadena As String = "" : Dim myStringWriter As New StringWriter()
	''	Try
	''		writer = New XmlTextWriter(myStringWriter) : writer.WriteStartDocument(True) : writer.Formatting = Formatting.Indented : writer.Indentation = 2
	''		writer.WriteStartElement("XML")
	''		writer.WriteStartElement("idOperacion") : writer.WriteString("6") : writer.WriteEndElement()
	''		writer.WriteStartElement("Operacion") : writer.WriteString("Descarga") : writer.WriteEndElement()
	''		writer.WriteStartElement("NomArchivo") : writer.WriteString(datos.Item(0)) : writer.WriteEndElement()
	''		writer.WriteStartElement("Extension") : writer.WriteString(datos.Item(1)) : writer.WriteEndElement()
	''		writer.WriteStartElement("Contenido") : writer.WriteString(datos.Item(2)) : writer.WriteEndElement()
	''		writer.WriteEndElement() : writer.WriteEndDocument() : cadena = myStringWriter.ToString() : writer.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	' ''XML listas
	''Public Function Compartidos(ByVal contactos As ArrayList) As String
	''	Dim writer As XmlTextWriter : Dim cadena As String = "" : Dim myStringWriter As New StringWriter()
	''	Try
	''		writer = New XmlTextWriter(myStringWriter) : writer.WriteStartDocument(True) : writer.Formatting = Formatting.Indented : writer.Indentation = 2
	''		writer.WriteStartElement("XML")
	''		writer.WriteStartElement("idOperacion") : writer.WriteString("7") : writer.WriteEndElement()
	''		For Each item As String In contactos
	''			writer.WriteStartElement("Contacto") : writer.WriteString(item) : writer.WriteEndElement()
	''		Next
	''		writer.WriteEndElement() : writer.WriteEndDocument() : cadena = myStringWriter.ToString() : writer.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Bitacora(ByVal bita As ArrayList) As String
	''	Dim writer As XmlTextWriter : Dim cadena As String = "" : Dim myStringWriter As New StringWriter()
	''	Try
	''		writer = New XmlTextWriter(myStringWriter) : writer.WriteStartDocument(True) : writer.Formatting = Formatting.Indented : writer.Indentation = 2
	''		writer.WriteStartElement("XML")
	''		writer.WriteStartElement("idOperacion") : writer.WriteString("9") : writer.WriteEndElement()
	''		For Each item As vBitacora In bita
	''			writer.WriteStartElement("Registro")
	''			writer.WriteStartElement("idBitacora") : writer.WriteString(Str(item.GIdBitacora)) : writer.WriteEndElement()
	''			writer.WriteStartElement("Accion") : writer.WriteString(item.GAccion) : writer.WriteEndElement()
	''			writer.WriteStartElement("nomEquipo") : writer.WriteString(item.GEquipo) : writer.WriteEndElement()
	''			writer.WriteStartElement("Fecha") : writer.WriteString(item.GFecha) : writer.WriteEndElement()
	''			writer.WriteStartElement("idArchivo") : writer.WriteString(Str(item.GIdArchivo)) : writer.WriteEndElement()
	''			writer.WriteStartElement("idContacto") : writer.WriteString(item.GidUsuario) : writer.WriteEndElement()
	''			writer.WriteEndElement()
	''		Next
	''		writer.WriteEndElement() : writer.WriteEndDocument() : cadena = myStringWriter.ToString() : writer.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	''Public Function Disponibles(ByVal contactos As ArrayList) As String
	''	Dim writer As XmlTextWriter : Dim cadena As String = "" : Dim myStringWriter As New StringWriter()
	''	Try
	''		writer = New XmlTextWriter(myStringWriter):writer.WriteStartDocument(True):writer.Formatting = Formatting.Indented:writer.Indentation = 2
	''		writer.WriteStartElement("XML")
	''		writer.WriteStartElement("idOperacion") : writer.WriteString("10") : writer.WriteEndElement()
	''		For Each item As String In contactos
	''			writer.WriteStartElement("Contacto") : writer.WriteString(item) : writer.WriteEndElement()
	''		Next
	''		writer.WriteEndElement() : writer.WriteEndDocument() : cadena = myStringWriter.ToString() : writer.Close()
	''	Catch ex As Exception
	''		MsgBox(ex.Message)
	''	End Try
	''	Return cadena
	''End Function
	Shared _xmlSerializer As XmlSerializer : Shared _stringWriter As New StringWriter
	Public Shared Function Key(hora As String) As String
		Dim llave As String = "ftpseguro" & hora
		Return llave
	End Function
	Public Shared Function SerialiazarXml(ByVal usuario As String, ByVal nombre As String, ByVal archivo As String, ByVal hash As String, ByVal opcion As String) As String
		'Public Shared Function SerialiazarXml() As String
		Dim xmlDoc As New XML(usuario, nombre, archivo, hash, opcion) : _xmlSerializer = New XmlSerializer(GetType(XML))
		'Dim xmlDoc As New XML() : _xmlSerializer = New XmlSerializer(GetType(XML))
		'frmMenu.sendBitacora(frmMenu.Mostrar)
		Dim ns As New XmlSerializerNamespaces() : ns.Add("", "") : _stringWriter = New StringWriter
		_xmlSerializer.Serialize(_stringWriter, xmlDoc, ns) : _stringWriter.Close()
		Return _stringWriter.ToString()
	End Function
	Public Shared Function SeriBitacora(ByVal usuario As String, ByVal valor2 As String, ByVal valor3 As String, ByVal hash As String, ByVal opcion As String)
		Dim xmlSerializer As New XmlSerializer(GetType(List(Of fBitacora)))
		Dim ns As New XmlSerializerNamespaces() : ns.Add("", "")
		Dim stringWriter As New StringWriter()
		xmlSerializer.Serialize(stringWriter, fBitacora.MostrarC(usuario, hash, opcion), ns)
		Return stringWriter.ToString()
	End Function
End Class
