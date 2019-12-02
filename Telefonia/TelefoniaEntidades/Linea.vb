Imports TelefoniaEntidades

Public Class Linea
    Implements Plan
    Sub New(CodigoArea As UShort, Numero As UInteger, equipo As Equipo, cliente As Cliente)
        Me.CodigoArea = CodigoArea
        Me.Numero = Numero
        Me.Equipo = equipo
        _cliente = New List(Of Cliente)
    End Sub
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private LineaEstado As Boolean = True
    Public Property Equipo As Equipo
    Private _cliente As List(Of Cliente)
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value >= 100 And value <= 9999 Then
                _codigoArea = value
            Else
                'Throw New ArgumentException("Error de codigo")
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
            If Not LineaEstado Then
                Return "Suspendido"
            End If
            Return "Activo"
        End Get
    End Property

    Public Property Precio As Decimal Implements Plan.Precio

    Public Sub AddCliente(cliente As Cliente)
        cliente.Linea = Me
        _cliente.Add(cliente)
    End Sub
    Public Function GetAllClientes() As List(Of Cliente)
        Return _cliente
    End Function
    Public Sub RemoveCuenta(cliente As Cliente)
        cliente.Linea = Me
        _cliente.Remove(cliente)
    End Sub
    Public Sub Suspender()
        LineaEstado = False
    End Sub
    Public Sub Reactivar()
        LineaEstado = True
    End Sub
    Public Overrides Function ToString() As String
        If Not LineaEstado Then
            Return CodigoArea & " " & Numero & " " & Estado
        End If
        Return CodigoArea & " " & Numero
    End Function
    Public Function getDisponilbeToString() As String Implements Plan.getDisponilbeToString

    End Function

    Public Function getConsumosToString() As String Implements Plan.getConsumosToString
        Throw New NotImplementedException()
    End Function
End Class
