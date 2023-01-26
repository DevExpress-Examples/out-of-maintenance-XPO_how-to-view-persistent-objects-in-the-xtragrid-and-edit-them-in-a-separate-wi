Imports DevExpress.Xpo

Namespace XpoEditForm

    Public Class Order
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private fCustomer As String

        Public Property Customer As String
            Get
                Return fCustomer
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Customer", fCustomer, value)
            End Set
        End Property

        Private fOrderDate As Date

        Public Property OrderDate As Date
            Get
                Return fOrderDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue("OrderDate", fOrderDate, value)
            End Set
        End Property

        <Association("Order-Details")>
        Public ReadOnly Property OrderDetails As XPCollection(Of OrderDetail)
            Get
                Return GetCollection(Of OrderDetail)("OrderDetails")
            End Get
        End Property
    End Class

    Public Class OrderDetail
        Inherits XPObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private fProductName As String

        Public Property ProductName As String
            Get
                Return fProductName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("ProductName", fProductName, value)
            End Set
        End Property

        Private fOrderDate As Date

        Public Property OrderDate As Date
            Get
                Return fOrderDate
            End Get

            Set(ByVal value As Date)
                SetPropertyValue("OrderDate", fOrderDate, value)
            End Set
        End Property

        Private fQuantity As Integer

        Public Property Quantity As Integer
            Get
                Return fQuantity
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue("Quantity", fQuantity, value)
            End Set
        End Property

        Private fPrice As Decimal

        Public Property Price As Decimal
            Get
                Return fPrice
            End Get

            Set(ByVal value As Decimal)
                SetPropertyValue("Price", fPrice, value)
            End Set
        End Property

        Private fOrder As Order

        <Association("Order-Details")>
        Public Property Order As Order
            Get
                Return fOrder
            End Get

            Set(ByVal value As Order)
                SetPropertyValue("Order", fOrder, value)
            End Set
        End Property
    End Class
End Namespace
