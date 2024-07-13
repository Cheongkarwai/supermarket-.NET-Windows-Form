Public Class Item

    Private quantity As Integer
    Private productID As String
    Private productName As String
    Private price As Double
    Public Property quantityVal As Integer
        Get
            Return quantity
        End Get
        Set(value As Integer)
            quantity = value
        End Set
    End Property

    Public Property productIDVal As String
        Get
            Return productID
        End Get
        Set(value As String)
            productID = value
        End Set
    End Property
    Public Property productPriceVal As Double
        Get
            Return price
        End Get
        Set(value As Double)
            price = value
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
End Class
