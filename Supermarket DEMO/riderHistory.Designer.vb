<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderHistory
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvOrderHistory = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRider = New System.Windows.Forms.TextBox()
        Me.txtDelivery = New System.Windows.Forms.RichTextBox()
        CType(Me.dgvOrderHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(268, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "History"
        '
        'dgvOrderHistory
        '
        Me.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderHistory.Location = New System.Drawing.Point(268, 91)
        Me.dgvOrderHistory.Name = "dgvOrderHistory"
        Me.dgvOrderHistory.RowTemplate.Height = 25
        Me.dgvOrderHistory.Size = New System.Drawing.Size(601, 150)
        Me.dgvOrderHistory.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Order ID : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Customer ID :"
        '
        'txtOrderId
        '
        Me.txtOrderId.Location = New System.Drawing.Point(374, 315)
        Me.txtOrderId.Name = "txtOrderId"
        Me.txtOrderId.Size = New System.Drawing.Size(157, 23)
        Me.txtOrderId.TabIndex = 10
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(374, 372)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 23)
        Me.txtName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Plate No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(586, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Delivery Address :"
        '
        'txtRider
        '
        Me.txtRider.Location = New System.Drawing.Point(701, 315)
        Me.txtRider.Name = "txtRider"
        Me.txtRider.Size = New System.Drawing.Size(157, 23)
        Me.txtRider.TabIndex = 14
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(701, 375)
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(157, 88)
        Me.txtDelivery.TabIndex = 15
        Me.txtDelivery.Text = ""
        '
        'riderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 521)
        Me.Controls.Add(Me.txtDelivery)
        Me.Controls.Add(Me.txtRider)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtOrderId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvOrderHistory)
        Me.Controls.Add(Me.Label3)
        Me.Name = "riderHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "riderHistory"
        CType(Me.dgvOrderHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvOrderHistory As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrderId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRider As TextBox
    Friend WithEvents txtDelivery As RichTextBox
End Class
