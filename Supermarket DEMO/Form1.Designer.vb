<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.panelCheckout = New System.Windows.Forms.Panel()
        Me.lblPanelTitle = New System.Windows.Forms.Label()
        Me.picProduct = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.panelLogout = New System.Windows.Forms.Panel()
        Me.linkLogout = New System.Windows.Forms.LinkLabel()
        Me.cart = New System.Windows.Forms.Panel()
        Me.cartContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.udlHome = New System.Windows.Forms.Button()
        Me.udlOrder = New System.Windows.Forms.Button()
        Me.udlAccount = New System.Windows.Forms.Button()
        Me.btnCart = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.btnAccount = New FontAwesome.Sharp.IconButton()
        Me.btnOrder = New FontAwesome.Sharp.IconButton()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.udlProduct = New System.Windows.Forms.Button()
        Me.btnProduct = New FontAwesome.Sharp.IconButton()
        Me.panelLogo.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCheckout.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMain.SuspendLayout()
        Me.panelLogout.SuspendLayout()
        Me.cart.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelForm.SuspendLayout()
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
        Me.btnHome.Location = New System.Drawing.Point(317, 30)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(121, 45)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.Black
        Me.panelLogo.Controls.Add(Me.Label2)
        Me.panelLogo.Controls.Add(Me.Label1)
        Me.panelLogo.Controls.Add(Me.IconPictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(1382, 31)
        Me.panelLogo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(967, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EASY RETURN"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(368, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Free Delivery On Orders Over RM250!"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TruckMoving
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 30
        Me.IconPictureBox1.Location = New System.Drawing.Point(331, 0)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(31, 30)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'panelCheckout
        '
        Me.panelCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCheckout.Controls.Add(Me.lblPanelTitle)
        Me.panelCheckout.Controls.Add(Me.picProduct)
        Me.panelCheckout.Controls.Add(Me.btnClose)
        Me.panelCheckout.Controls.Add(Me.Panel5)
        Me.panelCheckout.Controls.Add(Me.txtAmount)
        Me.panelCheckout.Controls.Add(Me.Button2)
        Me.panelCheckout.Location = New System.Drawing.Point(368, 280)
        Me.panelCheckout.Name = "panelCheckout"
        Me.panelCheckout.Size = New System.Drawing.Size(337, 275)
        Me.panelCheckout.TabIndex = 10
        Me.panelCheckout.Visible = False
        '
        'lblPanelTitle
        '
        Me.lblPanelTitle.Location = New System.Drawing.Point(87, 129)
        Me.lblPanelTitle.Name = "lblPanelTitle"
        Me.lblPanelTitle.Size = New System.Drawing.Size(164, 38)
        Me.lblPanelTitle.TabIndex = 6
        Me.lblPanelTitle.Text = "Label1"
        Me.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picProduct
        '
        Me.picProduct.Location = New System.Drawing.Point(48, 15)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(233, 103)
        Me.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProduct.TabIndex = 5
        Me.picProduct.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Supermarket_DEMO.My.Resources.Resources.close_black
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(308, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 22)
        Me.btnClose.TabIndex = 4
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(133, 196)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(64, 1)
        Me.Panel5.TabIndex = 2
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmount.Location = New System.Drawing.Point(142, 178)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PlaceholderText = "0"
        Me.txtAmount.Size = New System.Drawing.Size(46, 16)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(87, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 30)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Add to Cart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.panelLogout)
        Me.panelMain.Controls.Add(Me.cart)
        Me.panelMain.Controls.Add(Me.udlHome)
        Me.panelMain.Controls.Add(Me.udlOrder)
        Me.panelMain.Controls.Add(Me.udlAccount)
        Me.panelMain.Controls.Add(Me.btnCart)
        Me.panelMain.Controls.Add(Me.PictureBox1)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Controls.Add(Me.linkLogin)
        Me.panelMain.Controls.Add(Me.btnAccount)
        Me.panelMain.Controls.Add(Me.btnOrder)
        Me.panelMain.Controls.Add(Me.panelForm)
        Me.panelMain.Controls.Add(Me.udlProduct)
        Me.panelMain.Controls.Add(Me.btnProduct)
        Me.panelMain.Controls.Add(Me.btnHome)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMain.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.panelMain.Location = New System.Drawing.Point(0, 31)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1382, 804)
        Me.panelMain.TabIndex = 11
        '
        'panelLogout
        '
        Me.panelLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLogout.Controls.Add(Me.linkLogout)
        Me.panelLogout.Location = New System.Drawing.Point(1191, 37)
        Me.panelLogout.Name = "panelLogout"
        Me.panelLogout.Size = New System.Drawing.Size(125, 51)
        Me.panelLogout.TabIndex = 11
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
        'cart
        '
        Me.cart.BackColor = System.Drawing.Color.White
        Me.cart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cart.Controls.Add(Me.cartContainer)
        Me.cart.Controls.Add(Me.btnCheckout)
        Me.cart.Location = New System.Drawing.Point(1142, 81)
        Me.cart.Name = "cart"
        Me.cart.Size = New System.Drawing.Size(236, 283)
        Me.cart.TabIndex = 11
        Me.cart.Visible = False
        '
        'cartContainer
        '
        Me.cartContainer.AutoScroll = True
        Me.cartContainer.Location = New System.Drawing.Point(3, 3)
        Me.cartContainer.Name = "cartContainer"
        Me.cartContainer.Padding = New System.Windows.Forms.Padding(10, 10, 10, 30)
        Me.cartContainer.Size = New System.Drawing.Size(228, 229)
        Me.cartContainer.TabIndex = 11
        '
        'btnCheckout
        '
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCheckout.Location = New System.Drawing.Point(17, 238)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(180, 36)
        Me.btnCheckout.TabIndex = 0
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'udlHome
        '
        Me.udlHome.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.udlHome.FlatAppearance.BorderSize = 20
        Me.udlHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlHome.Location = New System.Drawing.Point(317, 76)
        Me.udlHome.Name = "udlHome"
        Me.udlHome.Size = New System.Drawing.Size(121, 2)
        Me.udlHome.TabIndex = 3
        Me.udlHome.UseVisualStyleBackColor = True
        '
        'udlOrder
        '
        Me.udlOrder.FlatAppearance.BorderSize = 2
        Me.udlOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlOrder.Location = New System.Drawing.Point(716, 76)
        Me.udlOrder.Name = "udlOrder"
        Me.udlOrder.Size = New System.Drawing.Size(121, 2)
        Me.udlOrder.TabIndex = 16
        Me.udlOrder.UseVisualStyleBackColor = True
        '
        'udlAccount
        '
        Me.udlAccount.FlatAppearance.BorderSize = 2
        Me.udlAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlAccount.Location = New System.Drawing.Point(919, 76)
        Me.udlAccount.Name = "udlAccount"
        Me.udlAccount.Size = New System.Drawing.Size(121, 2)
        Me.udlAccount.TabIndex = 17
        Me.udlAccount.UseVisualStyleBackColor = True
        '
        'btnCart
        '
        Me.btnCart.FlatAppearance.BorderSize = 0
        Me.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnCart.IconColor = System.Drawing.Color.Black
        Me.btnCart.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCart.IconSize = 35
        Me.btnCart.Location = New System.Drawing.Point(1251, 48)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(30, 31)
        Me.btnCart.TabIndex = 18
        Me.btnCart.UseVisualStyleBackColor = True
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
        Me.linkLogin.Location = New System.Drawing.Point(1208, 16)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(108, 18)
        Me.linkLogin.TabIndex = 15
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Login/Register"
        Me.linkLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnAccount.Location = New System.Drawing.Point(919, 30)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(121, 45)
        Me.btnAccount.TabIndex = 13
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.FlatAppearance.BorderSize = 0
        Me.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox
        Me.btnOrder.IconColor = System.Drawing.Color.Black
        Me.btnOrder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOrder.IconSize = 30
        Me.btnOrder.Location = New System.Drawing.Point(716, 34)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(121, 37)
        Me.btnOrder.TabIndex = 12
        Me.btnOrder.Text = "Order"
        Me.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'panelForm
        '
        Me.panelForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelForm.Controls.Add(Me.panelCheckout)
        Me.panelForm.Location = New System.Drawing.Point(0, 94)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1382, 710)
        Me.panelForm.TabIndex = 11
        '
        'udlProduct
        '
        Me.udlProduct.FlatAppearance.BorderSize = 10
        Me.udlProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.udlProduct.Location = New System.Drawing.Point(511, 76)
        Me.udlProduct.Name = "udlProduct"
        Me.udlProduct.Size = New System.Drawing.Size(121, 2)
        Me.udlProduct.TabIndex = 5
        Me.udlProduct.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnProduct.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight
        Me.btnProduct.IconColor = System.Drawing.Color.Black
        Me.btnProduct.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProduct.IconSize = 30
        Me.btnProduct.Location = New System.Drawing.Point(511, 30)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(121, 45)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "Product"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1382, 754)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.panelLogo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supermarket"
        Me.panelLogo.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCheckout.ResumeLayout(False)
        Me.panelCheckout.PerformLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.panelLogout.ResumeLayout(False)
        Me.cart.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLogo As Panel
    Friend WithEvents panelCheckout As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents picProduct As PictureBox
    Friend WithEvents lblPanelTitle As Label
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnProduct As FontAwesome.Sharp.IconButton
    Friend WithEvents udlHome As Button
    Friend WithEvents udlProduct As Button
    Friend WithEvents panelForm As Panel
    Friend WithEvents linkLogin As LinkLabel
    Friend WithEvents btnAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOrder As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents udlAccount As Button
    Friend WithEvents udlOrder As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCart As FontAwesome.Sharp.IconButton
    Friend WithEvents cartContainer As FlowLayoutPanel
    Friend WithEvents btnCheckout As Button
    Friend WithEvents cart As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents panelLogout As Panel
    Friend WithEvents linkLogout As LinkLabel
End Class
