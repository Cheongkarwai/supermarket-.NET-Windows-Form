<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderService
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
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtRiderName = New System.Windows.Forms.TextBox()
        Me.cbxRiderID = New System.Windows.Forms.ComboBox()
        Me.dateOutForDelivery = New System.Windows.Forms.DateTimePicker()
        Me.dateArrivalDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(227, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rider Service"
        '
        'dgvOrder
        '
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Location = New System.Drawing.Point(227, 83)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.RowTemplate.Height = 25
        Me.dgvOrder.Size = New System.Drawing.Size(663, 150)
        Me.dgvOrder.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Order ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Rider ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Rider Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(554, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Out For Delivery Date"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(310, 299)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(191, 23)
        Me.txtOrderID.TabIndex = 13
        '
        'txtRiderName
        '
        Me.txtRiderName.Location = New System.Drawing.Point(310, 396)
        Me.txtRiderName.Name = "txtRiderName"
        Me.txtRiderName.Size = New System.Drawing.Size(191, 23)
        Me.txtRiderName.TabIndex = 14
        '
        'cbxRiderID
        '
        Me.cbxRiderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRiderID.FormattingEnabled = True
        Me.cbxRiderID.Location = New System.Drawing.Point(310, 353)
        Me.cbxRiderID.Name = "cbxRiderID"
        Me.cbxRiderID.Size = New System.Drawing.Size(191, 23)
        Me.cbxRiderID.TabIndex = 15
        '
        'dateOutForDelivery
        '
        Me.dateOutForDelivery.Location = New System.Drawing.Point(690, 298)
        Me.dateOutForDelivery.Name = "dateOutForDelivery"
        Me.dateOutForDelivery.Size = New System.Drawing.Size(200, 23)
        Me.dateOutForDelivery.TabIndex = 16
        '
        'dateArrivalDate
        '
        Me.dateArrivalDate.Location = New System.Drawing.Point(690, 350)
        Me.dateArrivalDate.Name = "dateArrivalDate"
        Me.dateArrivalDate.Size = New System.Drawing.Size(200, 23)
        Me.dateArrivalDate.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Arrival Date"
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(783, 438)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(107, 32)
        Me.btnAccept.TabIndex = 19
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(645, 438)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 32)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'riderService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 521)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.dateArrivalDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dateOutForDelivery)
        Me.Controls.Add(Me.cbxRiderID)
        Me.Controls.Add(Me.txtRiderName)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.Label3)
        Me.Name = "riderService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "riderService"
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtRiderName As TextBox
    Friend WithEvents cbxRiderID As ComboBox
    Friend WithEvents dateOutForDelivery As DateTimePicker
    Friend WithEvents dateArrivalDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnClear As Button
End Class
