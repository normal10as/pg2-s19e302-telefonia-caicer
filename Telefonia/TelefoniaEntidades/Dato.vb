Public Class Dato
    Inherits Servicio
    Sub New(precio As Decimal, credio As UInteger)
        Me.Precio = precio
        Me.credito = credito
    End Sub
    Public Overrides Sub NuevoConsumo(valor As UInteger)

    End Sub
    Public Overrides Function toString() As String
        Return credito & " Mbytes"
    End Function
End Class
