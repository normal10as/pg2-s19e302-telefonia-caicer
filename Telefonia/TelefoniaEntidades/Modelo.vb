Public Class Modelo
    Public Sub New(NombreModelo As String)
        Me.NombreModelo = NombreModelo
    End Sub
    Private _nombreModelo As String
    Public Property NombreModelo As String
        Get
            Return _nombreModelo
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombreModelo = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return NombreModelo
    End Function
End Class
