Imports MySql.Data.MySqlClient
Public Class riderService
    Private conn As New MySqlConnection("server=localhost;database=supermarket;username=root;password=root")
    Private adapter As MySqlDataAdapter
    Private cmd As MySqlCommand
    Private ds As New DataSet
    Private reader As MySqlDataReader

    Private Sub Rider_Service_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadOrderTbl()
        loadRider()
    End Sub

    Private Sub reloadOrderTbl()

        dgvOrder.DataSource = Nothing

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Orders WHERE riderID IS NULL", conn)
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "orderTbl")
            dgvOrder.DataSource = ds.Tables("orderTbl")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub loadRider()

        cbxRiderID.Items.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Rider", conn)
            reader = cmd.ExecuteReader()

            While reader.Read()
                cbxRiderID.Items.Add(reader.GetString("riderID"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrder.CellContentClick
        txtOrderID.Text = dgvOrder.CurrentRow.Cells("orderID").Value.ToString()

    End Sub

    Private Sub cbxRiderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRiderID.SelectedIndexChanged
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT name FROM Rider WHERE riderID=@riderID", conn)
            cmd.Parameters.AddWithValue("@riderID", cbxRiderID.SelectedItem.ToString())
            reader = cmd.ExecuteReader()

            While reader.Read
                txtRiderName.Text = reader.GetString(0)
            End While

        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        If (txtOrderID.Text.Length > 0) Then
            If cbxRiderID.SelectedIndex >= 0 Then
                Try
                    conn.Open()
                    cmd = New MySqlCommand("INSERT INTO Schedule VALUES (@riderID,@orderID,@outForDelivery,@arrivalDate)", conn)
                    cmd.Parameters.AddWithValue("@riderID", cbxRiderID.SelectedItem)
                    cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text)
                    cmd.Parameters.AddWithValue("@outForDelivery", dateOutForDelivery.Value.Year & "-" & dateOutForDelivery.Value.Month & "-" & dateOutForDelivery.Value.Day)
                    cmd.Parameters.AddWithValue("@arrivalDate", dateOutForDelivery.Value.Year & "-" & dateOutForDelivery.Value.Month & "-" & dateOutForDelivery.Value.Day)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Out For Delivery")
                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()

                End Try
                Try
                    conn.Open()
                    cmd = New MySqlCommand("UPDATE Orders SET riderID = @riderID WHERE orderID = @orderID", conn)
                    cmd.Parameters.AddWithValue("@riderID", cbxRiderID.SelectedItem)
                    cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                Finally
                    conn.Close()
                    reloadOrderTbl()
                End Try
            Else
                MessageBox.Show("Please select rider ID")
            End If
        Else
            MessageBox.Show("Please select an order from the table")
        End If

    End Sub
End Class