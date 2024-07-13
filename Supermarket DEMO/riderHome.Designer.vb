<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderHome
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvOrderPending = New System.Windows.Forms.DataGridView()
        Me.dgvOrderDone = New System.Windows.Forms.DataGridView()
        Me.dgvAllOrder = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvOrderPending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAllOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Out For Delivery"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Overview "
        '
        'dgvOrderPending
        '
        Me.dgvOrderPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderPending.Location = New System.Drawing.Point(281, 90)
        Me.dgvOrderPending.Name = "dgvOrderPending"
        Me.dgvOrderPending.RowTemplate.Height = 25
        Me.dgvOrderPending.Size = New System.Drawing.Size(262, 150)
        Me.dgvOrderPending.TabIndex = 2
        '
        'dgvOrderDone
        '
        Me.dgvOrderDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDone.Location = New System.Drawing.Point(631, 90)
        Me.dgvOrderDone.Name = "dgvOrderDone"
        Me.dgvOrderDone.RowTemplate.Height = 25
        Me.dgvOrderDone.Size = New System.Drawing.Size(262, 150)
        Me.dgvOrderDone.TabIndex = 3
        '
        'dgvAllOrder
        '
        Me.dgvAllOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllOrder.Location = New System.Drawing.Point(281, 305)
        Me.dgvAllOrder.Name = "dgvAllOrder"
        Me.dgvAllOrder.RowTemplate.Height = 25
        Me.dgvAllOrder.Size = New System.Drawing.Size(612, 150)
        Me.dgvAllOrder.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(281, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Home"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(636, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Order Arrived"
        '
        'riderHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 521)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvAllOrder)
        Me.Controls.Add(Me.dgvOrderDone)
        Me.Controls.Add(Me.dgvOrderPending)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "riderHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "riderHome"
        CType(Me.dgvOrderPending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAllOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvOrderPending As DataGridView
    Friend WithEvents dgvOrderDone As DataGridView
    Friend WithEvents dgvAllOrder As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
