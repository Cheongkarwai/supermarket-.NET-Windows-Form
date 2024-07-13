<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riderOverview
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
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelLogout = New System.Windows.Forms.Panel()
        Me.linkLogout = New System.Windows.Forms.LinkLabel()
        Me.udlHome = New System.Windows.Forms.Button()
        Me.udlAccount = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.btnHistory = New FontAwesome.Sharp.IconButton()
        Me.udlProduct = New System.Windows.Forms.Button()
        Me.btnRiderService = New FontAwesome.Sharp.IconButton()
        Me.btnOverview = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelForm.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.panelLogout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelForm
        '
        Me.panelForm.Controls.Add(Me.Panel1)
        Me.panelForm.Location = New System.Drawing.Point(0, 94)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1192, 560)
        Me.panelForm.TabIndex = 11
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelLogout)
        Me.panelMain.Controls.Add(Me.udlHome)
        Me.panelMain.Controls.Add(Me.udlAccount)
        Me.panelMain.Controls.Add(Me.PictureBox1)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.linkLogin)
        Me.panelMain.Controls.Add(Me.btnHistory)
        Me.panelMain.Controls.Add(Me.udlProduct)
        Me.panelMain.Controls.Add(Me.btnRiderService)
        Me.panelMain.Controls.Add(Me.btnOverview)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.panelMain.Location = New System.Drawing.Point(0, 0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1192, 804)
        Me.panelMain.TabIndex = 13
        '
        'panelLogout
        '
        Me.panelLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLogout.Controls.Add(Me.linkLogout)
        Me.panelLogout.Location = New System.Drawing.Point(1015, 37)
        Me.panelLogout.Name = "panelLogout"
        Me.panelLogout.Size = New System.Drawing.Size(125, 51)
        Me.panelLogout.TabIndex = 18
        Me.panelLogout.Visible = False
        '
        'linkLogout
        '
        Me.linkLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.linkLogout.Location = New System.Drawing.Point(-1, 0)
        Me.linkLogout.Name = "linkLogout"
        Me.linkLogout.Size = New System.Drawing.Size(125, 39)
        Me.linkLogout.TabIndex = 19
        Me.linkLogout.TabStop = True
        Me.linkLogout.Text = "Logout"
        Me.linkLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1382, 1)
        Me.Panel2.TabIndex = 0
        '
        'linkLogin
        '
        Me.linkLogin.AutoSize = True
        Me.linkLogin.Font = New System.Drawing.Font("Bahnschrift SemiLight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.linkLogin.Location = New System.Drawing.Point(1028, 16)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(108, 18)
        Me.linkLogin.TabIndex = 15
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Login/Register"
        '
        'btnHistory
        '
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History
        Me.btnHistory.IconColor = System.Drawing.Color.Black
        Me.btnHistory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHistory.IconSize = 25
        Me.btnHistory.Location = New System.Drawing.Point(731, 30)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(121, 45)
        Me.btnHistory.TabIndex = 13
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'udlProduct
        '
        Me.udlProduct.FlatAppearance.BorderSize = 10
        Me.udlProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlProduct.Location = New System.Drawing.Point(523, 76)
        Me.udlProduct.Name = "udlProduct"
        Me.udlProduct.Size = New System.Drawing.Size(136, 2)
        Me.udlProduct.TabIndex = 5
        Me.udlProduct.UseVisualStyleBackColor = True
        '
        'btnRiderService
        '
        Me.btnRiderService.FlatAppearance.BorderSize = 0
        Me.btnRiderService.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRiderService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnRiderService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRiderService.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRiderService.IconChar = FontAwesome.Sharp.IconChar.Truck
        Me.btnRiderService.IconColor = System.Drawing.Color.Black
        Me.btnRiderService.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRiderService.IconSize = 30
        Me.btnRiderService.Location = New System.Drawing.Point(523, 30)
        Me.btnRiderService.Name = "btnRiderService"
        Me.btnRiderService.Size = New System.Drawing.Size(140, 45)
        Me.btnRiderService.TabIndex = 2
        Me.btnRiderService.Text = "Rider Service"
        Me.btnRiderService.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRiderService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRiderService.UseVisualStyleBackColor = True
        '
        'btnOverview
        '
        Me.btnOverview.FlatAppearance.BorderSize = 0
        Me.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnOverview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverview.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOverview.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnOverview.IconColor = System.Drawing.Color.Black
        Me.btnOverview.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOverview.IconSize = 30
        Me.btnOverview.Location = New System.Drawing.Point(329, 30)
        Me.btnOverview.Name = "btnOverview"
        Me.btnOverview.Size = New System.Drawing.Size(121, 45)
        Me.btnOverview.TabIndex = 0
        Me.btnOverview.Text = "Overview"
        Me.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOverview.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1192, 1)
        Me.Panel1.TabIndex = 0
        '
        'riderOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 654)
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.panelMain)
        Me.Name = "riderOverview"
        Me.Text = "riderOverview"
        Me.panelForm.ResumeLayout(False)
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.panelLogout.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelForm As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents panelLogout As Panel
    Friend WithEvents linkLogout As LinkLabel
    Friend WithEvents udlHome As Button
    Friend WithEvents udlAccount As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents linkLogin As LinkLabel
    Friend WithEvents btnHistory As FontAwesome.Sharp.IconButton
    Friend WithEvents udlProduct As Button
    Friend WithEvents btnRiderService As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOverview As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
End Class
