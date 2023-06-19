Imports System.Data.SqlClient
Imports System.Numerics
Public Class TripNumbers
    Private Sub PopulateComboBox(Vendor As Object, Query As String, DisplayMember As String)
        Dim connectionString As String = "Data Source=LT-CLE01715\SQLEXPRESS;Initial Catalog=Fleet;Integrated Security=True;"

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(Query, connection)

                    dataTable.Load(command.ExecuteReader())

                End Using
            Catch ex As Exception
                MessageBox.Show("An error occured while connecting to the database: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Vendor.DataSource = dataTable

        Vendor.DisplayMember = DisplayMember
    End Sub
    Private Sub TripNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBox(cmbLTNumber, "SELECT TrlrNumb, TrlrLngh, TrlrHt, TrlrWdth FROM TrailerId;", "TrlrNumb")
        PopulateComboBox(cmbTractorNumber, "SELECT TractorNmbr, Make FROM tblTractor;", "TractorNmbr")
        PopulateComboBox(cmbOBTrailer, "SELECT TrlrNumb, TrlrLngh, TrlrHt, TrlrWdth FROM TrailerId;", "TrlrNumb")
        PopulateComboBox(cmbIBTrailer, "SELECT TrlrNumb, TrlrLngh, TrlrHt, TrlrWdth FROM TrailerId;", "TrlrNumb")
        PopulateComboBox(cmbTripDate, "SELECT Date FROM [Date] ORDER BY Date DESC;", "Date")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cmbTripDate.Text = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub
End Class