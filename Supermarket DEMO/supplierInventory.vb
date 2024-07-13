Imports MySql.Data.MySqlClient
Imports System.IO
Public Class supplierInventory

    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private adapter As MySqlDataAdapter
    Private productID As String
    Private reader As MySqlDataReader

    Private Sub btnUploadImg_Click(sender As Object, e As EventArgs) Handles btnUploadImg.Click
        OpenFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picAddImg.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        OpenFileDialog2.Filter = "Image files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png"

        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            picEditImg.Image = Image.FromFile(OpenFileDialog2.FileName)
        End If
    End Sub

    Private Function getProductId() As String

        Dim productID As String = ""
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT productID FROM Product ORDER BY productID DESC LIMIT 1", conn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                productID = reader.GetString("productID")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            cmd.Dispose()
        End Try

        Return productID

    End Function
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        If picAddImg.Image IsNot Nothing And txtAddCategory.Text.Length > 0 And txtAddDesc.Text.Length > 0 And txtAddName.Text.Length > 0 And txtAddQuantity.Text.Length > 0 And txtAddPrice.Text.Length > 0 Then

            Dim productId As String = getProductId()

            If productId = "" Then
                Try
                    conn.Open()
                    Dim sql As String = "INSERT INTO Product(productID,name,price,description,quantity,category,img)
                                VALUES (@productID,@productName,@productPrice,@productDesc,@productQuantity,@productCategory,@productImg)"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@productID", "P1")
                    cmd.Parameters.AddWithValue("@productName", txtAddName.Text)
                    cmd.Parameters.AddWithValue("@productPrice", txtAddPrice.Text)
                    cmd.Parameters.AddWithValue("@productDesc", txtAddDesc.Text)
                    cmd.Parameters.AddWithValue("@productQuantity", txtAddQuantity.Text)
                    cmd.Parameters.AddWithValue("@productCategory", txtAddCategory.Text)

                    Dim ms As New MemoryStream
                    picAddImg.Image.Save(ms, picAddImg.Image.RawFormat)
                    Dim img As Byte()
                    img = ms.ToArray()
                    cmd.Parameters.AddWithValue("@productImg", img)

                    cmd.ExecuteNonQuery()

                    ms.Dispose()

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()
                    cmd.Dispose()
                    loadTable()
                    resetAdd()
                End Try
            Else
                Try
                    conn.Open()
                    Dim sql As String = "INSERT INTO Product(productID,name,price,description,quantity,category,img)
                                VALUES (@productID,@productName,@productPrice,@productDesc,@productQuantity,@productCategory,@productImg)"
                    cmd = New MySqlCommand(sql, conn)


                    cmd.Parameters.AddWithValue("@productID", "P" & Integer.Parse(productId.Substring(1, productId.Length - 1)) + 1)
                    cmd.Parameters.AddWithValue("@productName", txtAddName.Text)
                    cmd.Parameters.AddWithValue("@productPrice", txtAddPrice.Text)
                    cmd.Parameters.AddWithValue("@productDesc", txtAddDesc.Text)
                    cmd.Parameters.AddWithValue("@productQuantity", txtAddQuantity.Text)
                    cmd.Parameters.AddWithValue("@productCategory", txtAddCategory.Text)

                    Dim ms As New MemoryStream
                    picAddImg.Image.Save(ms, picAddImg.Image.RawFormat)
                    Dim img As Byte()
                    img = ms.ToArray()
                    cmd.Parameters.AddWithValue("@productImg", img)

                    cmd.ExecuteNonQuery()

                    ms.Dispose()

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()
                    cmd.Dispose()
                    loadTable()
                    resetAdd()
                End Try

            End If
        Else
            MessageBox.Show("Please fill in all required field")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnAddReset.Click
        resetAdd()
    End Sub

    Private Sub resetAdd()
        txtAddCategory.Text = ""
        txtAddDesc.Text = ""
        txtAddName.Text = ""
        txtAddPrice.Text = ""
        txtAddQuantity.Text = ""
        picAddImg.Image = Nothing
    End Sub
    Private Sub txtAddPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddPrice.KeyPress, txtAddQuantity.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) And Not e.KeyChar = Chr(46) Then
            e.Handled = True
            MessageBox.Show("Please enter number only")
        End If
    End Sub

    Private Sub supplierInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        cbxMode.SelectedIndex = 0

    End Sub

    Private Sub loadTable()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Product", conn)
            adapter = New MySqlDataAdapter(cmd)

            Dim dt As New DataTable()
            adapter.Fill(dt)
            addTable.DataSource = dt
            overviewTable.DataSource = dt
            editTable.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            cmd.Dispose()
            adapter.Dispose()

        End Try
    End Sub

    Private Sub cbxMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMode.SelectedIndexChanged

        If cbxMode.SelectedItem = "Add Mode" Then
            lblTitle.Text = "Add Mode"
            panelAddProduct.BringToFront()
            loadTable()
        ElseIf cbxMode.SelectedItem = "Overview" Then
            lblTitle.Text = "Overview"
            panelOverview.BringToFront()
            loadTable()
        ElseIf cbxMode.SelectedItem = "Edit Mode" Then
            lblTitle.Text = "Edit Mode"
            panelEdit.BringToFront()
            loadTable()

        End If
    End Sub

    Private Sub editTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles editTable.CellContentClick

        productID = editTable.CurrentRow.Cells("productID").Value.ToString()
        txtEditName.Text = editTable.CurrentRow.Cells("name").Value.ToString()
        txtEditQuantity.Text = editTable.CurrentRow.Cells("quantity").Value.ToString()
        txtEditPrice.Text = editTable.CurrentRow.Cells("price").Value.ToString()
        txtEditDesc.Text = editTable.CurrentRow.Cells("description").Value.ToString()
        txtEditCategory.Text = editTable.CurrentRow.Cells("category").Value.ToString()
        Dim bytes As Byte() = editTable.CurrentRow.Cells("img").Value
        Dim ms As New MemoryStream(bytes)
        picEditImg.Image = Image.FromStream(ms)

    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        resetEdit()
    End Sub

    Private Sub resetEdit()
        txtEditCategory.Text = ""
        txtEditDesc.Text = ""
        txtEditName.Text = ""
        txtEditPrice.Text = ""
        txtEditQuantity.Text = ""
        picEditImg.Image = Nothing
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEditCategory.Text.Length > 0 And txtEditDesc.Text.Length > 0 And txtEditName.Text.Length > 0 And txtEditPrice.Text.Length > 0 And txtEditQuantity.Text.Length > 0 And picEditImg.Image IsNot Nothing Then


            Try
                conn.Open()
                cmd = New MySqlCommand("UPDATE Product
                                        SET name = @name,
                                        price = @price,
                                        description = @description,
                                        quantity = @quantity,
                                        category = @category,
                                        img = @img 
                                        WHERE productID = @productID", conn)
                cmd.Parameters.AddWithValue("@name", txtEditName.Text)
                cmd.Parameters.AddWithValue("@price", txtEditPrice.Text)
                cmd.Parameters.AddWithValue("@description", txtEditDesc.Text)
                cmd.Parameters.AddWithValue("@quantity", txtEditQuantity.Text)
                cmd.Parameters.AddWithValue("@category", txtEditCategory.Text)

                Dim ms As New MemoryStream
                picEditImg.Image.Save(ms, picEditImg.Image.RawFormat)
                Dim img As Byte()
                img = ms.ToArray()
                cmd.Parameters.AddWithValue("@img", img)
                cmd.Parameters.AddWithValue("@productID", productID)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Product ID:" & productID & " " & "has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            Finally
                conn.Close()
                cmd.Dispose()
                loadTable()
                resetEdit()
            End Try

        Else
            MessageBox.Show("Please complete the required field")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If txtEditCategory.Text.Length > 0 And txtEditDesc.Text.Length > 0 And txtEditName.Text.Length > 0 And txtEditPrice.Text.Length > 0 And txtEditQuantity.Text.Length > 0 And picEditImg.Image IsNot Nothing Then
            If productID IsNot String.Empty Then

                Dim result As DialogResult = MessageBox.Show("Are you sure to delete from database", "Delete from database", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

                If result = DialogResult.Yes Then
                    Try
                        conn.Open()
                        cmd = New MySqlCommand("DELETE FROM Product
                                            WHERE productID = @productID", conn)
                        cmd.Parameters.AddWithValue("@productID", productID)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Product ID:" & productID & " has been successfully deleted")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message())
                    Finally
                        conn.Close()
                        cmd.Dispose()
                        loadTable()
                        resetEdit()
                    End Try
                End If

            End If

        Else
            MessageBox.Show("Please complete the required field")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Product WHERE name LIKE @productName", conn)
            cmd.Parameters.AddWithValue("@productName", "%" & txtOverviewName.Text & "%")
            adapter = New MySqlDataAdapter(cmd)
            Dim ds = New DataSet()
            adapter.Fill(ds, "newProductTbl")
            overviewTable.DataSource = Nothing
            overviewTable.DataSource = ds.Tables("newProductTbl")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub


End Class