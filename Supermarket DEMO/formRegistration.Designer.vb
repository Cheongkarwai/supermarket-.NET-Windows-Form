<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRegistration
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dobPicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnCreateAcc = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.nameWarning = New System.Windows.Forms.Label()
        Me.emailWarning = New System.Windows.Forms.Label()
        Me.contactWarning = New System.Windows.Forms.Label()
        Me.usernameWarning = New System.Windows.Forms.Label()
        Me.passwordWarning = New System.Windows.Forms.Label()
        Me.confirmWarning = New System.Windows.Forms.Label()
        Me.dobWarning = New System.Windows.Forms.Label()
        Me.contactInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.emailInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.dobInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.a = New FontAwesome.Sharp.IconPictureBox()
        Me.usernameInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.passwordInfo = New FontAwesome.Sharp.IconPictureBox()
        Me.info = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contactInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dobInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernameInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SkyBlue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(51, 363)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(129, 32)
        Me.btnLogin.TabIndex = 15
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(38, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 65)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Already have account?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Supermarket_DEMO.My.Resources.Resources.login_backgroundimg
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 510)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(289, 184)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(289, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.SkyBlue
        Me.Label5.Location = New System.Drawing.Point(287, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 35)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Registration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(289, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Date Of Birth"
        '
        'dobPicker
        '
        Me.dobPicker.Font = New System.Drawing.Font("Bahnschrift Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dobPicker.Location = New System.Drawing.Point(287, 244)
        Me.dobPicker.Name = "dobPicker"
        Me.dobPicker.Size = New System.Drawing.Size(202, 22)
        Me.dobPicker.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(287, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 26
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEmail.Location = New System.Drawing.Point(289, 331)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = "eg. example.@gmail.com"
        Me.txtEmail.Size = New System.Drawing.Size(200, 16)
        Me.txtEmail.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(287, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Email Address"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(558, 184)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 1)
        Me.Panel3.TabIndex = 28
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.Location = New System.Drawing.Point(558, 166)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderText = "Enter your username"
        Me.txtUsername.Size = New System.Drawing.Size(200, 16)
        Me.txtUsername.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(558, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(558, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Password"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(558, 263)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 1)
        Me.Panel4.TabIndex = 31
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPassword.Location = New System.Drawing.Point(558, 245)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PlaceholderText = "Enter your password"
        Me.txtPassword.Size = New System.Drawing.Size(200, 16)
        Me.txtPassword.TabIndex = 30
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(558, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 19)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Confirm Password"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(558, 349)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 1)
        Me.Panel5.TabIndex = 34
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(558, 331)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PlaceholderText = "Confirm your password"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(200, 16)
        Me.txtConfirmPassword.TabIndex = 33
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContact.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContact.Location = New System.Drawing.Point(287, 414)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PlaceholderText = "eg. 01128188291"
        Me.txtContact.Size = New System.Drawing.Size(200, 16)
        Me.txtContact.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(287, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Contact No"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(287, 432)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 1)
        Me.Panel6.TabIndex = 27
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCreateAcc.FlatAppearance.BorderSize = 0
        Me.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAcc.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateAcc.ForeColor = System.Drawing.Color.White
        Me.btnCreateAcc.Location = New System.Drawing.Point(558, 401)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(200, 32)
        Me.btnCreateAcc.TabIndex = 38
        Me.btnCreateAcc.Text = "Create Account"
        Me.btnCreateAcc.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(289, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.PlaceholderText = "Enter your name"
        Me.txtName.Size = New System.Drawing.Size(200, 16)
        Me.txtName.TabIndex = 39
        '
        'nameWarning
        '
        Me.nameWarning.AutoSize = True
        Me.nameWarning.ForeColor = System.Drawing.Color.Red
        Me.nameWarning.Location = New System.Drawing.Point(340, 134)
        Me.nameWarning.Name = "nameWarning"
        Me.nameWarning.Size = New System.Drawing.Size(12, 15)
        Me.nameWarning.TabIndex = 40
        Me.nameWarning.Text = "*"
        Me.nameWarning.Visible = False
        '
        'emailWarning
        '
        Me.emailWarning.AutoSize = True
        Me.emailWarning.ForeColor = System.Drawing.Color.Red
        Me.emailWarning.Location = New System.Drawing.Point(394, 297)
        Me.emailWarning.Name = "emailWarning"
        Me.emailWarning.Size = New System.Drawing.Size(12, 15)
        Me.emailWarning.TabIndex = 41
        Me.emailWarning.Text = "*"
        Me.emailWarning.Visible = False
        '
        'contactWarning
        '
        Me.contactWarning.AutoSize = True
        Me.contactWarning.ForeColor = System.Drawing.Color.Red
        Me.contactWarning.Location = New System.Drawing.Point(369, 380)
        Me.contactWarning.Name = "contactWarning"
        Me.contactWarning.Size = New System.Drawing.Size(12, 15)
        Me.contactWarning.TabIndex = 42
        Me.contactWarning.Text = "*"
        Me.contactWarning.Visible = False
        '
        'usernameWarning
        '
        Me.usernameWarning.AutoSize = True
        Me.usernameWarning.ForeColor = System.Drawing.Color.Red
        Me.usernameWarning.Location = New System.Drawing.Point(637, 134)
        Me.usernameWarning.Name = "usernameWarning"
        Me.usernameWarning.Size = New System.Drawing.Size(12, 15)
        Me.usernameWarning.TabIndex = 43
        Me.usernameWarning.Text = "*"
        Me.usernameWarning.Visible = False
        '
        'passwordWarning
        '
        Me.passwordWarning.AutoSize = True
        Me.passwordWarning.ForeColor = System.Drawing.Color.Red
        Me.passwordWarning.Location = New System.Drawing.Point(635, 211)
        Me.passwordWarning.Name = "passwordWarning"
        Me.passwordWarning.Size = New System.Drawing.Size(12, 15)
        Me.passwordWarning.TabIndex = 44
        Me.passwordWarning.Text = "*"
        Me.passwordWarning.Visible = False
        '
        'confirmWarning
        '
        Me.confirmWarning.AutoSize = True
        Me.confirmWarning.ForeColor = System.Drawing.Color.Red
        Me.confirmWarning.Location = New System.Drawing.Point(689, 297)
        Me.confirmWarning.Name = "confirmWarning"
        Me.confirmWarning.Size = New System.Drawing.Size(12, 15)
        Me.confirmWarning.TabIndex = 45
        Me.confirmWarning.Text = "*"
        Me.confirmWarning.Visible = False
        '
        'dobWarning
        '
        Me.dobWarning.AutoSize = True
        Me.dobWarning.ForeColor = System.Drawing.Color.Red
        Me.dobWarning.Location = New System.Drawing.Point(387, 211)
        Me.dobWarning.Name = "dobWarning"
        Me.dobWarning.Size = New System.Drawing.Size(12, 15)
        Me.dobWarning.TabIndex = 46
        Me.dobWarning.Text = "*"
        Me.dobWarning.Visible = False
        '
        'contactInfo
        '
        Me.contactInfo.BackColor = System.Drawing.Color.White
        Me.contactInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.contactInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.contactInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.contactInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.contactInfo.IconSize = 23
        Me.contactInfo.Location = New System.Drawing.Point(394, 380)
        Me.contactInfo.Name = "contactInfo"
        Me.contactInfo.Size = New System.Drawing.Size(24, 23)
        Me.contactInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.contactInfo.TabIndex = 47
        Me.contactInfo.TabStop = False
        Me.info.SetToolTip(Me.contactInfo, "example 011********")
        '
        'emailInfo
        '
        Me.emailInfo.BackColor = System.Drawing.Color.White
        Me.emailInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.emailInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.emailInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.emailInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.emailInfo.IconSize = 23
        Me.emailInfo.Location = New System.Drawing.Point(412, 299)
        Me.emailInfo.Name = "emailInfo"
        Me.emailInfo.Size = New System.Drawing.Size(24, 23)
        Me.emailInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.emailInfo.TabIndex = 48
        Me.emailInfo.TabStop = False
        Me.info.SetToolTip(Me.emailInfo, "example a@gmail.com")
        '
        'dobInfo
        '
        Me.dobInfo.BackColor = System.Drawing.Color.White
        Me.dobInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dobInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.dobInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.dobInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.dobInfo.IconSize = 23
        Me.dobInfo.Location = New System.Drawing.Point(412, 211)
        Me.dobInfo.Name = "dobInfo"
        Me.dobInfo.Size = New System.Drawing.Size(24, 23)
        Me.dobInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dobInfo.TabIndex = 49
        Me.dobInfo.TabStop = False
        Me.info.SetToolTip(Me.dobInfo, "Must be atleast 12 years old")
        '
        'a
        '
        Me.a.BackColor = System.Drawing.Color.White
        Me.a.ForeColor = System.Drawing.SystemColors.ControlText
        Me.a.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.a.IconColor = System.Drawing.SystemColors.ControlText
        Me.a.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.a.IconSize = 23
        Me.a.Location = New System.Drawing.Point(358, 134)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(24, 23)
        Me.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.a.TabIndex = 50
        Me.a.TabStop = False
        Me.info.SetToolTip(Me.a, "Name must be in letter format")
        '
        'usernameInfo
        '
        Me.usernameInfo.BackColor = System.Drawing.Color.White
        Me.usernameInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.usernameInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.usernameInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.usernameInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.usernameInfo.IconSize = 23
        Me.usernameInfo.Location = New System.Drawing.Point(655, 134)
        Me.usernameInfo.Name = "usernameInfo"
        Me.usernameInfo.Size = New System.Drawing.Size(24, 23)
        Me.usernameInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usernameInfo.TabIndex = 51
        Me.usernameInfo.TabStop = False
        Me.info.SetToolTip(Me.usernameInfo, "Must atleast contain 5 characters")
        '
        'passwordInfo
        '
        Me.passwordInfo.BackColor = System.Drawing.Color.White
        Me.passwordInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.passwordInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle
        Me.passwordInfo.IconColor = System.Drawing.SystemColors.ControlText
        Me.passwordInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.passwordInfo.IconSize = 23
        Me.passwordInfo.Location = New System.Drawing.Point(653, 211)
        Me.passwordInfo.Name = "passwordInfo"
        Me.passwordInfo.Size = New System.Drawing.Size(24, 23)
        Me.passwordInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passwordInfo.TabIndex = 52
        Me.passwordInfo.TabStop = False
        Me.info.SetToolTip(Me.passwordInfo, "Must be atleast 6 characters")
        '
        'info
        '
        Me.info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'formRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(819, 509)
        Me.Controls.Add(Me.passwordInfo)
        Me.Controls.Add(Me.usernameInfo)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.dobInfo)
        Me.Controls.Add(Me.emailInfo)
        Me.Controls.Add(Me.contactInfo)
        Me.Controls.Add(Me.dobWarning)
        Me.Controls.Add(Me.confirmWarning)
        Me.Controls.Add(Me.passwordWarning)
        Me.Controls.Add(Me.usernameWarning)
        Me.Controls.Add(Me.contactWarning)
        Me.Controls.Add(Me.emailWarning)
        Me.Controls.Add(Me.nameWarning)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCreateAcc)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dobPicker)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "formRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Registration"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contactInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dobInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernameInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dobPicker As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnCreateAcc As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents nameWarning As Label
    Friend WithEvents emailWarning As Label
    Friend WithEvents contactWarning As Label
    Friend WithEvents usernameWarning As Label
    Friend WithEvents passwordWarning As Label
    Friend WithEvents confirmWarning As Label
    Friend WithEvents dobWarning As Label
    Friend WithEvents contactInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents info As ToolTip
    Friend WithEvents emailInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents dobInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents a As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents usernameInfo As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents passwordInfo As FontAwesome.Sharp.IconPictureBox
End Class
