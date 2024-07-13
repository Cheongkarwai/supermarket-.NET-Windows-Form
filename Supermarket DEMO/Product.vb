Public Class Product
    Private productID As String
    Private productName As String
    Private productPrice As Double
    Private productDesc As String
    Private quantity As Integer
    Private category As String

    Public Property productIDVal As String
        Get
            Return productID
        End Get
        Set(value As String)
            productID = value
        End Set
    End Property

    Public Property productNameVal As String
        Get
            Return productName
        End Get
        Set(value As String)
            productName = value
        End Set
    End Property

    Public Property productPriceVal As Double
        Get
            Return productPrice
        End Get
        Set(value As Double)
            productPrice = value
        End Set
    End Property

    Public Property productDescVal As String
        Get
            Return productDesc
        End Get
        Set(value As String)
            productDesc = value
        End Set
    End Property

    Public Property quantityVal As Integer
        Get
            Return quantity
        End Get
        Set(value As Integer)
            quantity = value
        End Set
    End Property

    Public Property categoryVal As String
        Get
            Return category
        End Get
        Set(value As String)
            category = value
        End Set
    End Property
End Class
