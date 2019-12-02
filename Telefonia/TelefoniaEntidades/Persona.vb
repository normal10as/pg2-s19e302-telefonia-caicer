Public Class Persona
    Inherits Cliente
    Public Sub New(Nombre As String, Apellido As String, Documento As UInteger)
        MyBase.New
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.Documento = Documento
    End Sub
    Private _nombre As String
    Private _apellido As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _apellido = value
            End If
        End Set
    End Property
    Public Property Documento As UInteger

    Public Overrides Function ToString() As String
        Return Apellido & " " & Nombre & " " & Cuenta
    End Function
End Class
