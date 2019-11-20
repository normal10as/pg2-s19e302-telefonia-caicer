Public Class Equipo
    Sub New(serie As String, modelo As Modelo)
        Me.Serie = serie
        Me.Modelo = modelo
    End Sub
    Private _serie As String
    Public Property Modelo As Modelo
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If value.Length <= 15 And value.Length > 0 Then
                _serie = value
            End If
        End Set
    End Property
    Public ReadOnly Property FechaVenta As String
        Get
            Return Vender()
        End Get
    End Property
    Public Function Vender() As Date
        Return Date.Now
    End Function
    Public Overrides Function ToString() As String
        Return Modelo.Nombre + " " + Modelo.Marca.Nombre
    End Function
End Class
