Imports System
Imports TelefoniaEntidades
Module MarcaTest
    Sub Marca()
        Dim marca1 As New Marca("Personal")
        Console.WriteLine("MARCA")
        Console.WriteLine("ToString: " & marca1.ToString)
    End Sub
End Module
