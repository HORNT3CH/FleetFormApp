<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TripNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterTripNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickupRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterVendorInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TripNumbersToolStripMenuItem, Me.VendorInformationToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TripNumbersToolStripMenuItem
        '
        Me.TripNumbersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterTripNumberToolStripMenuItem, Me.PickupRequestToolStripMenuItem})
        Me.TripNumbersToolStripMenuItem.Name = "TripNumbersToolStripMenuItem"
        Me.TripNumbersToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.TripNumbersToolStripMenuItem.Text = "Trip Numbers"
        '
        'EnterTripNumberToolStripMenuItem
        '
        Me.EnterTripNumberToolStripMenuItem.Name = "EnterTripNumberToolStripMenuItem"
        Me.EnterTripNumberToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnterTripNumberToolStripMenuItem.Text = "Enter Trip Number"
        '
        'PickupRequestToolStripMenuItem
        '
        Me.PickupRequestToolStripMenuItem.Name = "PickupRequestToolStripMenuItem"
        Me.PickupRequestToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PickupRequestToolStripMenuItem.Text = "Pickup Request"
        '
        'VendorInformationToolStripMenuItem
        '
        Me.VendorInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterVendorInformationToolStripMenuItem})
        Me.VendorInformationToolStripMenuItem.Name = "VendorInformationToolStripMenuItem"
        Me.VendorInformationToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.VendorInformationToolStripMenuItem.Text = "Vendor Information"
        '
        'EnterVendorInformationToolStripMenuItem
        '
        Me.EnterVendorInformationToolStripMenuItem.Name = "EnterVendorInformationToolStripMenuItem"
        Me.EnterVendorInformationToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.EnterVendorInformationToolStripMenuItem.Text = "Enter Vendor Information"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Fleet Scheduler"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TripNumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterTripNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PickupRequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterVendorInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
End Class
