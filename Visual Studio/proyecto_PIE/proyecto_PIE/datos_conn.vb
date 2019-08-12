Imports System.IO

Module datos_conn
    Public servidor = "DESKTOP-I4KK2TD\SQLEXPRESS"
    Public puerto = "1433"
    Public bd = "integracion_pie"
    Public user = "sa"
    Public pass = "1234321"

    Public Function getservidor() As String
        Return servidor
    End Function

    Public Function getbd() As String
        Return bd
    End Function

    Public Function getuser() As String
        Return user
    End Function

    Public Function getpass() As String
        Return pass
    End Function

    Public Function getpuerto() As String
        Return puerto
    End Function
End Module
