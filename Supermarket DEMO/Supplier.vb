Public Class Supplier : Implements User

    Private username As String
    Private password As String
    Private email As String
    Private contact As String
    Private name As String

    Public Property usernameVal As String Implements User.usernameVal
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property passwordVal As String Implements User.passwordVal
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property emailVal As String Implements User.emailVal
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property contactVal As String Implements User.contactVal
        Get
            Return contact
        End Get
        Set(value As String)
            contact = value
        End Set
    End Property

    Public Property nameVal As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
End Class
