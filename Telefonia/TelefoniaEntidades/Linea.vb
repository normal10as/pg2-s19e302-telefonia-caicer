Public Class Linea
    Public Sub New(CodigoArea As UShort, Numero As UInteger, equipo As Equipo)
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
        Me.Equipo = equipo
    End Sub
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private LineaEstado As Byte = 1

    Public Property Equipo As Equipo
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value <= 9999 Then
                _codigoArea = value
            Else
                Throw New ArgumentException("Error de codigo")
            End If
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value <= 999999 Then
                _numero = value
            End If
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            If LineaEstado = 0 Then
                Return "Suspendido"
            End If
            Return "Activo"
        End Get
    End Property

    Public Sub Suspender()
        LineaEstado = 0
    End Sub
    Public Sub Reactivar()
        LineaEstado = 1
    End Sub
    Public Overrides Function ToString() As String
        If LineaEstado = 0 Then
            Return CodigoArea & " " & Numero & " " & Estado
        End If
        Return CodigoArea & " " & Numero
    End Function
End Class