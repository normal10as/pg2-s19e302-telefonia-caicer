Imports TelefoniaEntidades
Module ModeloTest
    Sub Modelo()
        Dim modelo1 As New Modelo("S8", New Marca("Samsung"))
        'Dim marca1 As New Marca
        Console.WriteLine("MODELO")
        Console.WriteLine("Modelo toString: " & modelo1.ToString)
        Console.WriteLine("Marca toString: " & modelo1.Marca.ToString)
        Console.WriteLine("Nombre Modelo: " & modelo1.Nombre)
        Console.WriteLine("Nombre Marca: " & modelo1.Marca.Nombre)
    End Sub
End Module
