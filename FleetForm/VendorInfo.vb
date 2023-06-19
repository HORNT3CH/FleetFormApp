Imports System.Configuration
Imports System.Data.SqlClient
Public Class VendorInfo

    Private Sub PopulateVendorComboBox(Vendor As Object)
        Dim connectionString As String = "Data Source=LT-CLE01715\SQLEXPRESS;Initial Catalog=Fleet;Integrated Security=True;"

        Dim query As String = "SELECT DISTINCT VndrID, VndrName, VndrAdrs, VndrCity, VndrSt FROM VendorId ORDER BY VndrName;"

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)

                    dataTable.Load(command.ExecuteReader())

                End Using
            Catch ex As Exception
                MessageBox.Show("An error occured while connecting to the database: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        Vendor.DataSource = dataTable

        Vendor.DisplayMember = "VndrName"
    End Sub
    Private Sub VendorInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateVendorComboBox(cmbVendor1)
        PopulateVendorComboBox(cmbVendor2)
        PopulateVendorComboBox(cmbVendor3)
    End Sub

    Private Sub btnEditEstTripTime_Click(sender As Object, e As EventArgs) Handles btnEditEstTripTime.Click
        Dim selectedVendor1Row As DataRowView = DirectCast(cmbVendor1.SelectedItem, DataRowView)
        Dim selectedVendor1 As String = selectedVendor1Row("VndrName").ToString()
        Dim selectedVendor2Row As DataRowView = DirectCast(cmbVendor2.SelectedItem, DataRowView)
        Dim selectedVendor2 As String = selectedVendor2Row("VndrName").ToString()
        Dim connectionString As String = "Data Source=LT-CLE01715\SQLEXPRESS;Initial Catalog=Fleet;Integrated Security=True;"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command1 As New SqlCommand("SELECT Miles FROM tblVendorToVendorTime
                                WHERE FromVendorName LIKE '" & selectedVendor2 & "' AND ToVendorName LIKE '" & selectedVendor1 &
                                "' OR FromVendorName LIKE '" & selectedVendor1 & "' AND ToVendorName LIKE '" & selectedVendor2 & "'", connection)
            Dim command2 As New SqlCommand("SELECT StdHrsTrip FROM tblVendorToVendorTime
                                WHERE FromVendorName LIKE '" & selectedVendor2 & "' AND ToVendorName LIKE '" & selectedVendor1 &
                                "' OR FromVendorName LIKE '" & selectedVendor1 & "' AND ToVendorName LIKE '" & selectedVendor2 & "'", connection)
            Dim result1 As Object = command1.ExecuteScalar()
            Dim result2 As Object = command2.ExecuteScalar()

            If result1 IsNot Nothing Or result2 IsNot Nothing Then
                Dim distanceInMiles As Integer = Convert.ToInt32(result1)
                Dim timeInHours As Double = Math.Round(Convert.ToDouble(result2), 2)
                MessageBox.Show("The distance from " & selectedVendor1 & " to " & selectedVendor2 & " is " & distanceInMiles & " miles, and should take you " & timeInHours & " hours.")
            End If
        End Using

    End Sub
End Class