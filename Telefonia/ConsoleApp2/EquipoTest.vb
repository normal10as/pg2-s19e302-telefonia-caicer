Imports TelefoniaEntidades
Module EquipoTest
    Sub Equipo()
        Dim equipo1 As New Equipo("SM-G950T", New Modelo("S8", New Marca("samsung")))
        Console.WriteLine("EQUIPO")
        Console.WriteLine("Equipo toString: " & equipo1.ToString)
        Console.WriteLine("Equipo Serie: " & equipo1.Serie)
        Console.WriteLine("Equipo Fecha Venta: " & equipo1.FechaVenta)
        'Console.WriteLine("Equipo Venta: " & equipo1.venta)
        Console.WriteLine("E.Modelo tostring:" & equipo1.Modelo.ToString)
        Console.WriteLine("E.Modelo Nombre: " & equipo1.Modelo.Nombre)
        Console.WriteLine("E.M.Marca toString: " & equipo1.Modelo.Marca.ToString)
        Console.WriteLine("E.M.Marca Nombre: " & equipo1.Modelo.Marca.Nombre)
    End Sub
End Module
