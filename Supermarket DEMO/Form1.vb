Imports MySql.Data.MySqlClient
Public Class Form1
    Public currentBtn As Button
    Public currentForm As Form
    Private externalForm As Form
    Private user As User
    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Public productList As Dictionary(Of String, Product)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        linkLogin.Text = user.usernameVal
        updateFormAccount(user)
    End Sub

    Public Property userVal As User
        Get
            Return user
        End Get
        Set(value As User)
            user = value
        End Set
    End Property

    Private Sub updateFormAccount(user As User)
        formAccount.txtUsername.Text = user.usernameVal
        formAccount.txtContact.Text = user.contactVal
        formAccount.txtEmail.Text = user.emailVal
        formAccount.txtPassword.Text = user.passwordVal
        Dim c1 = CType(user, Customer)
        formAccount.txtBalance.Text = c1.balanceVal
        formAccount.txtName.Text = c1.nameVal
    End Sub

    Private Sub updateProduct(list As List(Of Product))

    End Sub

    Public Sub loadProduct()
        Try
            conn.Open()

            productList = New Dictionary(Of String, Product)

            cmd = New MySqlCommand("SELECT * FROM Product WHERE quantity > 0", conn)
            reader = cmd.ExecuteReader()

            While (reader.Read)
                Dim product As New Product()
                product.productIDVal = reader.GetString("productID")
                product.productNameVal = reader.GetString("name")
                product.productDescVal = reader.GetString("price")
                product.quantityVal = reader.GetString("quantity")
                product.categoryVal = reader.GetString("category")
                product.productPriceVal = reader.GetString("price")

                productList.Add(product.productIDVal, product)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            cmd.Dispose()

        End Try
    End Sub
    Private Sub formContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentBtn = btnHome
        btnHome.ForeColor = Color.SkyBlue
        btnHome.IconColor = Color.SkyBlue
        udlHome.FlatAppearance.BorderColor = Color.SkyBlue
        openForm(formIndex)
        loadProduct()

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        panelCheckout.Visible = False
    End Sub

    'supermarket

    'click for home btn
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If currentBtn IsNot sender Then
            toggleBtn(sender, udlHome, Color.SkyBlue)
        End If
        openForm(formIndex)
    End Sub


    'btn products
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        If currentBtn IsNot sender Then
            toggleBtn(sender, udlProduct, Color.SkyBlue)
        End If
        openForm(formProduct)

    End Sub

    'order btn
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'changing its color
        If currentBtn IsNot sender Then
            toggleBtn(sender, udlOrder, Color.SkyBlue)
        End If
        openForm(formOrder)
    End Sub

    'toggle for the button in nav bar
    Public Sub toggleBtn(sender As Object, underline As Object, color As Color)
        If currentBtn IsNot sender Then
            resetAllBtn()
            currentBtn = sender
            If underline IsNot Nothing Then
                underline.Visible = True
                underline.FlatAppearance.BorderColor = Color.SkyBlue
            End If
            sender.ForeColor = Color.SkyBlue
            sender.IconColor = Color.SkyBlue
        End If
    End Sub


    'to switch the form in the main container
    '
    Public Sub openForm(frm As Form)

        'set the form 
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True

        'if it has nothing
        If currentForm Is Nothing Then
            'add into container
            panelForm.Controls.Add(frm)
            currentForm = frm
        Else
            'if the current form is not the form passed in the argument
            If currentForm IsNot frm Then
                'dispose current form and add new form into container
                currentForm.Dispose()
                panelForm.Controls.Add(frm)
                currentForm = frm
            End If
        End If
    End Sub
    'reset the buttons in navigation bar
    Private Sub resetAllBtn()
        udlHome.FlatAppearance.BorderColor = Color.Black
        btnHome.ForeColor = Color.Black
        btnHome.IconColor = Color.Black
        udlProduct.FlatAppearance.BorderColor = Color.Black
        btnProduct.ForeColor = Color.Black
        btnProduct.IconColor = Color.Black
        btnOrder.IconColor = Color.Black
        btnOrder.ForeColor = Color.Black
        udlOrder.FlatAppearance.BorderColor = Color.Black
        btnAccount.IconColor = Color.Black
        btnAccount.ForeColor = Color.Black
        udlAccount.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        If cart.Visible = False Then
            btnCart.IconColor = Color.SkyBlue
            cart.Location = New Point(1142, 81)
            cart.Visible = True
        Else
            cart.Visible = False
            btnCart.IconColor = Color.Black
        End If
    End Sub

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked

        If panelLogout.Visible = False Then
            panelLogout.Visible = True
        Else
            panelLogout.Visible = False
        End If
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        If currentBtn IsNot sender Then
            toggleBtn(sender, udlAccount, Color.SkyBlue)
        End If
        openForm(formAccount)
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        Dim customer = CType(user, Customer)
        If customer.getList().Count > 0 Then
            openForm(formCheckout)
            currentBtn = Nothing
            resetAllBtn()
            cart.Visible = False
            btnCart.IconColor = Color.Black
        Else
            MessageBox.Show("Please add something into the cart before checkout")
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub panelLogo_Paint(sender As Object, e As PaintEventArgs) Handles panelLogo.Paint

    End Sub

    Private Sub linkLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogout.LinkClicked
        Me.Dispose()
        Dim loginForm As New formLogin()
        loginForm.Visible = True
    End Sub

    Private Sub panelLogout_Paint(sender As Object, e As PaintEventArgs) Handles panelLogout.Paint

    End Sub
End Class


Class ProductPanel : Inherits Panel
    Private pic As New PictureBox()
    Private btn As New Button()
    Private title As New Label()
    Private currency As New Label()
    Private price As New Label()
    Public Sub New(btnText As String, titleText As String, currencyText As String, priceText As String, count As String)

        pic.Image = My.Resources.Star_Topology
        pic.SizeMode = PictureBoxSizeMode.StretchImage
        pic.Size = New Size(237, 125)
        pic.Location = New Point(14, 19)
        pic.Margin = New Padding(0, 0, 0, 0)

        btn.Text = btnText
        btn.Name = "btnBuy" & count
        btn.Size = New Size(123, 31)
        btn.Location = New Point(128, 297)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 1
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Margin = New Padding(0, 0, 0, 0)

        title.Text = titleText
        title.Name = "lblTitle" & count
        title.Size = New Size(237, 61)
        title.Location = New Point(14, 155)
        title.Margin = New Padding(0, 0, 0, 0)

        price.Text = priceText
        price.Name = "lblPrice" & count
        price.Size = New Size(41, 15)
        price.Location = New Point(53, 305)
        price.Margin = New Padding(0, 0, 0, 0)
        price.TextAlign = ContentAlignment.MiddleCenter

        currency.Text = currencyText
        currency.Name = "lblCurrency" & count
        currency.Size = New Size(34, 21)
        currency.Font = New Font("Arial", 13, FontStyle.Regular)
        currency.Location = New Point(14, 300)
        currency.Margin = New Padding(0, 0, 0, 0)
        currency.TextAlign = ContentAlignment.MiddleCenter


        Me.Controls.Add(title)
        Me.Controls.Add(currency)
        Me.Controls.Add(price)
        Me.Controls.Add(pic)
        Me.Controls.Add(btn)

    End Sub
    Public Function getPic() As PictureBox
        Return pic
    End Function
    Public Function getBtn() As Button
        Return btn
    End Function
    Public Function getLblCurrency() As Label
        Return currency
    End Function

    Public Function getLblPrice() As Label
        Return price
    End Function
    Public Function getLblTitle() As Label
        Return title
    End Function
End Class


