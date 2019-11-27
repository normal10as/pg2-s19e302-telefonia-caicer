Public Class Voz
    Inherits Servicio
    Sub New(precio As Decimal, credito As UInteger)
        Me.Precio = precio
        Me.credito = credito
    End Sub
    Public Overrides Function toString() As String
        Return credito & " Minutos"
    End Function
End Class
