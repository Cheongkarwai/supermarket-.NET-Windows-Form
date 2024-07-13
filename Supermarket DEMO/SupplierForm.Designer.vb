<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SupplierForm
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
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.udlProduct = New System.Windows.Forms.Button()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.btnAccount = New FontAwesome.Sharp.IconButton()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.udlAccount = New System.Windows.Forms.Button()
        Me.udlHome = New System.Windows.Forms.Button()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelLogout = New System.Windows.Forms.Panel()
        Me.linkLogout = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMain.SuspendLayout()
        Me.panelLogout.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.IconSize = 30
        Me.btnHome.Location = New System.Drawing.Point(329, 30)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(121, 45)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight
        Me.btnInventory.IconColor = System.Drawing.Color.Black
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 30
        Me.btnInventory.Location = New System.Drawing.Point(523, 30)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(121, 45)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'udlProduct
        '
        Me.udlProduct.FlatAppearance.BorderSize = 10
        Me.udlProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlProduct.Location = New System.Drawing.Point(523, 76)
        Me.udlProduct.Name = "udlProduct"
        Me.udlProduct.Size = New System.Drawing.Size(121, 2)
        Me.udlProduct.TabIndex = 5
        Me.udlProduct.UseVisualStyleBackColor = True
        '
        'panelForm
        '
        Me.panelForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelForm.Location = New System.Drawing.Point(0, 137)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1382, 667)
        Me.panelForm.TabIndex = 11
        '
        'btnAccount
        '
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAccount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnAccount.IconColor = System.Drawing.Color.Black
        Me.btnAccount.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAccount.IconSize = 25
        Me.btnAccount.Location = New System.Drawing.Point(731, 30)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(121, 45)
        Me.btnAccount.TabIndex = 13
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.linkLogin.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.linkLogin.Location = New System.Drawing.Point(1205, 44)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(108, 18)
        Me.linkLogin.TabIndex = 15
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Login/Register"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1382, 1)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Supermarket_DEMO.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(79, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'udlAccount
        '
        Me.udlAccount.FlatAppearance.BorderSize = 2
        Me.udlAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlAccount.Location = New System.Drawing.Point(731, 76)
        Me.udlAccount.Name = "udlAccount"
        Me.udlAccount.Size = New System.Drawing.Size(121, 2)
        Me.udlAccount.TabIndex = 17
        Me.udlAccount.UseVisualStyleBackColor = True
        '
        'udlHome
        '
        Me.udlHome.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.udlHome.FlatAppearance.BorderSize = 20
        Me.udlHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlHome.Location = New System.Drawing.Point(329, 76)
        Me.udlHome.Name = "udlHome"
        Me.udlHome.Size = New System.Drawing.Size(121, 2)
        Me.udlHome.TabIndex = 3
        Me.udlHome.UseVisualStyleBackColor = True
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelLogout)
        Me.panelMain.Controls.Add(Me.udlHome)
        Me.panelMain.Controls.Add(Me.udlAccount)
        Me.panelMain.Controls.Add(Me.PictureBox1)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.linkLogin)
        Me.panelMain.Controls.Add(Me.btnAccount)
        Me.panelMain.Controls.Add(Me.panelForm)
        Me.panelMain.Controls.Add(Me.udlProduct)
        Me.panelMain.Controls.Add(Me.btnInventory)
        Me.panelMain.Controls.Add(Me.btnHome)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1382, 804)
        Me.panelMain.TabIndex = 12
        '
        'panelLogout
        '
        Me.panelLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLogout.Controls.Add(Me.linkLogout)
        Me.panelLogout.Location = New System.Drawing.Point(1188, 65)
        Me.panelLogout.Name = "panelLogout"
        Me.panelLogout.Size = New System.Drawing.Size(125, 51)
        Me.panelLogout.TabIndex = 18
        Me.panelLogout.Visible = False
        '
        'linkLogout
        '
        Me.linkLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.linkLogout.Location = New System.Drawing.Point(-1, 5)
        Me.linkLogout.Name = "linkLogout"
        Me.linkLogout.Size = New System.Drawing.Size(125, 39)
        Me.linkLogout.TabIndex = 19
        Me.linkLogout.TabStop = True
        Me.linkLogout.Text = "Logout"
        Me.linkLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 754)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "SupplierForm"
        Me.Text = "SupplierForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.panelLogout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents udlProduct As Button
    Friend WithEvents panelForm As Panel
    Friend WithEvents btnAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents linkLogin As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents udlAccount As Button
    Friend WithEvents udlHome As Button
    Friend WithEvents panelMain As Panel
    Friend WithEvents panelLogout As Panel
    Friend WithEvents linkLogout As LinkLabel
End Class
