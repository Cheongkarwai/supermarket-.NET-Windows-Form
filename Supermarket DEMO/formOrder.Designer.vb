<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOrder
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnToShip = New System.Windows.Forms.Button()
        Me.btnReceived = New System.Windows.Forms.Button()
        Me.flowContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.flowContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAll)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnToShip)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReceived)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(560, 54)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(736, 54)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.White
        Me.btnAll.FlatAppearance.BorderSize = 0
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAll.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnAll.Location = New System.Drawing.Point(3, 3)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(235, 49)
        Me.btnAll.TabIndex = 0
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = False
        '
        'btnToShip
        '
        Me.btnToShip.BackColor = System.Drawing.Color.White
        Me.btnToShip.FlatAppearance.BorderSize = 0
        Me.btnToShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToShip.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnToShip.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnToShip.Location = New System.Drawing.Point(244, 3)
        Me.btnToShip.Name = "btnToShip"
        Me.btnToShip.Size = New System.Drawing.Size(235, 49)
        Me.btnToShip.TabIndex = 1
        Me.btnToShip.Text = "In Progress"
        Me.btnToShip.UseVisualStyleBackColor = False
        '
        'btnReceived
        '
        Me.btnReceived.BackColor = System.Drawing.Color.White
        Me.btnReceived.FlatAppearance.BorderSize = 0
        Me.btnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceived.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReceived.ForeColor = System.Drawing.Color.SkyBlue
        Me.btnReceived.Location = New System.Drawing.Point(485, 3)
        Me.btnReceived.Name = "btnReceived"
        Me.btnReceived.Size = New System.Drawing.Size(243, 49)
        Me.btnReceived.TabIndex = 2
        Me.btnReceived.Text = "Received"
        Me.btnReceived.UseVisualStyleBackColor = False
        '
        'flowContainer
        '
        Me.flowContainer.AutoScroll = True
        Me.flowContainer.Controls.Add(Me.Panel1)
        Me.flowContainer.Location = New System.Drawing.Point(522, 127)
        Me.flowContainer.Name = "flowContainer"
        Me.flowContainer.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.flowContainer.Size = New System.Drawing.Size(837, 501)
        Me.flowContainer.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(13, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 30, 0, 30)
        Me.Panel1.Size = New System.Drawing.Size(786, 264)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(190, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 39)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Order"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(172, 400)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 42)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Details"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'formOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1388, 678)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.flowContainer)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "formOrder"
        Me.Text = "OrderForm"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.flowContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAll As Button
    Friend WithEvents btnToShip As Button
    Friend WithEvents btnReceived As Button
    Friend WithEvents flowContainer As FlowLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
