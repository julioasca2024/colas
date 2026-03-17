Imports OSSql
Imports LAYER_DATA
Imports System.Data.SqlClient

Public Class Clase_Conexion
    Public Function Conectar() As Boolean

        If Conexion.IniciarSesion("SBSQL", "db_sighoshsb", "user_sighoshsb", "hsbarto") Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ConectarColas() As Boolean

        If Conexion.IniciarSesion("sbsighoshsb", "colas", "user_sighoshsb", "hsbarto") Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub Desconectar()
        Conexion.FinalizarSesion()
    End Sub

    Public Function fObtieneDataTable(ByVal Sql As String, ByVal ParamArray parametros() As String)
        Dim dt As New DataTable

        dt = Conexion.Sql.GetDataTable(Sql, parametros)
        Return dt

    End Function

    Public Function fObtieneDataTableSQL(ByVal Sql As String)
        Dim dt As New DataTable

        dt = Conexion.Sql.GetDataTableSql(Sql)
        Return dt

    End Function

    Public Function pEjecutaSP(ByVal sp As String, ByVal ParamArray parametros() As String) As Integer
        Dim result As Integer
        result = Conexion.Sql.Ejecutar(sp, parametros)

        Return result
    End Function

    Public Function fObtieneDataReader(ByVal sp As String, ByVal ParamArray parametros() As String)
        Dim dr As SqlDataReader
        dr = Conexion.Sql.GetDataReader(sp, parametros)
        Return dr
    End Function


End Class
