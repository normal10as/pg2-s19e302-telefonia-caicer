Imports TelefoniaEntidades

Public MustInherit Class Servicio
    Implements Plan
    Public Property Credito As UInteger
    Public Property Precio As Decimal Implements Plan.Precio
    Public Function getDisponilbeToString() As String Implements Plan.getDisponilbeToString
        Return
    End Function

    Public Function getConsumosToString() As String Implements Plan.getConsumosToString
        Throw New NotImplementedException()
    End Function
    Public Overridable Sub NuevoConsumo(valor As UInteger)
        Dim sumatoriaConsumo As UInteger
        sumatoriaConsumo += valor
    End Sub
    Public Function GetDisponible() As UInteger
        Return credito - NuevoConsumo()
    End Function
End Class
