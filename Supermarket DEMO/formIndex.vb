Public Class formIndex
    Private Sub btnProductPage_Click(sender As Object, e As EventArgs) Handles btnProductPage.Click, btnFirstProduct.Click, btnSecondProduct.Click, btnThirdProduct.Click

        Dim form1 As Form1 = ParentForm

        If form1.currentBtn IsNot form1.btnProduct Then
            form1.toggleBtn(form1.btnProduct, form1.udlProduct, Color.SkyBlue)
        End If
        form1.openForm(formProduct)

    End Sub


End Class