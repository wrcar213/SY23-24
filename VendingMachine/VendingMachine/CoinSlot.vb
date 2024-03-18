Public Class CoinSlot
    Public Event CoinReturnEvent(D As Integer, Q As Integer, Di As Integer, N As Integer)
    Public Event buyevent(p As Image)
    Public Property Quarter As Decimal
    Public Property Nickel As Decimal
    Public Property Dime As Decimal
    Public Property Dollar As Decimal
    Dim _Total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _Total = Dollar * 1000 + Quarter * 500 + Dime * 100 + Nickel * 50
            Return _Total
        End Get
    End Property
    Sub InsertQuarter()
        Quarter = Quarter + 1
    End Sub
    Sub InsertNickel()
        Nickel = Nickel + 1
    End Sub
    Sub InsertDime()
        Dime = Dime + 1
    End Sub
    Sub InsertDollar()
        Dollar = Dollar + 1
    End Sub
    Sub CoinReturn()
        RaiseEvent CoinReturnEvent(Dollar, Quarter, Dime, Nickel)
    End Sub
    Sub buy(p As ProductControl)
        If p.productCount > 0 And p.productPrice <= _Total Then
            p.Buy()
            _Total = _Total - p.productPrice
            Quarter = 0
            Dollar = 0
            Dime = 0
            Nickel = 0
            RaiseEvent buyevent(p.productImage)
        End If
    End Sub

End Class
