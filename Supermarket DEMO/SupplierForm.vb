Public Class SupplierForm

    Public user As User
    Public currentForm As Form

    Public Sub New(user As User)

        ' This call is required by the designer.
        InitializeComponent()
        Me.user = user
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub SupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linkLogin.Text = user.usernameVal
        openForm(supplierHome)
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

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        openForm(supplierInventory)
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        openForm(supplierAccount)
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        openForm(supplierHome)
    End Sub
End Class