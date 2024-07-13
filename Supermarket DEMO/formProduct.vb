
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class formProduct

    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private productList As Dictionary(Of String, Product)


    Private Sub formProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


                Dim panel As New FormProductPanel()
                panel.productTitleObj.Text = product.productNameVal
                panel.productPriceObj.Text = product.productPriceVal.ToString("C2")
                panel.Name = product.productIDVal & "Panel"
                panel.addToCartBtnObj.Name = product.productIDVal & "Btn"
                panel.quantityFieldObj.Name = product.productIDVal & "Txt"
                panel.quantityFieldObj.Text = "0"
                panel.addBtnObj.Name = product.productIDVal & "ProductAddBtn"
                panel.minusBtnObj.Name = product.productIDVal & "ProductMinusBtn"

                Dim ms As MemoryStream
                Dim bytes() As Byte = reader.Item("img")
                ms = New MemoryStream(bytes)
                Dim img As Image = Image.FromStream(ms)

                panel.picBoxObj.Image = img

                AddHandler panel.minusBtnObj.Click, AddressOf productMinusBtn_Click
                AddHandler panel.addBtnObj.Click, AddressOf productAddBtn_Click
                AddHandler panel.addToCartBtnObj.Click, AddressOf AddToCartBtn_Click

                productList.Add(product.productIDVal, product)
                productFlowPanel.Controls.Add(panel)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            cmd.Dispose()

        End Try



    End Sub


    Public Sub productMinusBtn_Click(sender As Object, e As EventArgs)

        Dim p As Product

        Dim id As String = "P"
        For i As Integer = 1 To sender.Name.Length - 1
            If (Char.IsNumber(sender.Name(i))) Then
                id &= sender.Name(i)
            Else
                Exit For
            End If

        Next

        p = productList.Item(id)
        Dim flowPanel As FlowLayoutPanel = CType(Me.Controls("productFlowPanel"), FlowLayoutPanel)
        Dim panel As Panel = CType(flowPanel.Controls(p.productIDVal & "Panel"), Panel)
        Dim quantityTxt As TextBox = CType(panel.Controls(p.productIDVal & "Txt"), TextBox)

        If quantityTxt.Text IsNot String.Empty Then
            If Integer.Parse(quantityTxt.Text) > 0 Then
                quantityTxt.Text = Integer.Parse(quantityTxt.Text) - 1
            End If
        Else
            MessageBox.Show("Please enter quantity")
        End If
    End Sub
    Public Sub productAddBtn_Click(sender As Object, e As EventArgs)

        Dim p As Product

        Dim id As String = "P"
        For i As Integer = 1 To sender.Name.Length - 1
            If (Char.IsNumber(sender.Name(i))) Then
                id &= sender.Name(i)
            Else
                Exit For
            End If

        Next
        p = productList.Item(id)
        Dim flowPanel As FlowLayoutPanel = CType(Me.Controls("productFlowPanel"), FlowLayoutPanel)
        Dim panel As Panel = CType(flowPanel.Controls(p.productIDVal & "Panel"), Panel)
        Dim quantityTxt As TextBox = CType(panel.Controls(p.productIDVal & "Txt"), TextBox)

        If quantityTxt.Text IsNot String.Empty Then
            If p.quantityVal > quantityTxt.Text Then
                quantityTxt.Text = Integer.Parse(quantityTxt.Text) + 1
            Else
                MessageBox.Show("Insufficient stock")
            End If
        Else
            MessageBox.Show("Please enter quantity")
        End If

    End Sub
    Public Sub addToCartBtn_Click(sender As Object, e As EventArgs)


        Dim p As Product

        Dim id As String = "P"
        For i As Integer = 1 To sender.Name.Length - 1
            If (Char.IsNumber(sender.Name(i))) Then
                id &= sender.Name(i)
            Else
                Exit For
            End If

        Next

        p = productList.Item(id)

        Dim flowPanel As FlowLayoutPanel = CType(Me.Controls("productFlowPanel"), FlowLayoutPanel)
        Dim panel As Panel = CType(flowPanel.Controls(p.productIDVal & "Panel"), Panel)
        Dim quantityTxt As TextBox = CType(panel.Controls(p.productIDVal & "Txt"), TextBox)
        Dim form1 As Form1 = Me.ParentForm
        Dim customer = CType(form1.userVal, Customer)

        If quantityTxt.Text.Length > 0 Then
            If Integer.Parse(quantityTxt.Text) > 0 Then

                'check if there is any duplicate item in customer cart
                Dim flag As Boolean = True
                For Each n In customer.getList().ToList()

                    If p.productIDVal.Equals(n.productIDVal) Then
                        flag = False
                        Exit For
                    End If

                Next
                If flag Then
                    If productList.ContainsKey(id) Then

                        Dim cartPanel As New CartPanel()
                        cartPanel.titleLblObj.Text = p.productNameVal
                        cartPanel.quantityLblObj.Text = "X" & quantityTxt.Text
                        cartPanel.cancelBtnObj.Name = p.productIDVal & "CartCancelBtn"
                        cartPanel.Name = p.productIDVal & "CartItem"
                        cartPanel.quantityLblObj.Name = p.productIDVal & "CartQuantityLabel"

                        Try
                            conn.Open()
                            cmd = New MySqlCommand("SELECT img FROM Product WHERE productID = @productID", conn)
                            cmd.Parameters.AddWithValue("@productID", p.productIDVal)

                            reader = cmd.ExecuteReader()

                            Dim ms As MemoryStream
                            Dim bytes() As Byte

                            While (reader.Read())
                                bytes = reader.Item("img")
                                ms = New MemoryStream(bytes)
                            End While
                            'MessageBox.Show("Invoked")
                            cartPanel.picBoxObj.Image = Image.FromStream(ms)

                        Catch ex As Exception
                            MessageBox.Show(ex.Message())
                        Finally
                            conn.Close()
                            cmd.Dispose()
                        End Try

                        AddHandler cartPanel.cancelBtnObj.Click, AddressOf removeCartItemBtn_Click

                        form1.cartContainer.Controls.Add(cartPanel)

                        customer.addItem(p.productIDVal, Integer.Parse(quantityTxt.Text), p.productPriceVal, p.productNameVal)


                    End If
                Else
                    MessageBox.Show("No duplicate item please")
                End If
            Else
                MessageBox.Show("Please enter valid quantity")
            End If
        Else
            MessageBox.Show("Please enter quantity")
        End If

        quantityTxt.Text = "0"

    End Sub

    Public Sub removeCartItemBtn_Click(sender As Object, e As EventArgs)

        Dim p As Product
        Dim id As String = "P"
        For i As Integer = 1 To sender.Name.Length - 1
            If (Char.IsNumber(sender.Name(i))) Then
                id &= sender.Name(i)
            Else
                Exit For
            End If

        Next

        p = productList.Item(id)


        Dim form1 As Form1 = Me.ParentForm

        Dim customer = CType(form1.userVal, Customer)

        customer.removeItem(p.productIDVal)


        Dim panel As Panel = CType(form1.cartContainer.Controls(p.productIDVal & "CartItem"), Panel)
        panel.Dispose()


    End Sub

    Private Sub formProduct_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim form1 As Form1 = Me.ParentForm
        form1.btnCart.Enabled = True
    End Sub


End Class

Public Class FormProductPanel : Inherits Panel
    Dim picBox As PictureBox
    Dim productTitle As Label
    Dim productPrice As Label
    Dim minusBtn As Button
    Dim addBtn As Button
    Dim quantityField As TextBox
    Dim addToCartBtn As Button
    Dim udl As Panel

    Public Sub New()

        Me.Size = New Size(213, 268)
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.BackColor = Color.White

        picBox = New PictureBox()
        picBox.Size = New Size(139, 88)
        picBox.Location = New Point(35, 18)
        picBox.BorderStyle = BorderStyle.FixedSingle
        picBox.SizeMode = PictureBoxSizeMode.StretchImage


        productTitle = New Label()
        productTitle.Text = "Shirt"
        productTitle.Location = New Point(35, 114)

        productPrice = New Label()
        productPrice.Text = "Rm100"
        productPrice.Location = New Point(35, 144)

        minusBtn = New Button()
        minusBtn.Text = "-"
        minusBtn.Location = New Point(35, 177)
        minusBtn.Size = New Size(20, 29)
        minusBtn.FlatStyle = FlatStyle.Flat
        minusBtn.FlatAppearance.BorderSize = 0

        addBtn = New Button()
        addBtn.Text = "+"
        addBtn.Location = New Point(154, 177)
        addBtn.Size = New Size(20, 29)
        addBtn.FlatStyle = FlatStyle.Flat
        addBtn.FlatAppearance.BorderSize = 0

        quantityField = New TextBox()
        quantityField.Location = New Point(61, 184)
        quantityField.Size = New Size(85, 16)
        quantityField.BorderStyle = BorderStyle.None
        quantityField.TextAlign = HorizontalAlignment.Center
        quantityField.ReadOnly = True
        quantityField.BackColor = Color.White

        addToCartBtn = New Button()
        addToCartBtn.Text = "Add To Cart"
        addToCartBtn.Location = New Point(35, 217)
        addToCartBtn.Size = New Size(139, 38)
        addToCartBtn.FlatStyle = FlatStyle.Flat


        udl = New Panel()
        udl.Size = New Size(85, 1)
        udl.Location = New Point(61, 202)
        udl.BorderStyle = BorderStyle.FixedSingle

        Me.Controls.Add(picBox)
        Me.Controls.Add(productTitle)
        Me.Controls.Add(productPrice)
        Me.Controls.Add(minusBtn)
        Me.Controls.Add(addBtn)
        Me.Controls.Add(quantityField)
        Me.Controls.Add(addToCartBtn)
        Me.Controls.Add(udl)

    End Sub

    Public Property picBoxObj As PictureBox
        Get
            Return picBox
        End Get
        Set(value As PictureBox)
            picBox = value
        End Set
    End Property

    Public Property productTitleObj As Label
        Get
            Return productTitle
        End Get
        Set(value As Label)
            productTitle = value
        End Set
    End Property

    Public Property productPriceObj As Label
        Get
            Return productPrice
        End Get
        Set(value As Label)
            productPrice = value
        End Set
    End Property

    Public Property minusBtnObj As Button
        Get
            Return minusBtn
        End Get
        Set(value As Button)
            minusBtn = value
        End Set
    End Property

    Public Property addBtnObj As Button
        Get
            Return addBtn
        End Get
        Set(value As Button)
            addBtn = value
        End Set
    End Property

    Public Property quantityFieldObj As TextBox
        Get
            Return quantityField
        End Get
        Set(value As TextBox)
            quantityField = value
        End Set
    End Property

    Public Property addToCartBtnObj As Button
        Get
            Return addToCartBtn
        End Get
        Set(value As Button)
            addToCartBtn = value
        End Set
    End Property
End Class

Class CartPanel : Inherits Panel

    Private picBox As PictureBox
    Private titleLbl As Label
    Private quantityLbl As Label
    Private cancelBtn As Button
    Public Sub New()
        Me.BorderStyle = BorderStyle.FixedSingle
        Me.Size = New Size(179, 100)
        Me.Margin = New Padding(3, 20, 3, 20)

        picBox = New PictureBox()
        picBox.Size = New Size(64, 55)
        picBox.Location = New Point(7, 26)
        picBox.BorderStyle = BorderStyle.FixedSingle
        picBox.SizeMode = PictureBoxSizeMode.StretchImage


        titleLbl = New Label()
        titleLbl.Size = New Size(75, 40)
        titleLbl.Location = New Point(77, 26)
        titleLbl.AutoSize = False

        quantityLbl = New Label()
        quantityLbl.Size = New Size(80, 15)
        quantityLbl.Location = New Point(77, 76)
        quantityLbl.AutoSize = False

        cancelBtn = New Button()
        cancelBtn.Size = New Size(32, 23)
        cancelBtn.Location = New Point(140, 3)
        cancelBtn.Text = "X"
        cancelBtn.FlatStyle = FlatStyle.Flat

        Me.Controls.Add(titleLbl)
        Me.Controls.Add(quantityLbl)
        Me.Controls.Add(cancelBtn)
        Me.Controls.Add(picBox)
    End Sub

    Public Property titleLblObj As Label
        Get
            Return titleLbl
        End Get
        Set(value As Label)
            titleLbl = value
        End Set
    End Property

    Public Property quantityLblObj As Label
        Get
            Return quantityLbl
        End Get
        Set(value As Label)
            quantityLbl = value
        End Set
    End Property

    Public Property cancelBtnObj As Button
        Get
            Return cancelBtn
        End Get
        Set(value As Button)
            cancelBtn = value
        End Set
    End Property

    Public Property picBoxObj As PictureBox
        Get
            Return picBox
        End Get
        Set(value As PictureBox)
            picBox = value
        End Set
    End Property
End Class