Imports TelefoniaEntidades
Public Class Paquete
    Implements Plan
    Public Property Nombre As String
    Private _servicios As List(Of Servicio)
    Public Property Precio As Decimal Implements Plan.Precio

    Public Function getDisponilbeToString() As String Implements Plan.getDisponilbeToString
        Throw New NotImplementedException()
    End Function

    Public Function getConsumosToString() As String Implements Plan.getConsumosToString
        Throw New NotImplementedException()
    End Function
    Public Sub AddServicio(servicio As Servicio)
        _servicios.Add(servicio)
    End Sub
    Public Function RemoverServicios(servicio As Servicio)
        _servicios.Remove(servicio)
    End Function
    Public Function GetAllServicios() As List(Of Servicio)
        Return _servicios
    End Function

End Class