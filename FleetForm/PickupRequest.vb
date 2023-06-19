Imports System.Data.SqlClient
Imports System.Numerics

Public Class PickupRequest
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

    Private Sub PickupRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=LT-CLE01715\SQLEXPRESS;Initial Catalog=Fleet;Integrated Security=True;"
        Dim query As String = "SELECT SkuPickUpCounter, PuReqNmbr, SKU, Qnty, PODueDate, Destination, MrAndLine FROM tblVendorPickUpRequestSKU"
        Dim dataTable As New DataTable()

        PopulateComboBox(cmbVendor, "SELECT DISTINCT VndrID, VndrName, VndrAdrs, VndrCity, VndrSt FROM VendorId ORDER BY VndrName;", "VndrName")
        PopulateComboBox(cmbFaxDate, "SELECT Date FROM Date ORDER BY Date DESC", "Date")
        PopulateComboBox(cmbSKU, "SELECT ItemId, ItemDesc FROM ItemId;", "ItemId")



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

        DataGridView1.DataSource = dataTable

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmbFaxDate.Text = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub
End Class