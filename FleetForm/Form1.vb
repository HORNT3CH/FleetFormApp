Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub EnterTripNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterTripNumberToolStripMenuItem.Click
        Dim n As New TripNumbers
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub PickupRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickupRequestToolStripMenuItem.Click
        Dim n As New PickupRequest
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub EnterVendorInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterVendorInformationToolStripMenuItem.Click
        Dim n As New VendorInfo
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Dim n As New ReportDashboard
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()
    End Sub
End Class
