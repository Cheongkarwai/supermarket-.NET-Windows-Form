<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccount
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
        Me.components = New System.ComponentModel.Container()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.editProfileBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.passwordWarning = New System.Windows.Forms.Label()
        Me.contactWarning = New System.Windows.Forms.Label()
        Me.emailWarning = New System.Windows.Forms.Label()
        Me.nameWarning = New System.Windows.Forms.Label()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.ToolTip(Me.components)
        Me.passwordInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.nameInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.emailInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.contactInfo = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.passwordInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contactInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(80, 254)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(258, 20)
        Me.txtName.TabIndex = 0
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContact.Location = New System.Drawing.Point(80, 417)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(258, 20)
        Me.txtContact.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(80, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.Location = New System.Drawing.Point(466, 254)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(258, 20)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(466, 333)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(258, 20)
        Me.txtPassword.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(80, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 45)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "My Account"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(80, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Personal Information"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(80, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1201, 1)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(80, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 1)
        Me.Panel2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(80, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(80, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Contact No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(466, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(466, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(80, 333)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(258, 20)
        Me.txtEmail.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(80, 352)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(258, 1)
        Me.Panel3.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(80, 439)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(258, 1)
        Me.Panel4.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(466, 273)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(258, 1)
        Me.Panel5.TabIndex = 15
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(466, 352)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(258, 1)
        Me.Panel6.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(80, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Wallet"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(80, 520)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1201, 1)
        Me.Panel7.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(80, 545)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Balance"
        '
        'txtBalance
        '
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBalance.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBalance.Location = New System.Drawing.Point(80, 577)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(258, 20)
        Me.txtBalance.TabIndex = 21
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(80, 596)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(258, 1)
        Me.Panel8.TabIndex = 17
        '
        'editProfileBtn
        '
        Me.editProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editProfileBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.editProfileBtn.Location = New System.Drawing.Point(928, 401)
        Me.editProfileBtn.Name = "editProfileBtn"
        Me.editProfileBtn.Size = New System.Drawing.Size(126, 39)
        Me.editProfileBtn.TabIndex = 22
        Me.editProfileBtn.Text = "Edit Profile"
        Me.editProfileBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.Button2.FlatAppearance.BorderSize = 4
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(80, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 4)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cancelBtn.Location = New System.Drawing.Point(1090, 401)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(126, 39)
        Me.cancelBtn.TabIndex = 24
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        Me.cancelBtn.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(1125, 695)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 33)
        Me.Panel9.TabIndex = 26
        '
        'passwordWarning
        '
        Me.passwordWarning.AutoSize = True
        Me.passwordWarning.ForeColor = System.Drawing.Color.Red
        Me.passwordWarning.Location = New System.Drawing.Point(553, 306)
        Me.passwordWarning.Name = "passwordWarning"
        Me.passwordWarning.Size = New System.Drawing.Size(12, 15)
        Me.passwordWarning.TabIndex = 49
        Me.passwordWarning.Text = "*"
        Me.passwordWarning.Visible = False
        '
        'contactWarning
        '
        Me.contactWarning.AutoSize = True
        Me.contactWarning.ForeColor = System.Drawing.Color.Red
        Me.contactWarning.Location = New System.Drawing.Point(174, 391)
        Me.contactWarning.Name = "contactWarning"
        Me.contactWarning.Size = New System.Drawing.Size(12, 15)
        Me.contactWarning.TabIndex = 47
        Me.contactWarning.Text = "*"
        Me.contactWarning.Visible = False
        '
        'emailWarning
        '
        Me.emailWarning.AutoSize = True
        Me.emailWarning.ForeColor = System.Drawing.Color.Red
        Me.emailWarning.Location = New System.Drawing.Point(205, 306)
        Me.emailWarning.Name = "emailWarning"
        Me.emailWarning.Size = New System.Drawing.Size(12, 15)
        Me.emailWarning.TabIndex = 46
        Me.emailWarning.Text = "*"
        Me.emailWarning.Visible = False
        '
        'nameWarning
        '
        Me.nameWarning.AutoSize = True
        Me.nameWarning.ForeColor = System.Drawing.Color.Red
        Me.nameWarning.Location = New System.Drawing.Point(138, 229)
        Me.nameWarning.Name = "nameWarning"
        Me.nameWarning.Size = New System.Drawing.Size(12, 15)
        Me.nameWarning.TabIndex = 45
        Me.nameWarning.Text = "*"
        Me.nameWarning.Visible = False
        '
        'confirmBtn
        '
        Me.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.confirmBtn.Location = New System.Drawing.Point(1090, 343)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(126, 39)
        Me.confirmBtn.TabIndex = 50
        Me.confirmBtn.Text = "Confirm"
        Me.confirmBtn.UseVisualStyleBackColor = True
        Me.confirmBtn.Visible = False
        '
        'info
        '
        Me.info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'passwordInfo
        '
        Me.passwordInfo.BackColor = System.Drawing.Color.White
        Me.passwordInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.passwordInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.passwordInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.passwordInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.passwordInfo.IconSize = 23
        Me.passwordInfo.Location = New System.Drawing.Point(571, 304)
        Me.passwordInfo.Name = "passwordInfo"
        Me.passwordInfo.Size = New System.Drawing.Size(24, 23)
        Me.passwordInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passwordInfo.TabIndex = 56
        Me.passwordInfo.TabStop = False
        Me.info.SetToolTip(Me.passwordInfo, "Must be atleast 6 characters")
        Me.passwordInfo.Visible = False
        '
        'nameInfo
        '
        Me.nameInfo.BackColor = System.Drawing.Color.White
        Me.nameInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.nameInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.nameInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.nameInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.nameInfo.IconSize = 23
        Me.nameInfo.Location = New System.Drawing.Point(162, 225)
        Me.nameInfo.Name = "nameInfo"
        Me.nameInfo.Size = New System.Drawing.Size(24, 23)
        Me.nameInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nameInfo.TabIndex = 55
        Me.nameInfo.TabStop = False
        Me.info.SetToolTip(Me.nameInfo, "Name must be in letter format")
        Me.nameInfo.Visible = False
        '
        'emailInfo
        '
        Me.emailInfo.BackColor = System.Drawing.Color.White
        Me.emailInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.emailInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.emailInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.emailInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.emailInfo.IconSize = 23
        Me.emailInfo.Location = New System.Drawing.Point(223, 304)
        Me.emailInfo.Name = "emailInfo"
        Me.emailInfo.Size = New System.Drawing.Size(24, 23)
        Me.emailInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.emailInfo.TabIndex = 54
        Me.emailInfo.TabStop = False
        Me.info.SetToolTip(Me.emailInfo, "example a@gmail.com")
        Me.emailInfo.Visible = False
        '
        'contactInfo
        '
        Me.contactInfo.BackColor = System.Drawing.Color.White
        Me.contactInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.contactInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.contactInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.contactInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.contactInfo.IconSize = 23
        Me.contactInfo.Location = New System.Drawing.Point(193, 387)
        Me.contactInfo.Name = "contactInfo"
        Me.contactInfo.Size = New System.Drawing.Size(24, 23)
        Me.contactInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.contactInfo.TabIndex = 53
        Me.contactInfo.TabStop = False
        Me.info.SetToolTip(Me.contactInfo, "example 011********")
        Me.contactInfo.Visible = False
        '
        'formAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1388, 678)
        Me.Controls.Add(Me.passwordInfo)
        Me.Controls.Add(Me.nameInfo)
        Me.Controls.Add(Me.emailInfo)
        Me.Controls.Add(Me.contactInfo)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.passwordWarning)
        Me.Controls.Add(Me.contactWarning)
        Me.Controls.Add(Me.emailWarning)
        Me.Controls.Add(Me.nameWarning)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.editProfileBtn)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtName)
        Me.Name = "formAccount"
        Me.Text = "formAccount"
        CType(Me.passwordInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contactInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents editProfileBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents passwordWarning As Label
    Friend WithEvents contactWarning As Label
    Friend WithEvents emailWarning As Label
    Friend WithEvents nameWarning As Label
    Friend WithEvents confirmBtn As Button
    Friend WithEvents info As ToolTip
    Friend WithEvents passwordInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents nameInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents emailInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents contactInfo As FontAwesome.Sharp.IconPictureBox
End Class
