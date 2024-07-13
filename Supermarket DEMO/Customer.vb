Public Class Customer : Implements User

    Private username As String
    Private password As String
    Private name As String
    Private dob As Date
    Private email As String
    Private contact As String
    Private balance As Double

    Private cart As List(Of Item)

    Private orderList As List(Of Order)

    Public Sub New()
        cart = New List(Of Item)
        orderList = New List(Of Order)
    End Sub

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

    Public Property nameVal As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property dobVal As Date
        Get
            Return dob
        End Get
        Set(value As Date)
            dob = value
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

    Public Property balanceVal As Double
        Get
            Return balance
        End Get
        Set(value As Double)
            balance = value
        End Set
    End Property

    Public Sub addItem(productID As String, quantity As Integer, price As Double, name As String)
        Dim item As New Item()
        item.productIDVal = productID
        item.quantityVal = quantity
        item.productPriceVal = price
        item.productNameVal = name
        cart.Add(item)
    End Sub

    Public Sub removeItem(productID As String)
        For Each n In cart.ToList()
            If (n.productIDVal.Equals(productID)) Then
                cart.Remove(n)
            End If
        Next
    End Sub

    Public Function getList() As List(Of Item)
        Return cart
    End Function

    Public Sub addOrder(order As Order)
        orderList.Add(order)
    End Sub

    Public Function getOrderList() As List(Of Order)
        Return orderList
    End Function
End Class
