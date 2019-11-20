Public Class Marca
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
