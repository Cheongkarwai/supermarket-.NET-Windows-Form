Imports MySql.Data.MySqlClient
Public Class riderHistory
    Private conn As New MySqlConnection("server=localhost;database=Supermarket;userid=root;password=root")
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader
    Private adapter As MySqlDataAdapter
    Private ds As New DataSet


    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderHistory.CellContentClick
        txtOrderId.Text = dgvOrderHistory.CurrentRow.Cells("orderID").Value.ToString()
        txtName.Text = dgvOrderHistory.CurrentRow.Cells("customerID").Value.ToString()
        txtRider.Text = dgvOrderHistory.CurrentRow.Cells("riderID").Value.ToString()
        txtDelivery.Text = dgvOrderHistory.CurrentRow.Cells("address").Value.ToString() &
            "," & vbCrLf & dgvOrderHistory.CurrentRow.Cells("postcode").Value.ToString() &
            "," & vbCrLf & dgvOrderHistory.CurrentRow.Cells("state").Value.ToString() &
            "," & vbCrLf & dgvOrderHistory.CurrentRow.Cells("city").Value.ToString()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Orders WHERE isArrived = @stat", conn)
            cmd.Parameters.AddWithValue("@stat", "Y")
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "orderHistory")
            dgvOrderHistory.DataSource = ds
            dgvOrderHistory.DataMember = "orderHistory"

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub
End Class