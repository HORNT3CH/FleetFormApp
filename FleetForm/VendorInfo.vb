Imports System.Data.SqlClient
Public Class VendorInfo
    Private Sub VendorInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=LT-CLE01715\SQLEXPRESS;Initial Catalog=Fleet;Integrated Security=True"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
            Catch ex As Exception
                MessageBox.Show("An error occured while connecting to the database: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class