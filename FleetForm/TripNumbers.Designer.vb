<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TripNumbers
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
        Me.cmbLTNumber = New System.Windows.Forms.ComboBox()
        Me.cmbTractorNumber = New System.Windows.Forms.ComboBox()
        Me.cmbOBTrailer = New System.Windows.Forms.ComboBox()
        Me.cmbIBTrailer = New System.Windows.Forms.ComboBox()
        Me.cmbTripDate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtActTripTime = New System.Windows.Forms.TextBox()
        Me.txtTripCost = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbLTNumber
        '
        Me.cmbLTNumber.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbLTNumber.FormattingEnabled = True
        Me.cmbLTNumber.Location = New System.Drawing.Point(139, 43)
        Me.cmbLTNumber.Name = "cmbLTNumber"
        Me.cmbLTNumber.Size = New System.Drawing.Size(173, 25)
        Me.cmbLTNumber.TabIndex = 0
        '
        'cmbTractorNumber
        '
        Me.cmbTractorNumber.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbTractorNumber.FormattingEnabled = True
        Me.cmbTractorNumber.Location = New System.Drawing.Point(139, 72)
        Me.cmbTractorNumber.Name = "cmbTractorNumber"
        Me.cmbTractorNumber.Size = New System.Drawing.Size(173, 25)
        Me.cmbTractorNumber.TabIndex = 1
        '
        'cmbOBTrailer
        '
        Me.cmbOBTrailer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbOBTrailer.FormattingEnabled = True
        Me.cmbOBTrailer.Location = New System.Drawing.Point(139, 101)
        Me.cmbOBTrailer.Name = "cmbOBTrailer"
        Me.cmbOBTrailer.Size = New System.Drawing.Size(173, 25)
        Me.cmbOBTrailer.TabIndex = 2
        '
        'cmbIBTrailer
        '
        Me.cmbIBTrailer.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbIBTrailer.FormattingEnabled = True
        Me.cmbIBTrailer.Location = New System.Drawing.Point(139, 130)
        Me.cmbIBTrailer.Name = "cmbIBTrailer"
        Me.cmbIBTrailer.Size = New System.Drawing.Size(173, 25)
        Me.cmbIBTrailer.TabIndex = 3
        '
        'cmbTripDate
        '
        Me.cmbTripDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbTripDate.FormattingEnabled = True
        Me.cmbTripDate.Location = New System.Drawing.Point(459, 43)
        Me.cmbTripDate.Name = "cmbTripDate"
        Me.cmbTripDate.Size = New System.Drawing.Size(173, 25)
        Me.cmbTripDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(15, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LT Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(15, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tractor Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "OB Trailer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(15, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "IB Trailer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(341, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Trip Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(341, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Actual Trip Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(341, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Trip Cost"
        '
        'txtActTripTime
        '
        Me.txtActTripTime.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtActTripTime.Location = New System.Drawing.Point(459, 72)
        Me.txtActTripTime.Name = "txtActTripTime"
        Me.txtActTripTime.Size = New System.Drawing.Size(173, 25)
        Me.txtActTripTime.TabIndex = 14
        '
        'txtTripCost
        '
        Me.txtTripCost.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTripCost.Location = New System.Drawing.Point(459, 103)
        Me.txtTripCost.Name = "txtTripCost"
        Me.txtTripCost.Size = New System.Drawing.Size(173, 25)
        Me.txtTripCost.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 161)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(701, 189)
        Me.DataGridView1.TabIndex = 16
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 356)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(1240, 300)
        Me.DataGridView2.TabIndex = 17
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(719, 101)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 25
        Me.DataGridView3.Size = New System.Drawing.Size(533, 249)
        Me.DataGridView3.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(719, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 46)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Add Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(826, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 46)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Daily &Schd"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(1147, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 46)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "&Find Trip"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(1040, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 46)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "&Carrier PU"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(933, 49)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 46)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Driver &Loads"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.Location = New System.Drawing.Point(646, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(62, 25)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Today"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TripNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTripCost)
        Me.Controls.Add(Me.txtActTripTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTripDate)
        Me.Controls.Add(Me.cmbIBTrailer)
        Me.Controls.Add(Me.cmbOBTrailer)
        Me.Controls.Add(Me.cmbTractorNumber)
        Me.Controls.Add(Me.cmbLTNumber)
        Me.Name = "TripNumbers"
        Me.Text = "Trip Numbers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbLTNumber As ComboBox
    Friend WithEvents cmbTractorNumber As ComboBox
    Friend WithEvents cmbOBTrailer As ComboBox
    Friend WithEvents cmbIBTrailer As ComboBox
    Friend WithEvents cmbTripDate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtActTripTime As TextBox
    Friend WithEvents txtTripCost As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
