Imports MySql.Data.MySqlClient

Public Class formLogin
    'db connection
    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader

    'Sub procedure to go sign up form
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim formRegistration As New formRegistration()
        formRegistration.Visible = True
        Me.Hide()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        If cbxRole.SelectedIndex >= 0 Then
            If txtUsername.Text.Length > 0 Then
                If txtPassword.Text.Length > 0 Then
                    If login(cbxRole.SelectedItem) Then
                        loadProfile(cbxRole.SelectedItem)
                    Else
                        MessageBox.Show("Account does not exist")
                    End If
                Else
                    MessageBox.Show("Please fill in your password")
                End If
            Else
                MessageBox.Show("Please fill in your username")
            End If
        Else
            MessageBox.Show("Please select a role")
        End If



    End Sub




    Private Sub loadProfile(role As String)

        If role.Equals("Customer") Then

            Dim customer As Customer = New Customer()

            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT * FROM Account a 
                                 JOIN Customer c ON a.accountID = c.customerID 
                                WHERE a.accountID = @accountID 
                                AND a.password = @password", conn)
                cmd.Parameters.AddWithValue("@accountID", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                reader = cmd.ExecuteReader()

                While reader.Read()

                    customer.usernameVal = txtUsername.Text
                    customer.passwordVal = txtPassword.Text
                    customer.emailVal = reader.GetString("email")
                    customer.contactVal = reader.GetString("contactNo")

                    Dim c1 = CType(customer, Customer)
                    c1.nameVal = reader.GetString("name")
                    c1.balanceVal = reader.GetString("wallet")
                    c1.dobVal = reader.GetDateTime("DOB")

                    Dim form1 As New Form1(customer)
                    form1.Visible = True
                    form1.linkLogin.Text = txtUsername.Text
                    Me.Hide()

                End While


            Catch ex As Exception
                MessageBox.Show(ex.Message())

            Finally
                conn.Close()
                cmd.Dispose()
            End Try

            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT DISTINCT(orderID),address,state,city,postcode,subTotal,deliveryFee,timePlaced,c.customerID AS customerID,isArrived AS status
                                        From Customer c Join Orders o 
                                        ON c.customerID = o.customerID
                                        WHERE c.customerID = @customerID", conn)
                cmd.Parameters.AddWithValue("@customerID", customer.usernameVal)

                reader = cmd.ExecuteReader()

                While reader.Read()

                    Dim order As New Order(reader.GetString("orderID"), reader.GetString("address"), reader.GetString("state"), reader.GetString("city"), reader.GetString("postcode"), reader.GetDouble("subTotal"), reader.GetDouble("deliveryFee"), reader.GetMySqlDateTime("timePlaced"), reader.GetString("status"))
                    customer.addOrder(order)

                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                reader.Close()
                conn.Close()
                cmd.Dispose()
            End Try

            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT od.quantity AS quantity,od.productID AS productID,name,price
                                        FROM OrderDetails od JOIN Product p 
                                        ON od.productID = p.productID 
                                        WHERE orderID = @orderID", conn)

                For Each n In customer.getOrderList.ToList()
                    cmd.Parameters.AddWithValue("@orderID", n.orderIDVal)
                    reader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim item As New Item()
                        item.productIDVal = reader.GetString("productID")
                        item.quantityVal = reader.GetString("quantity")
                        item.productNameVal = reader.GetString("name")
                        item.productPriceVal = reader.GetString("price")

                        n.addItem(item)

                    End While
                    cmd.Parameters.Clear()
                    reader.Close()

                Next


            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                cmd.Dispose()
            End Try
        ElseIf role.Equals("Supplier") Then

            Dim supplier As New Supplier()

            Try
                conn.Open()
                cmd = New MySqlCommand("SELECT accountID,password,email,contactNo,name FROM Account a 
                                        JOIN Supplier s
                                        ON a.accountID = s.supplierID 
                                        WHERE accountID = @accountID AND password = @password", conn)
                cmd.Parameters.AddWithValue("@accountID", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                reader = cmd.ExecuteReader()

                While reader.Read()

                    supplier.usernameVal = reader.GetString("accountID")
                    supplier.passwordVal = reader.GetString("password")
                    supplier.emailVal = reader.GetString("email")
                    supplier.contactVal = reader.GetString("contactNo")
                    supplier.nameVal = reader.GetString("name")

                    Dim supplierForm As New SupplierForm(supplier)
                    supplierForm.Visible = True
                    Me.Hide()

                End While

            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                conn.Dispose()
            End Try


        ElseIf role.Equals("Admin") Then
            Dim riderOverview As New riderOverview()
            riderOverview.Visible = True
            Me.Hide()
        End If
    End Sub

    Private Function login(role As String) As Boolean

        cmd = New MySqlCommand()
        cmd.Connection = conn

        If role.Equals("Customer") Or role.Equals("Supplier") Or role.Equals("Admin") Then
            If role.Equals("Customer") Then
                cmd.CommandText = "SELECT * FROM Account a 
                                 JOIN Customer c ON a.accountID = c.customerID 
                                WHERE a.accountID = @accountID 
                                AND a.password = @password"
            ElseIf role.Equals("Supplier") Then

                cmd.CommandText = "SELECT accountID,password FROM Account a 
                                        JOIN Supplier s
                                        ON a.accountID = s.supplierID 
                                        WHERE accountID = @accountID AND password = @password"
            ElseIf role.Equals("Admin") Then
                cmd.CommandText = "SELECT accountID,password FROM Account 
                                        WHERE accountID = @accountID AND password = @password"
            End If


            Try
                conn.Open()

                cmd.Parameters.AddWithValue("@accountID", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)


                reader = cmd.ExecuteReader()

                If reader.HasRows() Then
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                cmd.Dispose()
                reader.Close()
            End Try
        End If


        Return False

    End Function

End Class