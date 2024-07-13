Imports MySql.Data.MySqlClient
Public Class formRegistration
    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim formLogin As New formLogin()
        formLogin.Visible = True
        Me.Dispose()

    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click

        Dim d1 As Date = Date.Now()

        'validate the whole registration field.
        validateName()
        validateDOB()
        validateEmail()
        validateUsername()
        validateContact()
        validatePassword()

        If nameWarning.Visible = False And dobWarning.Visible = False And emailWarning.Visible = False And usernameWarning.Visible = False And contactWarning.Visible = False And passwordWarning.Visible = False And confirmWarning.Visible = False Then
            Try
                conn.Open()
                cmd = New MySqlCommand("INSERT INTO Account VALUES (@accountID,@password)", conn)
                cmd.Parameters.AddWithValue("@accountID", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                Try
                    cmd = New MySqlCommand("INSERT INTO Customer(customerID,name,email,contactNo,DOB) VALUES (@customerID,@customerName,@customerEmail,@contactNo,@DOB)", conn)
                    cmd.Parameters.AddWithValue("@customerID", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@customerName", txtName.Text)
                    cmd.Parameters.AddWithValue("@customerEmail", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@contactNo", txtContact.Text)
                    cmd.Parameters.AddWithValue("@DOB", dobPicker.Value.Year & "-" & dobPicker.Value.Month & "-" & dobPicker.Value.Day)
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                End Try
            Catch ex As Exception
                MessageBox.Show("username exists")
            Finally
                conn.Close()
                MessageBox.Show("Account has been created")
                Dim formLogin As New formLogin()
                formLogin.Visible = True
                Me.Dispose()
            End Try


        Else
            MessageBox.Show("Please complete the field")
            MessageBox.Show(dobPicker.Value.Year & "-" & dobPicker.Value.Month & "-" & dobPicker.Value.Day)
        End If
    End Sub

    Private Sub validateName()

        If (txtName.Text.Length > 0) Then
            Dim hasNum As Boolean = False
            For Each n In txtName.Text
                If Char.IsNumber(n) Then
                    hasNum = True
                    nameWarning.Visible = True
                    Exit For
                Else
                    nameWarning.Visible = False
                End If
            Next
        Else
            nameWarning.Visible = True
        End If



    End Sub

    Private Sub validateEmail()

        If (txtEmail.Text.Length > 0) Then
            If (txtEmail.Text.Trim Like "*@[A-Z]*.*" Or txtEmail.Text.Trim Like "*@[a-z]*.*" Or txtEmail.Text.Trim Like "*@[0-9]*.*" Or txtEmail.Text.Trim Like "*@[a-z]*-[a-z]*.*") And Not txtEmail.Text.Trim Like "@*.*" Then
                emailWarning.Visible = False
            Else
                emailWarning.Visible = True
            End If
        Else
            emailWarning.Visible = True
        End If

    End Sub
    Private Sub validateDOB()

        Dim d1 As Date = Date.Now()

        If (d1.Year - dobPicker.Value.Year) >= 12 Then
            dobWarning.Visible = False
        Else
            dobWarning.Visible = True
        End If
    End Sub

    Private Sub validateUsername()

        If (txtUsername.Text.Length > 0) Then
            If (txtUsername.Text.Length >= 5) Then
                usernameWarning.Visible = False
            Else
                usernameWarning.Visible = True
            End If
        Else
            usernameWarning.Visible = True
        End If
    End Sub

    Private Sub validateContact()

        If txtContact.Text.Length > 0 Then
            If txtContact.Text.Substring(0, 3) = "011" Then
                If txtContact.Text Like "###########" Then
                    contactWarning.Visible = False
                Else
                    contactWarning.Visible = True
                End If
            End If

            If txtContact.Text.Substring(0, 3) Like "01[2-9]" Then
                If txtContact.Text Like "##########" Then
                    contactWarning.Visible = False
                Else
                    contactWarning.Visible = True
                End If
            End If

            If Not txtContact.Text.Substring(0, 3) Like "01[1-9]" Then
                contactWarning.Visible = True
            End If
        Else
            contactWarning.Visible = True
        End If
    End Sub

    Private Sub validatePassword()

        If txtPassword.Text.Length > 0 Then
            If txtPassword.Text.Length >= 6 Then
                passwordWarning.Visible = False
            Else
                passwordWarning.Visible = True
            End If
        Else
            passwordWarning.Visible = True
        End If

        If txtConfirmPassword.Text.Length > 0 Then
            If txtConfirmPassword.Text.Equals(txtPassword.Text) Then
                confirmWarning.Visible = False
            Else
                confirmWarning.Visible = True
            End If
        Else
            confirmWarning.Visible = True
        End If
    End Sub
End Class