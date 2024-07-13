Imports MySql.Data.MySqlClient
Public Class formOrder

    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private Sub formOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'clear all the order in order panel
        flowContainer.Controls.Clear()
    End Sub

    Private Sub formOrder_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


        Dim form1 As Form1 = ParentForm

        Dim customer As Customer = CType(form1.userVal, Customer)

        'display the order panel when the form is shown
        For Each n In customer.getOrderList.ToList()

            Dim orderPanel As New orderPanel()

            AddHandler orderPanel.btnOrderDetailObj.Click, AddressOf btnOrderDetailObj_Click
            orderPanel.btnOrderDetailObj.Name = "btnDetails" & n.orderIDVal
            orderPanel.btnOrderReceivedObj.Name = "btnReceived" & n.orderIDVal

            If n.statusVal = "N" Then
                orderPanel.lblStatusObj.Text = "Delivering"
                AddHandler orderPanel.btnOrderReceivedObj.Click, AddressOf orderReceived

            ElseIf n.statusVal = "Y" Then
                orderPanel.lblStatusObj.Text = "Delivered"
                orderPanel.btnOrderReceivedObj.Dispose()
            End If

            orderPanel.lblOrderIdObj.Text = n.orderIDVal
            orderPanel.lblOrderTotalObj.Text = (n.subtotalVal + n.deliveryFeeVal).ToString("C2")
            orderPanel.LblTimeVal.Text = n.timePlacedVal

            For Each a In n.getAllItem().ToList()
                orderPanel.cbxProductListObj.Items.Add(a.productNameVal & "  " & "x" & a.quantityVal)
            Next

            flowContainer.Controls.Add(orderPanel)
        Next


    End Sub

    Private Sub orderReceived(sender As Object, e As EventArgs)

        Try
            conn.Open()
            cmd = New MySqlCommand("UPDATE Orders 
                                    SET isArrived = @stat
                                    WHERE orderID = @orderId", conn)
            cmd.Parameters.AddWithValue("@stat", "Y")
            cmd.Parameters.AddWithValue("@orderId", sender.Name.Substring(11))
            cmd.ExecuteNonQuery()

            Dim form1 As Form1 = ParentForm

            Dim customer As Customer = CType(Form1.userVal, Customer)

            For Each n In customer.getOrderList().ToList()
                If n.orderIDVal.Equals(sender.Name.Substring(11)) Then
                    n.statusVal = "Y"
                End If
            Next

            sender.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            MessageBox.Show("Order Received !")
        End Try

    End Sub
    Private Sub btnOrderDetailObj_Click(sender As Object, e As EventArgs)
        'MessageBox.Show(sender.Name)

        Dim form1 As Form1 = ParentForm

        Dim customer As Customer = CType(form1.userVal, Customer)

        'instantiate a new form
        Dim formOrderDetails As New formOrderDetails()
        formOrderDetails.Visible = True


        Dim subtotal As Double = 0


        Dim count As Integer = 1
        For Each n In customer.getOrderList()
            'evaluate whether the particular orderID is the same as the first 10 control's name 
            If n.orderIDVal.Equals(sender.Name.Substring(10)) Then
                formOrderDetails.lblReceipt.Text &= vbCrLf & vbCrLf
                formOrderDetails.lblReceipt.Text &= vbTab & vbTab & vbTab & "Supermarket" & vbCrLf & "===================================================================" & vbCrLf & vbCrLf & vbCrLf

                formOrderDetails.lblReceipt.Text &= "OrderID : " & n.orderIDVal & vbCrLf
                formOrderDetails.lblReceipt.Text &= "Date : " & n.timePlacedVal & vbCrLf
                formOrderDetails.lblReceipt.Text &= "Address : " & n.addressVal & vbCrLf
                formOrderDetails.lblReceipt.Text &= "State : " & n.stateVal & vbCrLf
                formOrderDetails.lblReceipt.Text &= "City : " & n.cityVal & vbCrLf
                formOrderDetails.lblReceipt.Text &= "Postcode : " & n.postcodeVal & vbCrLf
                formOrderDetails.lblReceipt.Text &= vbCrLf
                formOrderDetails.lblReceipt.Text &= "===================================================================" & vbCrLf
                formOrderDetails.lblReceipt.Text &= " Product Name" & vbTab & vbTab & vbTab & vbTab & "Quantity" & vbTab & vbTab & vbTab & vbTab & "Price($)" & vbCrLf
                formOrderDetails.lblReceipt.Text &= "===================================================================" & vbCrLf & vbCrLf
                For Each a In n.getAllItem()
                    subtotal += a.productPriceVal * a.quantityVal

                    formOrderDetails.lblReceipt.Text &= count & "." & a.productNameVal.ToString() & vbTab & vbTab & vbTab & vbTab & "x" & a.quantityVal.ToString() & vbTab & vbTab & vbTab & vbTab & a.productPriceVal.ToString("C2") & vbCrLf

                    count += 1
                Next
                formOrderDetails.lblReceipt.Text &= vbCrLf & "===================================================================" & vbCrLf
                formOrderDetails.lblReceipt.Text &= "Delivery Fee" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & n.deliveryFeeVal.ToString("C2") & vbCrLf
                formOrderDetails.lblReceipt.Text &= "Subtotal" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & subtotal.ToString("C2") & vbCrLf
                formOrderDetails.lblReceipt.Text &= "Total" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & (subtotal + n.deliveryFeeVal).ToString("C2") & vbCrLf
            End If
        Next


        'formOrderDetails.lblReceipt.Text = strReceipt

    End Sub

    'this is the button event handler for ALL ORDERS
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        flowContainer.Controls.Clear()

        Dim form1 As Form1 = ParentForm

        Dim customer As Customer = CType(form1.userVal, Customer)

        For Each n In customer.getOrderList.ToList()

            Dim orderPanel As New orderPanel()

            AddHandler orderPanel.btnOrderDetailObj.Click, AddressOf btnOrderDetailObj_Click
            orderPanel.btnOrderDetailObj.Name = "btnDetails" & n.orderIDVal
            orderPanel.btnOrderReceivedObj.Name = "btnReceived" & n.orderIDVal

            If n.statusVal = "N" Then
                orderPanel.lblStatusObj.Text = "Delivering"
                AddHandler orderPanel.btnOrderReceivedObj.Click, AddressOf orderReceived
            ElseIf n.statusVal = "Y" Then
                orderPanel.lblStatusObj.Text = "Delivered"
                orderPanel.btnOrderReceivedObj.Dispose()
            End If

            orderPanel.lblOrderIdObj.Text = n.orderIDVal
            orderPanel.lblOrderTotalObj.Text = (n.subtotalVal + n.deliveryFeeVal).ToString("C2")
            orderPanel.LblTimeVal.Text = n.timePlacedVal

            For Each a In n.getAllItem().ToList()
                orderPanel.cbxProductListObj.Items.Add(a.productNameVal & "  " & "x" & a.quantityVal)
            Next

            flowContainer.Controls.Add(orderPanel)
        Next

    End Sub

    'this is the button event handler for TO SHIP ORDER
    Private Sub btnToShip_Click(sender As Object, e As EventArgs) Handles btnToShip.Click

        flowContainer.Controls.Clear()

        Dim form1 As Form1 = ParentForm

        Dim customer As Customer = CType(form1.userVal, Customer)

        For Each n In customer.getOrderList.ToList()

            If n.statusVal.Equals("N") Then
                Dim orderPanel As New orderPanel()

                AddHandler orderPanel.btnOrderDetailObj.Click, AddressOf btnOrderDetailObj_Click
                orderPanel.btnOrderDetailObj.Name = "btnDetails" & n.orderIDVal
                orderPanel.btnOrderReceivedObj.Name = "btnReceived" & n.orderIDVal

                orderPanel.lblStatusObj.Text = "Delivering"
                AddHandler orderPanel.btnOrderReceivedObj.Click, AddressOf orderReceived

                orderPanel.lblOrderIdObj.Text = n.orderIDVal
                orderPanel.lblOrderTotalObj.Text = (n.subtotalVal + n.deliveryFeeVal).ToString("C2")
                orderPanel.LblTimeVal.Text = n.timePlacedVal

                For Each a In n.getAllItem().ToList()
                    orderPanel.cbxProductListObj.Items.Add(a.productNameVal & "  " & "x" & a.quantityVal)
                Next

                flowContainer.Controls.Add(orderPanel)
            End If
        Next
    End Sub

    'this is the button event handler for RECEIVED ORDER
    Private Sub btnReceived_Click(sender As Object, e As EventArgs) Handles btnReceived.Click

        flowContainer.Controls.Clear()

        Dim form1 As Form1 = ParentForm

        Dim customer As Customer = CType(form1.userVal, Customer)

        For Each n In customer.getOrderList.ToList()

            If n.statusVal.Equals("Y") Then
                Dim orderPanel As New orderPanel()

                orderPanel.btnOrderDetailObj.Name = "btnDetails" & n.orderIDVal
                orderPanel.btnOrderReceivedObj.Name = "btnReceived" & n.orderIDVal

                orderPanel.lblStatusObj.Text = "Delivered"
                orderPanel.btnOrderReceivedObj.Dispose()

                orderPanel.lblOrderIdObj.Text = n.orderIDVal
                orderPanel.lblOrderTotalObj.Text = (n.subtotalVal + n.deliveryFeeVal).ToString("C2")
                orderPanel.LblTimeVal.Text = n.timePlacedVal

                For Each a In n.getAllItem().ToList()
                    orderPanel.cbxProductListObj.Items.Add(a.productNameVal & "  " & "x" & a.quantityVal)
                Next

                flowContainer.Controls.Add(orderPanel)
            End If
        Next
    End Sub
End Class

'Custom control.
Public Class orderPanel : Inherits Panel
    Private lblStatus As New Label
    Private lblOrder As New Label
    Private lblOrderTotal As New Label
    Private btnOrderDetail As New Button
    Private btnOrderReceived As New Button
    Private cbxProductList As New ComboBox
    Private lbl1 As New Label
    Private panel123 As New Panel
    Private label1 As New Label
    Private lblOrderID As New Label
    Private lblTime As New Label

    Public Sub New()

        Me.BackColor = Color.White
        Me.Size = New Size(786, 264)
        Me.Margin = New Padding(0, 30, 0, 30)



        lblStatus.ForeColor = Color.SkyBlue
        lblStatus.Location = New Point(596, 19)
        lblStatus.Font = New Font("Bahnschrift Light", 12)
        lblStatus.Text = "Delivering"

        lblOrder.Text = "Order Total:"
        lblOrder.Location = New Point(614, 112)
        lblOrder.Font = New Font("Bahnschrift Light", 10)

        lblOrderTotal.ForeColor = Color.SkyBlue
        lblOrderTotal.Location = New Point(558, 139)
        lblOrderTotal.Size = New Size(180, 41)
        lblOrderTotal.Font = New Font("Bahnschrift", 18)
        lblOrderTotal.TextAlign = ContentAlignment.MiddleCenter
        lblOrderTotal.AutoSize = False
        lblOrderTotal.Text = "RM500.00"

        btnOrderDetail.BackColor = Color.SkyBlue
        btnOrderDetail.FlatStyle = FlatStyle.Flat
        btnOrderDetail.FlatAppearance.BorderSize = 0
        btnOrderDetail.Location = New Point(558, 194)
        btnOrderDetail.Size = New Size(180, 37)
        btnOrderDetail.Font = New Font("Bahnschrift SemiLight", 12)
        btnOrderDetail.Text = "Order Details"
        btnOrderDetail.ForeColor = Color.White

        btnOrderReceived.BackColor = Color.SkyBlue
        btnOrderReceived.FlatStyle = FlatStyle.Flat
        btnOrderReceived.FlatAppearance.BorderSize = 0
        btnOrderReceived.Location = New Point(349, 194)
        btnOrderReceived.Size = New Size(180, 37)
        btnOrderReceived.Font = New Font("Bahnschrift SemiLight", 12)
        btnOrderReceived.Text = "Order Received"
        btnOrderReceived.ForeColor = Color.White

        cbxProductList.Location = New Point(262, 139)
        cbxProductList.FlatStyle = FlatStyle.System
        cbxProductList.Size = New Size(151, 23)
        cbxProductList.DropDownStyle = ComboBoxStyle.DropDownList

        lbl1.Location = New Point(282, 98)
        lbl1.Size = New Size(108, 24)
        lbl1.AutoSize = False
        lbl1.Text = "Product List"
        lbl1.Font = New Font("Bahnschrift SemiLight", 12)

        label1.Size = New Size(86, 24)
        label1.AutoSize = False
        label1.Text = "Order ID"
        label1.Location = New Point(81, 83)
        label1.Font = New Font("Bahnschrift SemiLight", 12)

        lblOrderID.Size = New Size(118, 68)
        lblOrderID.AutoSize = False
        lblOrderID.Location = New Point(58, 128)
        lblOrderID.Font = New Font("Bahnschrift SemiLight", 12)
        lblOrderID.Text = "O1"
        lblOrderID.TextAlign = ContentAlignment.MiddleCenter

        panel123.Size = New Size(680, 1)
        panel123.Location = New Point(58, 51)
        panel123.BorderStyle = BorderStyle.FixedSingle

        lblTime.Size = New Size(301, 24)
        lblTime.Location = New Point(58, 19)
        lblTime.Font = New Font("Bahnschrift SemiLight", 12)
        lblTime.AutoSize = False


        Me.Controls.Add(lblOrder)
        Me.Controls.Add(lblOrderTotal)
        Me.Controls.Add(btnOrderDetail)
        Me.Controls.Add(lblStatus)
        Me.Controls.Add(cbxProductList)
        Me.Controls.Add(panel123)
        Me.Controls.Add(lblOrderID)
        Me.Controls.Add(label1)
        Me.Controls.Add(lbl1)
        Me.Controls.Add(lblTime)
        Me.Controls.Add(btnOrderReceived)
    End Sub

    Public Property lblStatusObj As Label
        Get
            Return lblStatus
        End Get
        Set(value As Label)
            lblStatus = value
        End Set
    End Property

    Public Property lblOrderObj As Label
        Get
            Return lblOrder
        End Get
        Set(value As Label)
            lblOrder = value
        End Set
    End Property

    Public Property lblOrderTotalObj As Label
        Get
            Return lblOrderTotal
        End Get
        Set(value As Label)
            lblOrderTotal = value
        End Set
    End Property

    Public Property btnOrderDetailObj As Button
        Get
            Return btnOrderDetail
        End Get
        Set(value As Button)
            btnOrderDetail = value
        End Set
    End Property

    Public Property btnOrderReceivedObj As Button
        Get
            Return btnOrderReceived
        End Get
        Set(value As Button)
            btnOrderReceived = value
        End Set
    End Property

    Public Property cbxProductListObj As ComboBox
        Get
            Return cbxProductList
        End Get
        Set(value As ComboBox)
            cbxProductList = value
        End Set
    End Property

    Public Property panel123Obj As Panel
        Get
            Return panel123
        End Get
        Set(value As Panel)
            panel123 = value
        End Set
    End Property

    Public Property label1Obj As Label
        Get
            Return label1
        End Get
        Set(value As Label)
            label1 = value
        End Set
    End Property

    Public Property lblOrderIdObj As Label
        Get
            Return lblOrderID
        End Get
        Set(value As Label)
            lblOrderID = value
        End Set
    End Property

    Public Property LblTimeVal As Label
        Get
            Return lblTime
        End Get
        Set(value As Label)
            lblTime = value
        End Set
    End Property
End Class