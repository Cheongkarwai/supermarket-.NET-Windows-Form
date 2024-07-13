<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCheckout
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
        Me.checkoutFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.checkoutBtn = New FontAwesome.Sharp.IconButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxCity = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.txtHomeAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.walletTxt = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.walletRBtn = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCheckout = New FontAwesome.Sharp.IconButton()
        Me.checkoutLeftPanel = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.checkoutLeftPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shopping Cart"
        '
        'checkoutFlowPanel
        '
        Me.checkoutFlowPanel.AutoScroll = True
        Me.checkoutFlowPanel.Location = New System.Drawing.Point(39, 122)
        Me.checkoutFlowPanel.Name = "checkoutFlowPanel"
        Me.checkoutFlowPanel.Size = New System.Drawing.Size(732, 342)
        Me.checkoutFlowPanel.TabIndex = 1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(39, 60)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(702, 48)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 45)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(115, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Product"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(309, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 45)
        Me.Panel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(70, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Quantity"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(515, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 45)
        Me.Panel4.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(64, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(551, 480)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subtotal:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubtotal.Location = New System.Drawing.Point(657, 479)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(83, 19)
        Me.lblSubtotal.TabIndex = 5
        Me.lblSubtotal.Text = "RM 300.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(551, 517)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 19)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Shipping:"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblShipping.Location = New System.Drawing.Point(657, 517)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(63, 19)
        Me.lblShipping.TabIndex = 7
        Me.lblShipping.Text = "RM 2.99"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(551, 558)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 19)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(657, 558)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 19)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "RM 302.99"
        '
        'checkoutBtn
        '
        Me.checkoutBtn.BackColor = System.Drawing.Color.White
        Me.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkoutBtn.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.checkoutBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft
        Me.checkoutBtn.IconColor = System.Drawing.Color.Black
        Me.checkoutBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.checkoutBtn.Location = New System.Drawing.Point(39, 531)
        Me.checkoutBtn.Name = "checkoutBtn"
        Me.checkoutBtn.Size = New System.Drawing.Size(210, 46)
        Me.checkoutBtn.TabIndex = 10
        Me.checkoutBtn.Text = "Continue Shopping"
        Me.checkoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.checkoutBtn.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Controls.Add(Me.txtPostcode)
        Me.Panel10.Controls.Add(Me.Label22)
        Me.Panel10.Controls.Add(Me.cbxCity)
        Me.Panel10.Controls.Add(Me.Label9)
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.cbxState)
        Me.Panel10.Controls.Add(Me.txtHomeAddress)
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Location = New System.Drawing.Point(891, 36)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(447, 513)
        Me.Panel10.TabIndex = 11
        '
        'txtPostcode
        '
        Me.txtPostcode.BackColor = System.Drawing.Color.White
        Me.txtPostcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostcode.Location = New System.Drawing.Point(215, 377)
        Me.txtPostcode.MaxLength = 5
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(129, 23)
        Me.txtPostcode.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(40, 422)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 16)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "City"
        '
        'cbxCity
        '
        Me.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCity.FormattingEnabled = True
        Me.cbxCity.Location = New System.Drawing.Point(40, 441)
        Me.cbxCity.Name = "cbxCity"
        Me.cbxCity.Size = New System.Drawing.Size(121, 23)
        Me.cbxCity.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(215, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Postcode"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(40, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "State"
        '
        'cbxState
        '
        Me.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(40, 376)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(121, 23)
        Me.cbxState.TabIndex = 12
        '
        'txtHomeAddress
        '
        Me.txtHomeAddress.BackColor = System.Drawing.Color.White
        Me.txtHomeAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHomeAddress.Location = New System.Drawing.Point(40, 295)
        Me.txtHomeAddress.Name = "txtHomeAddress"
        Me.txtHomeAddress.Size = New System.Drawing.Size(372, 23)
        Me.txtHomeAddress.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(40, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Home Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(34, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address Information"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.walletTxt)
        Me.Panel11.Controls.Add(Me.Label20)
        Me.Panel11.Controls.Add(Me.Label19)
        Me.Panel11.Controls.Add(Me.walletRBtn)
        Me.Panel11.Location = New System.Drawing.Point(40, 122)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(385, 42)
        Me.Panel11.TabIndex = 4
        '
        'walletTxt
        '
        Me.walletTxt.AutoSize = True
        Me.walletTxt.Location = New System.Drawing.Point(301, 13)
        Me.walletTxt.Name = "walletTxt"
        Me.walletTxt.Size = New System.Drawing.Size(49, 15)
        Me.walletTxt.TabIndex = 5
        Me.walletTxt.Text = "RM 0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(244, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 15)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Balance:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(44, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 15)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Wallet"
        '
        'walletRBtn
        '
        Me.walletRBtn.AutoSize = True
        Me.walletRBtn.Font = New System.Drawing.Font("Bahnschrift Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.walletRBtn.Location = New System.Drawing.Point(12, 13)
        Me.walletRBtn.Name = "walletRBtn"
        Me.walletRBtn.Size = New System.Drawing.Size(14, 13)
        Me.walletRBtn.TabIndex = 2
        Me.walletRBtn.TabStop = True
        Me.walletRBtn.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(40, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Payment Method"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(34, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Payment Info"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.White
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnCheckout.IconColor = System.Drawing.Color.Black
        Me.btnCheckout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCheckout.Location = New System.Drawing.Point(912, 567)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(404, 46)
        Me.btnCheckout.TabIndex = 12
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'checkoutLeftPanel
        '
        Me.checkoutLeftPanel.Controls.Add(Me.lblShipping)
        Me.checkoutLeftPanel.Controls.Add(Me.Label2)
        Me.checkoutLeftPanel.Controls.Add(Me.lblSubtotal)
        Me.checkoutLeftPanel.Controls.Add(Me.FlowLayoutPanel2)
        Me.checkoutLeftPanel.Controls.Add(Me.checkoutBtn)
        Me.checkoutLeftPanel.Controls.Add(Me.checkoutFlowPanel)
        Me.checkoutLeftPanel.Controls.Add(Me.Label13)
        Me.checkoutLeftPanel.Controls.Add(Me.Label1)
        Me.checkoutLeftPanel.Controls.Add(Me.lblTotal)
        Me.checkoutLeftPanel.Controls.Add(Me.Label15)
        Me.checkoutLeftPanel.Location = New System.Drawing.Point(35, 36)
        Me.checkoutLeftPanel.Name = "checkoutLeftPanel"
        Me.checkoutLeftPanel.Size = New System.Drawing.Size(850, 603)
        Me.checkoutLeftPanel.TabIndex = 13
        '
        'Panel13
        '
        Me.Panel13.Location = New System.Drawing.Point(906, 674)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(200, 38)
        Me.Panel13.TabIndex = 14
        '
        'formCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1363, 678)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.checkoutLeftPanel)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.Panel10)
        Me.Name = "formCheckout"
        Me.Text = "formCheckout"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.checkoutLeftPanel.ResumeLayout(False)
        Me.checkoutLeftPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents checkoutFlowPanel As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents checkoutBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents walletTxt As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents walletRBtn As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnCheckout As FontAwesome.Sharp.IconButton
    Friend WithEvents checkoutLeftPanel As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxCity As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxState As ComboBox
    Friend WithEvents txtHomeAddress As TextBox
    Friend WithEvents txtPostcode As TextBox
End Class
