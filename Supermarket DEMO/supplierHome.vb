
Imports MySql.Data.MySqlClient
Public Class supplierHome
    Private conn As MySqlConnection = DatabaseConnection.connect()
    Private cmd As MySqlCommand
    Private adapter As MySqlDataAdapter

    Private Sub loadTable()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM Product", conn)
            adapter = New MySqlDataAdapter(cmd)

            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvInventory.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            conn.Close()
            cmd.Dispose()
            adapter.Dispose()

        End Try
    End Sub

    Private Sub timerTotalSales_Tick(sender As Object, e As EventArgs) Handles timerTotalSales.Tick


        progressBarSales.Value += 1

        If progressBarSales.Value > 50 Then
            timerTotalSales.Stop()
        End If
    End Sub

    Private Sub supplierHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressBarSales.Value = 0
        timerTotalSales.Interval = 30
        timerTotalSales.Start()

        progressBarProduct.Value = 0
        timerNewProduct.Interval = 30
        timerNewProduct.Start()
        loadTable()
    End Sub


    Private Sub timerNewProduct_Tick(sender As Object, e As EventArgs) Handles timerNewProduct.Tick
        progressBarProduct.Value += 1
        If progressBarProduct.Value > 50 Then
            timerNewProduct.Stop()
        End If
    End Sub
End Class