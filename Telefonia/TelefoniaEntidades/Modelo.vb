Public Class Modelo
    Public Sub New(nombre As String, marca As Marca)
        Me.Nombre = nombre
        Me.Marca = marca
    End Sub
    Private _nombre As String
    Public Property Marca As Marca
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
