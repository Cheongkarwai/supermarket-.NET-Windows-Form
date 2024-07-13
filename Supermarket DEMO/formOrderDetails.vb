Public Class formOrderDetails
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PageSetupDialog1.Document = PrintDocument1

        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If



    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(lblReceipt.Text, lblReceipt.Font, Brushes.Black, 100, 100)
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Dispose()
    End Sub

    Private Sub formOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class