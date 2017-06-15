Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Md5_3Ds
	'Private Shared _vector() As Byte = {27, 9, 45, 27, 0, 72, 171, 54}
	'Public Function EncryptString(ByVal str As String) As String
	'	'Create a new RSA key. This key will encrypt a symmetric key, which will then be imbedded in the XML document.
	'	'Get a byte array of the str as encryption works on byte blocks
	'	Dim enc As New ASCIIEncoding
	'	Dim byteData() As Byte = enc.GetBytes(str)
	'	'Create encryption object
	'	Dim tDes As New TripleDESCryptoServiceProvider()
	'	Dim md5 As New MD5CryptoServiceProvider()
	'	tDes.Key = md5.ComputeHash(enc.GetBytes(str))
	'	'Specify Initialisation Vector as encryption key to use
	'	tDes.IV = _vector
	'	'Adds key and IVector to Encrypt object
	'	Dim transform As ICryptoTransform
	'	transform = tDes.CreateEncryptor()
	'	Return Convert.ToBase64String(transform.TransformFinalBlock(byteData, 0, byteData.Length))
	'End Function
	'Public Function DecryptString(ByVal base64Str As String) As String
	'	'Perform as decrypt of encytpted data with above method
	'	'Get byte array from string
	'	Dim enc As New ASCIIEncoding
	'	Dim md5 As New MD5CryptoServiceProvider()
	'	Dim byteData() As Byte = enc.GetBytes(base64Str)
	'	Dim encData() As Byte = Convert.FromBase64String(base64Str)
	'	'Create encryption object
	'	Dim tDes As New TripleDESCryptoServiceProvider()
	'	tDes.Key = md5.ComputeHash(enc.GetBytes(base64Str))
	'	'Specify Initialisation Vector as encryption key to use
	'	tDes.IV = _vector
	'	'tDes.Key = UNIVERAL_KEY_192
	'	'Adds key and IVector to decrypt object
	'	Dim transform As ICryptoTransform
	'	transform = tDes.CreateDecryptor()
	'	Return Encoding.ASCII.GetString(transform.TransformFinalBlock(encData, 0, encData.Length()))
	'End Function
	Private TripleDes As New TripleDESCryptoServiceProvider
	Private m_bKey(), m_bIV() As Byte
	Public Sub New()
		Dim strCrypt, strIV As String

		strCrypt = "q5AsCA64SeY+SpoJ24ERrg=="
		strIV = "VaOHJOI2J/c="
		m_bKey = Convert.FromBase64String(strCrypt)
		m_bIV = Convert.FromBase64String(strIV)
	End Sub
	Public Function EncryptString(ByVal strPlainText As String) As String

		Dim tDESProvider As New TripleDESCryptoServiceProvider
		'Dim tDes2 As New TripleDES
		Dim cryptStream As CryptoStream
		Dim iCryptoEncryptor As ICryptoTransform
		Dim memStream As New MemoryStream()
		Dim bPlainText As Byte()
		Dim strTempEncrypt As String

		tDESProvider.KeySize = 128

		iCryptoEncryptor = tDESProvider.CreateEncryptor(m_bKey, m_bIV)
		cryptStream = New CryptoStream(memStream, iCryptoEncryptor, CryptoStreamMode.Write)
		bPlainText = System.Text.Encoding.UTF8.GetBytes(strPlainText)
		cryptStream.Write(bPlainText, 0, bPlainText.Length)
		cryptStream.FlushFinalBlock()
		Dim tmp(CType(memStream.Length - 1, System.Int32)) As Byte
		memStream.Position = 0
		memStream.Read(tmp, 0, CType(memStream.Length, System.Int32))
		memStream.Close()
		cryptStream.Close()
		strTempEncrypt = Convert.ToBase64String(tmp)
		Return strTempEncrypt
		'retorna el String encriptado

	End Function
	Public Function DecryptString(ByVal strCipherText As String) As String
		Dim strTempDecrypt As String
		Dim memstream2 As New MemoryStream
		Dim iCryptoDecryptor As ICryptoTransform
		Dim tDesProviderd As New TripleDESCryptoServiceProvider
		Dim cryptdStream As CryptoStream
		Dim bCipher As Byte()

		bCipher = Convert.FromBase64String(strCipherText)
		tDesProviderd.KeySize = 128
		iCryptoDecryptor = tDesProviderd.CreateDecryptor(m_bKey, m_bIV)
		cryptdStream = New CryptoStream(memstream2, iCryptoDecryptor, CryptoStreamMode.Write)
		cryptdStream.Write(bCipher, 0, bCipher.Length)
		cryptdStream.FlushFinalBlock()
		memstream2.Position = 0

		Dim temp2(CType(memstream2.Length - 1, Int32)) As Byte

		memstream2.Read(temp2, 0, temp2.Length)
		memstream2.Close()
		cryptdStream.Close()

		strTempDecrypt = System.Text.Encoding.UTF8.GetString(temp2)
		Return strTempDecrypt
	End Function
	Public Function Md5Encryta(ByVal md5Hash As MD5, ByVal input As String) As String
		' Convert the input string to a byte array and compute the hash.
		Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(Input))
		' Create a new Stringbuilder to collect the bytes
		' and create a string.
		Dim sBuilder As New StringBuilder()
		' Loop through each byte of the hashed data 
		' and format each one as a hexadecimal string.
		Dim i As Integer
		For i = 0 To data.Length - 1
			sBuilder.Append(data(i).ToString("x2"))
		Next i
		' Return the hexadecimal string.
		Return sBuilder.ToString()
	End Function
End Class
