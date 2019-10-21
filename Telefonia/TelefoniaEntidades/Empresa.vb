Public Class Empresa
    Inherits Cliente
    Public Sub New(RazonSocial As String, Cuit As String)
        Me.RazonSocial = RazonSocial
        Me.Cuit = Cuit
    End Sub

    Private _razonsocial As String
    Private _cuit As String

    Public Property RazonSocial As String
        Get
            Return _razonsocial
        End Get
        Set(value As String)
            If value.Length <= 80 And value.Length > 0 Then
                _razonsocial = value
            End If
        End Set
    End Property
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value.Length <= 13 And value.Length > 0 Then
                _cuit = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return RazonSocial & "" & Cuenta
    End Function
End Class
