Imports MySql.Data.MySqlClient

Public Class riderOverview

    Private currentForm As Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openForm(riderHome)
        linkLogin.Text = "admin"

    End Sub
    Public Sub openForm(frm As Form)

        'set the form 
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True

        'if it has nothing
        If currentForm Is Nothing Then
            'add into container
            panelForm.Controls.Add(frm)
            currentForm = frm
        Else
            'if the current form is not the form passed in the argument
            If currentForm IsNot frm Then
                'dispose current form and add new form into container
                currentForm.Dispose()
                panelForm.Controls.Add(frm)
                currentForm = frm
            End If
        End If
    End Sub

    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    '    openForm(Rider_Service
    '             )
    'End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        openForm(riderHome)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        openForm(riderHistory)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnRiderService.Click
        openForm(riderService)
    End Sub

    Private Sub linkLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogout.LinkClicked
        Me.Dispose()
        Dim loginForm As New formLogin()
        loginForm.Visible = True
    End Sub

    Private Sub linkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLogin.LinkClicked
        If panelLogout.Visible = False Then
            panelLogout.Visible = True
        Else
            panelLogout.Visible = False
        End If
    End Sub
End Class