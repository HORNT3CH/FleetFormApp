<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StiRibbonViewerControl1 = New Stimulsoft.Report.Viewer.StiRibbonViewerControl()
        Me.SuspendLayout()
        '
        'StiRibbonViewerControl1
        '
        Me.StiRibbonViewerControl1.AllowDrop = True
        Me.StiRibbonViewerControl1.Location = New System.Drawing.Point(3, 0)
        Me.StiRibbonViewerControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StiRibbonViewerControl1.Name = "StiRibbonViewerControl1"
        Me.StiRibbonViewerControl1.Report = Nothing
        Me.StiRibbonViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StiRibbonViewerControl1.ShowZoom = True
        Me.StiRibbonViewerControl1.Size = New System.Drawing.Size(1263, 683)
        Me.StiRibbonViewerControl1.TabIndex = 0
        '
        'ReportDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.StiRibbonViewerControl1)
        Me.Name = "ReportDashboard"
        Me.Text = "ReportDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StiRibbonViewerControl1 As Stimulsoft.Report.Viewer.StiRibbonViewerControl
End Class
