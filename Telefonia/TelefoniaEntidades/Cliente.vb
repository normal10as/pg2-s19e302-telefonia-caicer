Public MustInherit Class Cliente
    Public Sub New()
        Cuenta = 0
    End Sub
    Private _linea As Linea
    Public Property Cuenta As UInteger
    Public Property Linea As Linea
        Get
            Return _linea
        End Get
        Friend Set(value As Linea)
            _linea = value
        End Set
    End Property
End Class