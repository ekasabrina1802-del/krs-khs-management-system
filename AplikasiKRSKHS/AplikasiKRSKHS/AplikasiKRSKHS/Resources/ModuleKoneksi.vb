Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Module ModuleKoneksi

    ' -------------------------
    ' GLOBAL SHARED INSTANCES
    ' -------------------------
    Public GlobalDashboard As Form = Nothing
    Public GlobalKRS As Mhs_KRS = Nothing

    ' NIM mahasiswa yg sedang login (dipakai untuk filter otomatis di Mhs_KHS)
    Public GlobalMahasiswaNIM As String = String.Empty

    ' -------------------------
    ' CONNECTION STRING & SHARED CONNECTION
    ' -------------------------
    Private ReadOnly ConnectionString As String =
        "Data Source=LAPTOP-N3HRLL7J;Initial Catalog=DB_KRS_KHS;Integrated Security=True;"

    Public Conn As SqlConnection = Nothing

    ' -------------------------
    ' CONNECTION HELPERS
    ' -------------------------
    Public Sub OpenConnection()
        If Conn Is Nothing Then Conn = New SqlConnection(ConnectionString)
        If Conn.State = ConnectionState.Closed OrElse Conn.State = ConnectionState.Broken Then Conn.Open()
    End Sub

    Public Sub CloseConnection()
        If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
    End Sub

    Public Function EnsureConnection() As Boolean
        Try
            OpenConnection()
            Return Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open
        Catch
            Return False
        End Try
    End Function

    ' -------------------------
    ' CRYPTO HELPERS
    ' -------------------------
    Public Function HashPassword(ByVal password As String) As String
        If password Is Nothing Then password = String.Empty
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes() As Byte = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()
            For Each b In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

End Module
