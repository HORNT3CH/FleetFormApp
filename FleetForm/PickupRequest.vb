Imports System.Data.SqlClient
Imports System.Numerics
Public Module GlobalSettings
    Public ReadOnly Property ConnectionString As String
        Get
            Return "Data Source=LT-CLE01715\SQLEXPRESS;Initial Catalog=Fleet;Integrated Security=True;"
        End Get
    End Property
End Module
Public Class PickupRequest
    Private Sub PopulateComboBox(Vendor As Object, Query As String, DisplayMember As String)
        Dim connectionString As String = GlobalSettings.ConnectionString

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
        Dim connectionString As String = GlobalSettings.ConnectionString
        Dim getID As String = "SELECT MAX(PuReqNmbr) FROM tblVendorPickUpRequest"

        PopulateComboBox(cmbVendor, "SELECT DISTINCT VndrName FROM VendorId ORDER BY VndrName;", "VndrName")
        'PopulateComboBox(cmbFaxDate, "SELECT Date FROM Date ORDER BY Date DESC", "Date")
        PopulateComboBox(cmbFaxDate, "SELECT Date FROM Date WHERE Date BETWEEN DATEADD(day, -20, GETDATE()) AND DATEADD(day, 20, GETDATE());", "Date")
        PopulateComboBox(cmbSKU, "SELECT ItemId, ItemDesc FROM ItemId;", "ItemId")
        PopulateComboBox(cmbDestination, "SELECT DISTINCT VndrName FROM VendorId ORDER BY VndrName;", "VndrName")
        GetDataGrid()

        Using connection As New SqlConnection(connectionString)
            Try
                Using command As New SqlCommand(getID, connection)
                    connection.Open()

                    Dim result As Object = command.ExecuteScalar()

                    Dim nextID As Integer = If(result Is DBNull.Value, 1, Convert.ToInt32(result) + 1)

                    connection.Close()

                    txtPickUpReq.Text = nextID.ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occured while connecting to the database: " & ex.Message)
            End Try
        End Using

    End Sub
    Private Function GetDataGrid()
        Dim connectionString As String = GlobalSettings.ConnectionString
        'Dim query As String = "SELECT SkuPickUpCounter, PuReqNmbr, SKU, Qnty, PODueDate, Destination, MrAndLine FROM tblVendorPickUpRequestSKU WHERE PuReqNmbr = '" & txtPickUpReq.Text & "'"
        Dim query As String = "SELECT SkuPickUpCounter, PuReqNmbr, SKU, Qnty, PODueDate, Destination, MrAndLine FROM tblVendorPickUpRequestSKU WHERE PuReqNmbr = @PuReqNmbr"
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@PuReqNmbr", txtPickUpReq.Text)
                    dataTable.Load(command.ExecuteReader())

                End Using
            Catch ex As Exception
                MessageBox.Show("An error occured while connecting to the database: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using

        DataGridView1.DataSource = dataTable
        Return dataTable
    End Function

    Private Sub cmdToday_Click(sender As Object, e As EventArgs) Handles cmdToday.Click
        cmbFaxDate.Text = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub

    Private Sub cmdAddPickup_Click(sender As Object, e As EventArgs) Handles cmdAddPickup.Click
        Dim connectionString As String = GlobalSettings.ConnectionString

        Using connection As New SqlConnection(connectionString)
            Dim selectedID As Integer = GetSelectedID(cmbVendor)
            Dim query As String = "INSERT INTO tblVendorPickUpRequest (Vendor, FaxDate) VALUES (@Vendor, @FaxDate)"

            Using command As New SqlCommand(query, connection)

                command.Parameters.AddWithValue("@Vendor", selectedID)
                command.Parameters.AddWithValue("@FaxDate", cmbFaxDate.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using

        MessageBox.Show("Item added!")
    End Sub
    Private Function GetSelectedID(cmbBox As ComboBox) As Integer
        Dim selectedVendor As String = cmbBox.Text.Trim()
        Dim selectedID As Integer = -1 ' Default value for ID

        If Not String.IsNullOrWhiteSpace(selectedVendor) Then
            Dim connectionString As String = GlobalSettings.ConnectionString
            Dim query As String = "SELECT VndrID, VndrName FROM VendorId"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim vendorName As String = reader("VndrName").ToString().Trim()
                            Dim vendorID As Integer = Convert.ToInt32(reader("VndrID"))

                            If String.Equals(vendorName, selectedVendor, StringComparison.OrdinalIgnoreCase) Then
                                selectedID = vendorID
                                Exit While
                            End If
                        End While
                    End Using

                    connection.Close()
                End Using
            End Using
        End If
        Return selectedID
    End Function

    Private Sub cmdAddSKU_Click(sender As Object, e As EventArgs) Handles cmdAddSKU.Click
        Dim connectionString As String = GlobalSettings.ConnectionString

        Using connection As New SqlConnection(connectionString)
            Dim selectedID As Integer = GetSelectedID(cmbDestination)
            Dim query As String = "INSERT INTO tblVendorPickUpRequestSKU (PuReqNmbr, SKU, Qnty, PODueDate, Destination, MrAndLine) VALUES (@PickupNmbr, @SKU, @Qnty, @FaxDate, @Vendor, @MrAndLine)"

            Using command As New SqlCommand(query, connection)
                Dim pickupReq As Integer
                If Integer.TryParse(txtPickUpReq.Text, pickupReq) Then
                    command.Parameters.AddWithValue("@PickupNmbr", pickupReq)
                End If
                command.Parameters.AddWithValue("@SKU", cmbSKU.Text.Trim())
                Dim quantity As Integer
                If Integer.TryParse(txtQty.Text, quantity) Then
                    command.Parameters.AddWithValue("@Qnty", quantity)
                End If
                command.Parameters.AddWithValue("@FaxDate", cmbFaxDate.Text)
                command.Parameters.AddWithValue("@Vendor", selectedID)
                command.Parameters.AddWithValue("@MrAndLine", txtMrAndLine.Text)


                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using

        MessageBox.Show("Item added to request!")
        GetDataGrid()
    End Sub
End Class