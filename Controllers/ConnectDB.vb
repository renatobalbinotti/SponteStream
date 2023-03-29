Imports System.Data.SqlClient
Imports System.Configuration

Public Class ConnectDB
    Public connection As SqlClient.SqlConnection

    Public Sub Conectar()
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("SPONTE").ConnectionString
            Dim connection As New SqlConnection(connectionString)
            connection.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Fechar()
        Try
            If Not IsNothing(connection) Then
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function executeQuery(ByVal sql As String) As DataSet
        Dim ds As New DataSet
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objCommand As New SqlClient.SqlCommand

        Try
            objCommand = connection.CreateCommand
            objCommand.CommandText = sql

            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            objDataAdapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        End Try

        Return ds
    End Function

End Class
