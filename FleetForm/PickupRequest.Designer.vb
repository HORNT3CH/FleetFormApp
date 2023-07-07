<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickupRequest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAddPickup = New System.Windows.Forms.Button()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.cmbFaxDate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdToday = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPickUpReq = New System.Windows.Forms.TextBox()
        Me.cmbSKU = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMrAndLine = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdAddSKU = New System.Windows.Forms.Button()
        Me.cmbDestination = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pick Up Request Entry Form"
        '
        'cmdAddPickup
        '
        Me.cmdAddPickup.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdAddPickup.Location = New System.Drawing.Point(1015, 92)
        Me.cmdAddPickup.Name = "cmdAddPickup"
        Me.cmdAddPickup.Size = New System.Drawing.Size(133, 42)
        Me.cmdAddPickup.TabIndex = 1
        Me.cmdAddPickup.Text = "&Add Pickup"
        Me.cmdAddPickup.UseVisualStyleBackColor = True
        '
        'cmbVendor
        '
        Me.cmbVendor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(270, 134)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(199, 25)
        Me.cmbVendor.TabIndex = 4
        '
        'cmbFaxDate
        '
        Me.cmbFaxDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbFaxDate.FormattingEnabled = True
        Me.cmbFaxDate.Location = New System.Drawing.Point(270, 172)
        Me.cmbFaxDate.Name = "cmbFaxDate"
        Me.cmbFaxDate.Size = New System.Drawing.Size(199, 25)
        Me.cmbFaxDate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(149, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vendor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(149, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fax Date"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 394)
        Me.DataGridView1.TabIndex = 8
        '
        'cmdToday
        '
        Me.cmdToday.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdToday.Location = New System.Drawing.Point(475, 173)
        Me.cmdToday.Name = "cmdToday"
        Me.cmdToday.Size = New System.Drawing.Size(87, 25)
        Me.cmdToday.TabIndex = 9
        Me.cmdToday.Text = "Today"
        Me.cmdToday.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(149, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pick Up Req #"
        '
        'txtPickUpReq
        '
        Me.txtPickUpReq.Location = New System.Drawing.Point(270, 91)
        Me.txtPickUpReq.Name = "txtPickUpReq"
        Me.txtPickUpReq.Size = New System.Drawing.Size(199, 23)
        Me.txtPickUpReq.TabIndex = 11
        '
        'cmbSKU
        '
        Me.cmbSKU.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbSKU.FormattingEnabled = True
        Me.cmbSKU.Location = New System.Drawing.Point(719, 89)
        Me.cmbSKU.Name = "cmbSKU"
        Me.cmbSKU.Size = New System.Drawing.Size(199, 25)
        Me.cmbSKU.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(592, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SKU"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(719, 134)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(81, 23)
        Me.txtQty.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(592, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "QTY"
        '
        'txtMrAndLine
        '
        Me.txtMrAndLine.Location = New System.Drawing.Point(719, 174)
        Me.txtMrAndLine.Name = "txtMrAndLine"
        Me.txtMrAndLine.Size = New System.Drawing.Size(199, 23)
        Me.txtMrAndLine.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(592, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "MrAndLine"
        '
        'cmdAddSKU
        '
        Me.cmdAddSKU.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmdAddSKU.Location = New System.Drawing.Point(1015, 153)
        Me.cmdAddSKU.Name = "cmdAddSKU"
        Me.cmdAddSKU.Size = New System.Drawing.Size(133, 42)
        Me.cmdAddSKU.TabIndex = 19
        Me.cmdAddSKU.Text = "Add &SKU"
        Me.cmdAddSKU.UseVisualStyleBackColor = True
        '
        'cmbDestination
        '
        Me.cmbDestination.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbDestination.FormattingEnabled = True
        Me.cmbDestination.Location = New System.Drawing.Point(719, 222)
        Me.cmbDestination.Name = "cmbDestination"
        Me.cmbDestination.Size = New System.Drawing.Size(199, 25)
        Me.cmbDestination.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(592, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Destination"
        '
        'PickupRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbDestination)
        Me.Controls.Add(Me.cmdAddSKU)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMrAndLine)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSKU)
        Me.Controls.Add(Me.txtPickUpReq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdToday)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFaxDate)
        Me.Controls.Add(Me.cmbVendor)
        Me.Controls.Add(Me.cmdAddPickup)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PickupRequest"
        Me.Text = "PickupRequest"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAddPickup As Button
    Friend WithEvents cmbVendor As ComboBox
    Friend WithEvents cmbFaxDate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdToday As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPickUpReq As TextBox
    Friend WithEvents cmbSKU As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMrAndLine As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdAddSKU As Button
    Friend WithEvents cmbDestination As ComboBox
    Friend WithEvents Label8 As Label
End Class
