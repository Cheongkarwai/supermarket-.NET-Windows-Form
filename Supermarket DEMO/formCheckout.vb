Imports MySql.Data.MySqlClient
Imports System.IO
Public Class formCheckout

    Private subtotal As Double
    Private Const DELIVERY_FEE As Double = 2.99
    Private state() As String = {"Selangor", "Kuala Lumpur", "Terengganu", "Sarawak", "Sabah", "Penang", "Perlis", "Perak", "Pahang", "Negeri Sembilan", "Malacca", "Kelantan", "Kedah", "Johor"}
    Private city As String()() = New String()() {New String() {"Ampang", "Bandar Baru Bangi", "Bandar Puncak Alam", "Bangi", "Banting", "Batang Berjuntai", "Batang Kali", "Batangkali", "Batu Arang", "Batu Caves", "Beranang", "Bukit Rotan",
        "Cheras", "Cyberjaya", "Dengkil", "Gombak", "Hulu Langat", "Jenjarom", "Jeram", "Kajang", "Kapar", "Klang", "Klia", "Kuala Kubu Baru", "Kuala Selangor", "Kuantan", "Pandan", "Pelabuhan Klang", "Petaling Jaya", "Puchong",
    "Pulau Carey", "Pulau Indah", "Pulau Ketam", "Rasa", "Rawang", "Sabak Bernam", "Sekinchan", "Semenyih", "Sepang", "Serdang", "Serendah", "Seri Kembangan", "Shah Alam", "Subang Airport", "Subang Jaya", "Sungai Ayer Tawar", "Sungai Besar",
    "Sungai Buloh", "Sungai Pelek", "Tanjong Karang", "Tanjong Sepat", "Telok Panglima Garang"},
                                New String() {"Ampang", "Batu Caves", "Cheras", "Damansara", "Gombak", "Hulu Kelang", "Kepong", "Kuala Lumpur", "Petaling", "Petaling Jaya", "Sentul", "Setapak", "Sungai Besi"},
                                New String() {"Ajil", "Al Muktatfi Billah Shah", "Ayer Puteh", "Bukit Besi", "Bukit Payong", "Ceneh", "Chalok", "Cukai", "Dungun", "Jerteh", "Kampung Raja", "Kemasek", "Kerteh", "Ketengah Jaya", "Kijal", "Kuala Berang", "Kuala Besut", "Kuala Terengganu", "Marang", "Paka", "Permaisuri", "Sungai Tong"},
                                New String() {"Asajaya", "Balingian", "Baram", "Bau", "Bekenu", "Belaga", "Belawai", "Betong", "Bintangor", "Bintulu", "Dalat", "Daro", "Debak", "Engkilili", "Julau", "Kabong",
                            "Kanowit", "Kapit", "Kota Samarahan", "Kuching", "Lawas", "Limbang", "Lingga", "Long Lama", "Lubok Antu", "Lundu", "Lutong", "Matu", "Miri", "Mukah", "Nanga Medamit", "Niah",
                            "Pusa", "Roban", "Saratok", "Sarikei", "Sebauh", "Sebuyau", "Serian", "Sibu", "Siburan", "Simunjan", "Song", "Spaoh", "Sri Aman", "Sundar", "Tatau"},
                            New String() {"Beaufort", "Beluran", "Beverly", "Bongawan", "Inanam", "Keningau", "Kota Belud", "Kota Kinabalu", "Kota Kinabatangan", "Kota Marudu", "Kuala Penyu", "Kudat",
                        "Kunak", "Lahad Datu", "Likas", "Membakut", "Menumbok", "Nabawan", "Pamol", "Papar", "Penampang", "Putatan", "Ranau", "Sandakan", "Semporna", "Sipitang", "Tambunan", "Tamparuli", "Tanjung Aru", "Tawau", "Tenghilan", "Tenom", "Tuaran"},
                            New String() {"Ayer Itam", "Balik Pulau", "Batu Ferringhi", "Batu Maung", "Bayan Lepas", "Bukit Mertajam", "Butterworth", "Gelugor", "Jelutong", "Kepala Batas", "Kubang Semang", "Nibong Tebal", "Penaga", "Penang Hill", "Perai", "Permatang Pauh", "Pulau Pinang", "Simpang Ampat", "Sungai Jawi", "Tanjong Bungah", "Tanjung Bungah", "Tasek Gelugor", "Tasek Gelugur", "USM Pulau Pinang"},
                            New String() {"Arau", "Kaki Bukit", "Kangar", "Kuala Perlis", "Padang Besar", "Simpang Ampat"},
                            New String() {"Ayer Tawar", "Bagan Datoh", "Bagan Serai", "Bandar Seri Iskandar", "Batu Gajah", "Batu Kurau", "Behrang Stesen", "Bidor", "Bota", "Bruas", "Changkat Jering",
 "Changkat Keruing", "Chemor", "Chenderiang", "Chenderong Balai", "Chikus", "Enggor", "Gerik", "Gopeng", "Hutan Melintang", "Intan", "Ipoh", "Jeram", "Kampar", "Kampung Gajah", "Kampung Kepayang",
    "Kamunting", "Kuala Kangsar", "Kuala Kurau", "Kuala Sepetang", "Lambor Kanan", "Langkap", "Lenggong", "Lumut", "Malim Nawar", "Manong", "Matang", "Padang Rengas", "Pangkor", "Pantai Remis", "Parit",
    "Parit Buntar", "Pengkalan Hulu", "Pusing", "Rantau Panjang", "Sauk", "Selama", "Selekoh", "Seri Manjong", "Seri Manjung", "Simpang", "Simpang Ampat Semanggol", "Sitiawan", "Slim River", "Sungai Siput",
    "Sungai Sumun", "Sungkai", "Taiping", "Tanjong Malim", "Tanjong Piandang", "Tanjong Rambutan", "Tanjong Tualang", "Tapah", "Tapah Road", "Teluk Intan", "Temoh", "TLDM Lumut", "Trolak",
    "Trong", "Tronoh", "Ulu Bernam", "Ulu Kinta"},
     New String() {"Balok", "Bandar Bera", "Bandar Pusat Jengka", "Bandar Pusat Jengka", "Bandar Tun Abdul Razak", "Benta", "Bentong", "Brinchang", "Bukit Fraser", "Bukit Goh", "Bukit Kuin", "Chenor", "Chini", "Damak",
    "Dong", "Gambang", "Genting Highlands", "Cameron Highlands", "Jerantut", "Karak", "Kemayan", "Kuala Krau", "Kuala Lipis", "Kuala Rompin", "Kuantan", "Lanchang", "Lurah Bilut", "Maran", "Mentakab", "Muadzam Shah", "Padang Tengku",
    "Pekan", "Raub", "Ringlet", "Sega", "Sungai Koyan", "Sungai Lembing", "Tanah Rata", "Temerloh", "Triang"},
    New String() {"Bahau", "Bandar Enstek", "Bandar Seri Jempol", "Batu Kikir", "Gemas", "Gemencheh", "Johol", "Kota", "Kuala Klawang", "Kuala Pilah", "Labu", "Linggi", "Mantin", "Nilai", "Port Dickson",
    "Pusat Bandar Palong", "Rantau", "Rembau", "Rompin", "Seremban", "Si Rusa", "Simpang Durian", "Simpang Pertang", "Tampin", "Tanjong Ipoh"},
    New String() {"Alor Gajah", "Asahan", "Ayer Keroh", "Bemban", "Durian Tunggal", "Jasin", "Kem Trendak", "Kuala Sungai Baru", "Lubok China", "Masjid Tanah", "Melaka", "Merlimau", "Selandar", "Sungai Rambai", "Sungai Udang", "Tanjong Kling"},
    New String() {"Ayer Lanas", "Bachok", "Cherang Ruku", "Dabong", "Gua Musang", "Jeli", "Kem Desa Pahlawan", "Ketereh", "Kota Bharu", "Kuala Balah", "Kuala Krai", "Machang", "Melor", "Pasir Mas",
    "Pasir Puteh", "Pulai Chondong", "Rantau Panjang", "Selising", "Tanah Merah", "Temangan", "Tumpat", "Wakaf Bharu"},
    New String() {"Alor Tajar", "Anak Bukit", "Baling", "Bedong", "Bukit Kayu Hitam", "Bukit Pinang", "Bukit Selambau", "Changlun", "Durian Burung", "Guar Chempedak", "Gurun", "Jeniang", "Jitra", "Kepala Batas", "Kodiang", "Kota Sarang Semut", "Kuah", "Kuala Kedah", "Kuala Ketil", "Kuala Nerang", "Kuala Pegang", "Kulim,Kupang", "Kedah", "Langgar", "Lunas", "Megat Dewa", "Merbok", "Padang Matsirat", "Padang Serai", "Pendang", "Pokok Sena", "Semeling", "Serdang", "Sik", "Sintok", "Sungai Lalang", "Sungai Limau", "Sungai Petani", "Tanjung Dawai", "Tokai", "Yan"},
    New String() {"Ayer Baloi", "Ayer Hitam", "Ayer Tawar 2", "Bandar Penawar", "Bandar Tenggara", "Batu Anam", "Batu Pahat", "Bekok", "Benut", "Bukit Gambir", "Bukit Pasir", "Chaah", "Endau", "Gelang Patah", "Gerisek",
    "Gugusan Taib Andak", "Jementah", "Johor Bahru", "Kahang", "Kluang", "Kota Tinggi", "Kukup", "Kulai", "Labis", "Layang-Layang", "Masai", "Mersing", "Muar", "Nusajaya", "Pagoh", "Paloh", "Panchor",
    "Parit Jawa", "Parit Raja", "Parit Sulong", "Pasir Gudang", "Pekan Nenas", "Pengerang", "Pontian", "Pulau Satu", "Rengam", "Rengit", "Segamat", "Semerah", "Senai", "Senggarang", "Seri Gading",
    "Seri Medan", "Simpang Rengam", "Sungai Mati", "Tangkak", "Ulu Tiram", "Yong Peng"}}
    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private cmd2 As MySqlCommand
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub



    Private Sub formCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbxState.Items.AddRange(state)

    End Sub

    Private Sub updateWallet(cmd As MySqlCommand, customer As Customer)


        cmd.CommandText = "UPDATE Customer SET wallet = @balance WHERE customerID = @customerID"


        customer.balanceVal -= Double.Parse(lblTotal.Text.Substring(1))

        cmd.Parameters.AddWithValue("@balance", customer.balanceVal)
        cmd.Parameters.AddWithValue("@customerID", customer.usernameVal)
        cmd.ExecuteNonQuery()
        MessageBox.Show(customer.balanceVal)
        cmd.Parameters.Clear()

    End Sub

    Private Sub createOrder(cmd As MySqlCommand, orderId As String, customer As Customer)


        Dim dict As New Dictionary(Of String, Integer)

        'insert into order table
        cmd.CommandText = "INSERT INTO Orders(orderID,customerID,address,state,city,postcode,contactNo,subTotal,deliveryFee,timePlaced) VALUES (@orderID,@customerID,@address,@state,@city,@postcode,@contactNo,@subTotal,@deliveryFee,@timePlaced)"
        cmd.Parameters.AddWithValue("@orderID", orderId)
        cmd.Parameters.AddWithValue("@customerID", customer.usernameVal)
        cmd.Parameters.AddWithValue("@address", txtHomeAddress.Text)
        cmd.Parameters.AddWithValue("@state", cbxState.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@city", cbxCity.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@postcode", txtPostcode.Text)
        cmd.Parameters.AddWithValue("@contactNo", customer.contactVal)
        cmd.Parameters.AddWithValue("@subTotal", subtotal)
        cmd.Parameters.AddWithValue("@deliveryFee", DELIVERY_FEE)
        Dim d1 As Date = Date.Now()
        Dim strDate As String = d1.ToString("yyyy-MM-dd HH:mm:ss")
        cmd.Parameters.AddWithValue("@timePlaced", strDate)
        cmd.ExecuteNonQuery()

        'instantiate order obj
        Dim order As New Order(orderId, txtHomeAddress.Text, cbxState.SelectedItem.ToString(), cbxCity.SelectedItem.ToString(), txtPostcode.Text, subtotal, DELIVERY_FEE, strDate, "N")
        'add into the customer order list.
        customer.addOrder(order)
        cmd.Parameters.Clear()

        'insert into order details table
        cmd.CommandText = "INSERT INTO OrderDetails VALUES (@productID,@orderID,@quantity)"
        For Each item In customer.getList().ToList()
            cmd.Parameters.AddWithValue("@productID", item.productIDVal)
            cmd.Parameters.AddWithValue("@orderID", orderId)
            cmd.Parameters.AddWithValue("@quantity", item.quantityVal)
            cmd.ExecuteNonQuery()

            dict.Add(item.productIDVal, item.quantityVal)

            Dim orderItem As New Item()
            orderItem.productIDVal = item.productIDVal
            orderItem.productPriceVal = item.productPriceVal
            orderItem.quantityVal = item.quantityVal
            orderItem.productNameVal = item.productNameVal

            For Each order In customer.getOrderList()
                If order.orderIDVal.Equals(orderId) Then
                    order.addItem(orderItem)
                End If
            Next
            cmd.Parameters.Clear()
        Next

        cmd.Parameters.Clear()


        'update the product quantity
        Dim form1 As Form1 = ParentForm
        cmd.CommandText = "UPDATE Product
                            SET quantity = @quantity
                            WHERE productID = @productID"

        For Each orderPair As KeyValuePair(Of String, Integer) In dict

            For Each productPair As KeyValuePair(Of String, Product) In form1.productList
                If orderPair.Key.Equals(productPair.Key) Then
                    cmd.Parameters.AddWithValue("@quantity", productPair.Value.quantityVal - orderPair.Value)
                    cmd.Parameters.AddWithValue("@productID", orderPair.Key)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    productPair.Value.quantityVal -= orderPair.Value

                End If
            Next
        Next

    End Sub



    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        Dim form1 As Form1 = ParentForm
        Dim customer As Customer = CType(form1.userVal, Customer)

        If checkoutFlowPanel.Controls.Count > 0 Then
            If walletRBtn.Checked = True Then
                If customer.balanceVal >= subtotal Then

                    If txtHomeAddress.Text.Length > 0 And txtPostcode.Text.Length > 0 And cbxState.SelectedIndex >= 0 And cbxCity.SelectedIndex >= 0 Then

                        'check whether postcode is number
                        Dim postIsNum = True
                        For Each n In txtPostcode.Text
                            If Char.IsLetter(n) Then
                                postIsNum = False
                                Exit For
                            End If
                        Next

                        If postIsNum Then
                            Try
                                'get the latest order id
                                conn.Open()
                                cmd = New MySqlCommand("SELECT orderID FROM Orders ORDER BY orderID DESC LIMIT 1", conn)
                                reader = cmd.ExecuteReader()
                                cmd.Parameters.Clear()

                                If reader.HasRows() Then
                                    Dim lastOrderId As String = ""
                                    While reader.Read()
                                        lastOrderId = reader.GetString("orderID")
                                    End While
                                    reader.Close()
                                    Try
                                        lastOrderId = Integer.Parse(lastOrderId.Substring(1) + 1).ToString()
                                        createOrder(cmd, "O" & lastOrderId, customer)
                                        updateWallet(cmd, customer)


                                        checkoutFlowPanel.Controls.Clear()
                                        customer.getList().Clear()
                                        form1.cartContainer.Controls.Clear()

                                        'MessageBox.Show(checkoutFlowPanel.Controls.Count)
                                        'MessageBox.Show(customer.getList().Count())
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message())
                                    End Try

                                Else
                                    reader.Close()
                                    Try

                                        createOrder(cmd, "O1", customer)
                                        updateWallet(cmd, customer)

                                        checkoutFlowPanel.Controls.Clear()
                                        customer.getList().Clear()
                                        form1.cartContainer.Controls.Clear()

                                        'MessageBox.Show(checkoutFlowPanel.Controls.Count)
                                        'MessageBox.Show(customer.getList().Count())

                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message())
                                    End Try
                                End If

                                form1.openForm(formOrder)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message())
                            Finally

                                cmd.Dispose()
                                conn.Close()
                            End Try



                        Else
                            MessageBox.Show("Postcode must in numeric format")
                        End If

                    Else
                        MessageBox.Show("Please complete the address information")
                    End If
                Else
                    MessageBox.Show("You don't have sufficient balance in your wallet")
                End If
            Else
                MessageBox.Show("Please select a payment method")
            End If
        Else
            MessageBox.Show("Please add some items.")
            form1.openForm(New formProduct())
        End If


    End Sub

    Private Sub updateInventory()

    End Sub

    Private Sub formCheckout_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim form1 As Form1 = Me.ParentForm
        Dim customer As Customer = CType(form1.userVal, Customer)

        For Each n In customer.getList().ToList()
            Dim checkoutPanel As New CheckoutPanel()
            checkoutPanel.priceLblObj.Text = n.productPriceVal.ToString("C2")
            checkoutPanel.quantityTxtObj.Text = n.quantityVal
            checkoutPanel.titleLblObj.Text = n.productNameVal
            checkoutFlowPanel.Controls.Add(checkoutPanel)

            checkoutPanel.Name = n.productIDVal & "CheckoutPanel"
            checkoutPanel.removeBtnObj.Name = n.productIDVal & "CheckoutRemoveBtn"
            checkoutPanel.minusBtnObj.Name = n.productIDVal & "CheckoutMinusBtn"
            checkoutPanel.addBtnObj.Name = n.productIDVal & "CheckoutAddBtn"
            checkoutPanel.quantityTxtObj.Name = n.productIDVal & "CheckoutQuantityTxt"

            AddHandler checkoutPanel.removeBtnObj.Click, AddressOf removeBtn_Click
            AddHandler checkoutPanel.minusBtnObj.Click, AddressOf minusBtn_Click
            AddHandler checkoutPanel.addBtnObj.Click, AddressOf addBtn_Click


            'for displaying image 
            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT img FROM Product WHERE productID = @productID", conn)
                cmd.Parameters.AddWithValue("@productID", n.productIDVal)

                reader = cmd.ExecuteReader()

                Dim ms As MemoryStream
                Dim bytes() As Byte

                While (reader.Read())
                    bytes = reader.Item("img")
                    ms = New MemoryStream(bytes)
                End While
                'MessageBox.Show("Invoked")
                checkoutPanel.picBoxObj.Image = Image.FromStream(ms)

            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                cmd.Dispose()
            End Try

        Next

        calculateTotal()

        form1.btnCart.Enabled = False

        Dim balance As Double = customer.balanceVal

        walletTxt.Text = balance.ToString("C2")


    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs)

        'current form
        Dim form1 As Form1 = Me.ParentForm
        Dim productID As String = sender.Name.Substring(0, sender.Name.LastIndexOf("CheckoutRemoveBtn"))
        Dim customer As Customer = CType(form1.userVal, Customer)
        Dim panel As Panel = CType(Me.checkoutFlowPanel.Controls(productID & "CheckoutPanel"), Panel)



        'remove in cart
        Dim cartPanel As CartPanel = CType(form1.cartContainer.Controls(productID & "CartItem"), CartPanel)


        For Each n In customer.getList().ToList()
            If (n.productIDVal.Equals(productID)) Then
                customer.getList().Remove(n)
                panel.Dispose()
                cartPanel.Dispose()

            End If
        Next



        calculateTotal()



    End Sub
    Private Sub minusBtn_Click(sender As Object, e As EventArgs)

        Dim form1 As Form1 = Me.ParentForm
        Dim productID As String = sender.Name.Substring(0, sender.Name.LastIndexOf("CheckoutMinusBtn"))
        Dim customer As Customer = CType(form1.userVal, Customer)
        Dim panel As Panel = CType(Me.checkoutFlowPanel.Controls(productID & "CheckoutPanel"), Panel)
        Dim quantityTxt As TextBox = CType(panel.Controls(productID & "CheckoutQuantityTxt"), TextBox)

        'cart panel
        Dim cartPanel As CartPanel = CType(form1.cartContainer.Controls(productID & "CartItem"), CartPanel)
        Dim cartQuantityLabel As Label = CType(cartPanel.Controls(productID & "CartQuantityLabel"), Label)

        If Integer.Parse(quantityTxt.Text) > 1 Then
            quantityTxt.Text = Integer.Parse(quantityTxt.Text) - 1
            cartQuantityLabel.Text = "X" & quantityTxt.Text
            For Each n In customer.getList().ToList()
                If n.productIDVal.Equals(productID) Then
                    n.quantityVal = Integer.Parse(quantityTxt.Text)
                End If
            Next
        ElseIf Integer.Parse(quantityTxt.Text) = 1 Then
            panel.Dispose()
            cartPanel.Dispose()
            For Each n In customer.getList().ToList()
                If n.productIDVal.Equals(productID) Then
                    customer.getList().Remove(n)
                End If
            Next
        End If

        calculateTotal()

    End Sub
    Private Sub addBtn_Click(sender As Object, e As EventArgs)



        Dim form1 As Form1 = Me.ParentForm
        Dim productID As String = sender.Name.Substring(0, sender.Name.LastIndexOf("CheckoutAddBtn"))
        Dim customer As Customer = CType(form1.userVal, Customer)
        Dim panel As Panel = CType(Me.checkoutFlowPanel.Controls(productID & "CheckoutPanel"), Panel)
        Dim quantityTxt As TextBox = CType(panel.Controls(productID & "CheckoutQuantityTxt"), TextBox)

        'cart panel
        Dim cartPanel As CartPanel = CType(form1.cartContainer.Controls(productID & "CartItem"), CartPanel)
        Dim cartQuantityLabel As Label = CType(cartPanel.Controls(productID & "CartQuantityLabel"), Label)

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT quantity FROM product WHERE productID = @id", conn)
            cmd.Parameters.AddWithValue("@id", productID)
            reader = cmd.ExecuteReader()

            While reader.Read()
                If Integer.Parse(quantityTxt.Text) < reader.GetInt64("quantity") Then
                    quantityTxt.Text = Integer.Parse(quantityTxt.Text) + 1
                    cartQuantityLabel.Text = "X" & quantityTxt.Text



                    'update list
                    For Each n In customer.getList().ToList()
                        If n.productIDVal.Equals(productID) Then
                            n.quantityVal = Integer.Parse(quantityTxt.Text)
                        End If
                    Next

                    calculateTotal()
                Else
                    MessageBox.Show("Insufficient Stock")
                End If
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try


    End Sub

    Public Sub calculateTotal()

        subtotal = 0

        Dim form1 As Form1 = Me.ParentForm
        Dim customer As Customer = CType(form1.userVal, Customer)


        For Each n In customer.getList().ToList()
            subtotal += n.productPriceVal * n.quantityVal
        Next

        lblSubtotal.Text = subtotal.ToString("C2")
        lblTotal.Text = (subtotal + DELIVERY_FEE).ToString("C2")
    End Sub

    Private Sub checkoutBtn_Click(sender As Object, e As EventArgs) Handles checkoutBtn.Click


        Dim form1 As Form1 = ParentForm

        If form1.currentBtn IsNot form1.btnProduct Then
            form1.toggleBtn(form1.btnProduct, form1.udlProduct, Color.SkyBlue)
        End If
        form1.openForm(formProduct)

    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged
        cbxCity.Items.Clear()
        If cbxState.SelectedIndex >= 0 Then
            If cbxState.SelectedItem.Equals("Selangor") Then
                cbxCity.Items.AddRange(city(0))
            ElseIf cbxState.SelectedItem.Equals("Kuala Lumpur") Then
                cbxCity.Items.AddRange(city(1))
            ElseIf cbxState.SelectedItem.Equals("Terengganu") Then
                cbxCity.Items.AddRange(city(2))
            ElseIf cbxState.SelectedItem.Equals("Sarawak") Then
                cbxCity.Items.AddRange(city(3))
            ElseIf cbxState.SelectedItem.Equals("Sabah") Then
                cbxCity.Items.AddRange(city(4))
            ElseIf cbxState.SelectedItem.Equals("Penang") Then
                cbxCity.Items.AddRange(city(5))
            ElseIf cbxState.SelectedItem.Equals("Perlis") Then
                cbxCity.Items.AddRange(city(6))
            ElseIf cbxState.SelectedItem.Equals("Perak") Then
                cbxCity.Items.AddRange(city(7))
            ElseIf cbxState.SelectedItem.Equals("Pahang") Then
                cbxCity.Items.AddRange(city(8))
            ElseIf cbxState.SelectedItem.Equals("Negeri Sembilan") Then
                cbxCity.Items.AddRange(city(9))
            ElseIf cbxState.SelectedItem.Equals("Malacca") Then
                cbxCity.Items.AddRange(city(10))
            ElseIf cbxState.SelectedItem.Equals("Kelantan") Then
                cbxCity.Items.AddRange(city(11))
            ElseIf cbxState.SelectedItem.Equals("Kedah") Then
                cbxCity.Items.AddRange(city(12))
            ElseIf cbxState.SelectedItem.Equals("Johor") Then
                cbxCity.Items.AddRange(city(13))
            End If
        End If
    End Sub


End Class

Class CheckoutPanel : Inherits Panel
    Private picBox As PictureBox
    Private titleLbl As Label
    Private priceLbl As Label
    Private removeBtn As Button
    Private minusBtn As Button
    Private addBtn As Button
    Private quantityTxt As TextBox
    Private udl As Panel
    Public Sub New()
        Me.Size = New Size(702, 143)
        Me.BackColor = Color.White

        picBox = New PictureBox()
        picBox.Size = New Size(125, 110)
        picBox.Location = New Point(22, 18)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
        picBox.BorderStyle = BorderStyle.FixedSingle

        titleLbl = New Label()
        titleLbl.AutoSize = False
        titleLbl.Size = New Size(142, 91)
        titleLbl.Location = New Point(171, 37)
        titleLbl.Font = New Font("Bahnschrift", 13)

        priceLbl = New Label()
        priceLbl.AutoSize = False
        priceLbl.Size = New Size(100, 23)
        priceLbl.Location = New Point(560, 62)
        priceLbl.TextAlign = ContentAlignment.MiddleCenter
        priceLbl.Font = New Font("Bahnschrift", 12)

        removeBtn = New Button()
        removeBtn.Size = New Size(33, 41)
        removeBtn.Location = New Point(666, 49)
        removeBtn.FlatAppearance.BorderSize = 0
        removeBtn.FlatStyle = FlatStyle.Flat
        removeBtn.Text = "X"
        removeBtn.Font = New Font("Bahnschrift", 18)

        addBtn = New Button()
        addBtn.Size = New Size(20, 29)
        addBtn.Location = New Point(460, 58)
        addBtn.FlatAppearance.BorderSize = 0
        addBtn.FlatStyle = FlatStyle.Flat
        addBtn.Text = "+"
        addBtn.Font = New Font("Bahnschrift", 12)

        minusBtn = New Button()
        minusBtn.Size = New Size(20, 29)
        minusBtn.Location = New Point(341, 58)
        minusBtn.FlatAppearance.BorderSize = 0
        minusBtn.FlatStyle = FlatStyle.Flat
        minusBtn.Text = "-"
        minusBtn.Font = New Font("Bahnschrift", 12)

        quantityTxt = New TextBox()
        quantityTxt.ReadOnly = True
        quantityTxt.BackColor = Color.White
        quantityTxt.BorderStyle = BorderStyle.None
        quantityTxt.TextAlign = HorizontalAlignment.Center
        quantityTxt.Size = New Size(85, 16)
        quantityTxt.Location = New Point(367, 65)
        quantityTxt.Font = New Font("Bahnschrift", 10)

        udl = New Panel()
        udl.Size = New Size(85, 1)
        udl.Location = New Point(367, 83)
        udl.BorderStyle = BorderStyle.FixedSingle


        Me.Controls.AddRange({quantityTxt, minusBtn, addBtn, removeBtn, priceLbl, titleLbl, picBox, udl})


    End Sub

    Public Property picBoxObj As PictureBox
        Get
            Return picBox
        End Get
        Set(value As PictureBox)
            picBox = value
        End Set
    End Property

    Public Property titleLblObj As Label
        Get
            Return titleLbl
        End Get
        Set(value As Label)
            titleLbl = value
        End Set
    End Property

    Public Property priceLblObj As Label
        Get
            Return priceLbl
        End Get
        Set(value As Label)
            priceLbl = value
        End Set
    End Property

    Public Property removeBtnObj As Button
        Get
            Return removeBtn
        End Get
        Set(value As Button)
            removeBtn = value
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

    Public Property quantityTxtObj As TextBox
        Get
            Return quantityTxt
        End Get
        Set(value As TextBox)
            quantityTxt = value
        End Set
    End Property

End Class