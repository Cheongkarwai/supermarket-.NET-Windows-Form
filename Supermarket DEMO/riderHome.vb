Imports MySql.Data.MySqlClient
Public Class riderHome
    Private conn As New MySqlConnection("server=localhost;database=Supermarket;username=root;password=root")
    Private adapter As MySqlDataAdapter
    Private ds As New DataSet()
    Private cmd As MySqlCommand
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Delivered order with rider assigned
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Orders WHERE isArrived = @stat AND riderID IS NOT NULL", conn)
            cmd.Parameters.AddWithValue("@stat", "Y")
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "orderDone")
            dgvOrderDone.DataSource = ds.Tables("orderDone")

            cmd.Dispose()
            adapter.Dispose()

            'Pending order with rider assigned
            cmd = New MySqlCommand("SELECT * FROM Orders WHERE isArrived = @stat AND riderID IS NOT NULL", conn)
            cmd.Parameters.AddWithValue("@stat", "N")
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "orderPending")

            dgvOrderPending.DataSource = ds.Tables("orderPending")

            'All order
            cmd = New MySqlCommand("SELECT * FROM Orders", conn)
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(ds, "allOrder")

            dgvAllOrder.DataSource = ds.Tables("allOrder")

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
        End Try
    End Sub


End Class