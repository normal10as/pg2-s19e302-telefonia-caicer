Public Class Equipo
    Private _serie As String
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
        Return Serie
    End Function
End Class
