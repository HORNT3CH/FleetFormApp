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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbVendor = New System.Windows.Forms.ComboBox()
        Me.cmbFaxDate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbSKU = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(1091, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Add Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(1091, 149)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "&Delete Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbVendor
        '
        Me.cmbVendor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbVendor.FormattingEnabled = True
        Me.cmbVendor.Location = New System.Drawing.Point(150, 128)
        Me.cmbVendor.Name = "cmbVendor"
        Me.cmbVendor.Size = New System.Drawing.Size(199, 25)
        Me.cmbVendor.TabIndex = 4
        '
        'cmbFaxDate
        '
        Me.cmbFaxDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbFaxDate.FormattingEnabled = True
        Me.cmbFaxDate.Location = New System.Drawing.Point(150, 166)
        Me.cmbFaxDate.Name = "cmbFaxDate"
        Me.cmbFaxDate.Size = New System.Drawing.Size(199, 25)
        Me.cmbFaxDate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Vendor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(29, 170)
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(355, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 25)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Today"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(29, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pick Up Req #"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 23)
        Me.TextBox1.TabIndex = 11
        '
        'cmbSKU
        '
        Me.cmbSKU.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbSKU.FormattingEnabled = True
        Me.cmbSKU.Location = New System.Drawing.Point(509, 81)
        Me.cmbSKU.Name = "cmbSKU"
        Me.cmbSKU.Size = New System.Drawing.Size(199, 25)
        Me.cmbSKU.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(408, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SKU"
        '
        'PickupRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSKU)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFaxDate)
        Me.Controls.Add(Me.cmbVendor)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PickupRequest"
        Me.Text = "PickupRequest"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents cmbVendor As ComboBox
    Friend WithEvents cmbFaxDate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmbSKU As ComboBox
    Friend WithEvents Label5 As Label
End Class
