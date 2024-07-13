Public Class Order

    Private orderID As String
    Private address As String
    Private state As String
    Private city As String
    Private postcode As String
    Private subtotal As Double
    Private deliveryFee As Double
    Private timePlaced As Date
    Private riderID As String
    Private status As String
    Private itemList As List(Of Item)

    Public Sub New(orderID As String, address As String, state As String, city As String, postcode As String, subtotal As Double, deliveryFee As Double, timePlaced As Date, status As String)
        itemList = New List(Of Item)
        Me.orderID = orderID
        Me.address = address
        Me.state = state
        Me.city = city
        Me.postcode = postcode
        Me.subtotal = subtotal
        Me.deliveryFee = deliveryFee
        Me.timePlaced = timePlaced
        Me.status = status
    End Sub

    Public Property orderIDVal As String
        Get
            Return orderID
        End Get
        Set(value As String)
            orderID = value
        End Set
    End Property

    Public Property addressVal As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property

    Public Property stateVal As String
        Get
            Return state
        End Get
        Set(value As String)
            state = value
        End Set
    End Property

    Public Property cityVal As String
        Get
            Return city
        End Get
        Set(value As String)
            city = value
        End Set
    End Property

    Public Property postcodeVal As String
        Get
            Return postcode
        End Get
        Set(value As String)
            postcode = value
        End Set
    End Property

    Public Property subtotalVal As Double
        Get
            Return subtotal
        End Get
        Set(value As Double)
            subtotal = value
        End Set
    End Property

    Public Property deliveryFeeVal As Double
        Get
            Return deliveryFee
        End Get
        Set(value As Double)
            deliveryFee = value
        End Set
    End Property

    Public Property timePlacedVal As Date
        Get
            Return timePlaced
        End Get
        Set(value As Date)
            timePlaced = value
        End Set
    End Property

    Public Property riderIDVal As String
        Get
            Return riderID
        End Get
        Set(value As String)
            riderID = value
        End Set
    End Property

    Public Property statusVal As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

    Public Sub addItem(item As Item)
        itemList.Add(item)
    End Sub

    Public Function getAllItem() As List(Of Item)
        Return itemList
    End Function
End Class
