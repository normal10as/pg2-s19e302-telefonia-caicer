Imports TelefoniaEntidades
Module LineaTest
    Sub Linea()
        Dim linea1 As New Linea(34, 50, New Equipo("SM-G950T", New Modelo("S8", New Marca("samsung"))), New Persona("hola", "chau", 3434))
        Console.WriteLine("LINEA")
        linea1.AddCliente(New Persona("Enzo", "Ortigoza", 3434))
        For Each cliente In linea1.GetAllClientes
            Console.WriteLine(cliente)
        Next
    End Sub
End Module
